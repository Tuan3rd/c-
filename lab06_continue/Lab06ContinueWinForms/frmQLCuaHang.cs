using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai ve nha: quan ly Cua hang (ton kho + ban hang). Day la mien du lieu hoan toan moi
// (SanPham/TonKho/HoaDon/ChiTietHoaDon), khong co trong Lab06 (06a).
// 3 chuc nang chinh: tao dong ton kho cho ngay moi (theo cong thuc chuyen so du), them
// san pham moi, va ban hang (tao hoa don + cap nhat SLBan trong ngay).
public partial class frmQLCuaHang : Form
{
    private readonly ISanPhamRepository _spRepo = new InMemorySanPhamRepository(QLCuaHangDuLieuMau.SanPhamMau());
    private readonly ITonKhoRepository _tonKhoRepo = new InMemoryTonKhoRepository(QLCuaHangDuLieuMau.TonKhoMau());
    private readonly IHoaDonRepository _hoaDonRepo = new InMemoryHoaDonRepository(QLCuaHangDuLieuMau.HoaDonMau());
    private readonly IChiTietHoaDonRepository _chiTietRepo = new InMemoryChiTietHoaDonRepository(QLCuaHangDuLieuMau.ChiTietHoaDonMau());

    public frmQLCuaHang()
    {
        InitializeComponent();
        dtpNgayMoi.Value = QLCuaHangDuLieuMau.NgayMauBanDau.AddDays(1);
        LamMoiDanhSach();
    }

    private void LamMoiDanhSach()
    {
        lvTonKho.Items.Clear();
        var dsSanPham = _spRepo.LayTatCa();

        foreach (var tonKho in _tonKhoRepo.LayTatCa().OrderBy(t => t.NgayTon).ThenBy(t => t.MaSP))
        {
            string tenSP = dsSanPham.FirstOrDefault(sp => sp.MaSP == tonKho.MaSP)?.TenSP ?? "";

            var item = new ListViewItem(tonKho.MaSP.ToString());
            item.SubItems.Add(tenSP);
            item.SubItems.Add(tonKho.NgayTon.ToString("dd/MM/yyyy"));
            item.SubItems.Add(tonKho.SLDau.ToString());
            item.SubItems.Add(tonKho.SLNhap.ToString());
            item.SubItems.Add(tonKho.SLBan.ToString());
            item.SubItems.Add(TonKhoLogic.TonHienTai(tonKho).ToString());
            lvTonKho.Items.Add(item);
        }
    }

    // Bai 1 (ve nha): tao dong ton kho moi cho TAT CA san pham vao ngay da chon, theo
    // cong thuc SLDau(moi) = SLDau(truoc) + SLNhap(truoc) - SLBan(truoc). Bo qua san pham
    // da co dong ton kho cho dung ngay nay roi (tranh tao trung).
    private void btnTaoTonKhoMoi_Click(object sender, EventArgs e)
    {
        DateTime ngayMoi = dtpNgayMoi.Value.Date;
        int soDongDaTao = 0;

        foreach (var sanPham in _spRepo.LayTatCa())
        {
            if (_tonKhoRepo.LayTheoSanPhamVaNgay(sanPham.MaSP, ngayMoi) is not null)
                continue;

            var tonKhoCuaSanPham = _tonKhoRepo.LayTatCa().Where(t => t.MaSP == sanPham.MaSP);
            var donGanNhat = TonKhoLogic.DongGanNhatTruocNgay(tonKhoCuaSanPham, ngayMoi);
            var dongMoi = TonKhoLogic.TaoDongNgayMoi(donGanNhat, sanPham.MaSP, ngayMoi);

            _tonKhoRepo.Them(dongMoi);
            soDongDaTao++;
        }

        LamMoiDanhSach();
        MessageBox.Show(this, $"Đã tạo tồn kho ngày {ngayMoi:dd/MM/yyyy} cho {soDongDaTao} sản phẩm (sản phẩm đã có dữ liệu ngày này được bỏ qua)",
            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnThemSanPham_Click(object sender, EventArgs e)
    {
        using var form = new frmThemSanPham(_spRepo);
        form.ShowDialog(this);
    }

    private void btnBanHang_Click(object sender, EventArgs e)
    {
        using var form = new frmBanHang(_spRepo, _tonKhoRepo, _hoaDonRepo, _chiTietRepo);
        form.ShowDialog(this);
        LamMoiDanhSach();
    }

    private void btnLamMoi_Click(object sender, EventArgs e)
    {
        LamMoiDanhSach();
    }

    private void btnDong_Click(object sender, EventArgs e)
    {
        Close();
    }
}
