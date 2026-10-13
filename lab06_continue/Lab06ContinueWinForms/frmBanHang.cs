using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai 2 (ve nha): ban hang - tao 1 hoa don voi nhieu dong chi tiet, roi thanh toan 1 lan.
// Luu tam cac dong chi tiet trong _chiTietTam (chua ghi vao repository) cho den khi bam
// "Thanh toan" - luc do moi thuc su tao HoaDon + ChiTietHoaDon va cong SLBan vao ton kho.
public partial class frmBanHang : Form
{
    private readonly ISanPhamRepository _spRepo;
    private readonly ITonKhoRepository _tonKhoRepo;
    private readonly IHoaDonRepository _hoaDonRepo;
    private readonly IChiTietHoaDonRepository _chiTietRepo;
    private readonly List<(int MaSP, string TenSP, int SoLuong)> _chiTietTam = [];

    public frmBanHang(
        ISanPhamRepository spRepo,
        ITonKhoRepository tonKhoRepo,
        IHoaDonRepository hoaDonRepo,
        IChiTietHoaDonRepository chiTietRepo)
    {
        InitializeComponent();
        _spRepo = spRepo;
        _tonKhoRepo = tonKhoRepo;
        _hoaDonRepo = hoaDonRepo;
        _chiTietRepo = chiTietRepo;

        cboSanPham.DataSource = _spRepo.LayTatCa().ToList();
        cboSanPham.DisplayMember = nameof(SanPham.TenSP);
        cboSanPham.ValueMember = nameof(SanPham.MaSP);
    }

    private void btnThemChiTiet_Click(object sender, EventArgs e)
    {
        if (cboSanPham.SelectedValue is not int maSP)
            return;

        var tonKhoHomNay = _tonKhoRepo.LayTheoSanPhamVaNgay(maSP, DateTime.Today);
        if (tonKhoHomNay is null)
        {
            MessageBox.Show(this, "Chưa tạo tồn kho cho ngày hôm nay, vui lòng tạo tồn kho ngày mới trước khi bán",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_chiTietTam.Any(ct => ct.MaSP == maSP))
        {
            MessageBox.Show(this, "Sản phẩm này đã có trong hóa đơn, vui lòng xóa dòng cũ nếu muốn đổi số lượng",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int tonHienTai = TonKhoLogic.TonHienTai(tonKhoHomNay);
        if (!BanHangValidation.SoLuongHopLe(txtSoLuong.Text, tonHienTai, out int soLuong))
        {
            errorProvider1.SetError(txtSoLuong, $"Số lượng phải là số nguyên > 0 và không vượt quá tồn hiện tại ({tonHienTai})");
            return;
        }

        string tenSP = cboSanPham.Text;
        _chiTietTam.Add((maSP, tenSP, soLuong));
        errorProvider1.Clear();
        LamMoiDanhSachChiTiet();
    }

    private void LamMoiDanhSachChiTiet()
    {
        lvChiTiet.Items.Clear();
        foreach (var ct in _chiTietTam)
        {
            var item = new ListViewItem(ct.MaSP.ToString());
            item.SubItems.Add(ct.TenSP);
            item.SubItems.Add(ct.SoLuong.ToString());
            lvChiTiet.Items.Add(item);
        }
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        if (_chiTietTam.Count == 0)
        {
            MessageBox.Show(this, "Chưa có sản phẩm nào trong hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var hoaDon = _hoaDonRepo.TaoHoaDonMoi(DateTime.Today);

        foreach (var ct in _chiTietTam)
        {
            _chiTietRepo.Them(new ChiTietHoaDon { MaHD = hoaDon.MaHD, MaSP = ct.MaSP, SoLuong = ct.SoLuong });
            _tonKhoRepo.CongSoLuongBan(ct.MaSP, DateTime.Today, ct.SoLuong);
        }

        _hoaDonRepo.DanhDauDaThanhToan(hoaDon.MaHD);

        MessageBox.Show(this, $"Thanh toán thành công, Mã hóa đơn = {hoaDon.MaHD}", "Thành công",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
