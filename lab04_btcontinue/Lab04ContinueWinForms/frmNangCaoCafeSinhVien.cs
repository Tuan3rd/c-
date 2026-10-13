using WinFormContinueLogic;

namespace Lab04ContinueWinForms;

// Bai 1 (nang cao): thu tien quan Cafe Sinh Vien.
public partial class frmNangCaoCafeSinhVien : Form
{
    private readonly List<int> _dsGiaoDichDaThanhToan = new();
    private int _soTienHienTai;

    public frmNangCaoCafeSinhVien()
    {
        InitializeComponent();
    }

    private void frmNangCaoCafeSinhVien_Load(object sender, EventArgs e)
    {
        txtTenKhachHang.Focus();
    }

    // Chi cho nhap so vao txtSoKhachHang, dung yeu cau de bai.
    private void txtSoKhachHang_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    // Goi lai moi khi ten khach hang / loai cafe / mon an thay doi, de bat/tat btnTinhTien.
    private void DuLieuThayDoi(object sender, EventArgs e)
    {
        bool coChonCafeHoacDoAn = rdoCafeDen.Checked || rdoCafeDa.Checked || rdoCafeSua.Checked ||
                                   rdoCafeSuaDa.Checked || rdoCafeKem.Checked ||
                                   chkBanhMyTrung.Checked || chkBanhMyCa.Checked || chkMyTomTrung.Checked ||
                                   chkMyXaoBo.Checked || chkMyCay.Checked;

        btnTinhTien.Enabled = CafeSinhVienLogic.TenKhachHangHopLe(txtTenKhachHang.Text) && coChonCafeHoacDoAn;
    }

    private LoaiCafe? LayCafeDangChon()
    {
        if (rdoCafeDen.Checked) return LoaiCafe.CafeDen;
        if (rdoCafeDa.Checked) return LoaiCafe.CafeDa;
        if (rdoCafeSua.Checked) return LoaiCafe.CafeSua;
        if (rdoCafeSuaDa.Checked) return LoaiCafe.CafeSuaDa;
        if (rdoCafeKem.Checked) return LoaiCafe.CafeKem;
        return null;
    }

    private IEnumerable<LoaiThucAn> LayDanhSachThucAnDaChon()
    {
        if (chkBanhMyTrung.Checked) yield return LoaiThucAn.BanhMyTrung;
        if (chkBanhMyCa.Checked) yield return LoaiThucAn.BanhMyCa;
        if (chkMyTomTrung.Checked) yield return LoaiThucAn.MyTomTrung;
        if (chkMyXaoBo.Checked) yield return LoaiThucAn.MyXaoBo;
        if (chkMyCay.Checked) yield return LoaiThucAn.MyCay;
    }

    private void btnTinhTien_Click(object sender, EventArgs e)
    {
        _soTienHienTai = CafeSinhVienLogic.TinhTien(LayCafeDangChon(), LayDanhSachThucAnDaChon(), chkSinhVien.Checked);

        MessageBox.Show(this,
            $"Khách hàng: {txtTenKhachHang.Text}\nSố tiền phải trả: {_soTienHienTai:N0} đ",
            "Tính tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);

        btnNhapLai.Enabled = true;
        btnThanhToan.Enabled = true;
    }

    private void btnNhapLai_Click(object sender, EventArgs e)
    {
        DatLaiTrangThaiNhapLieu();
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        _dsGiaoDichDaThanhToan.Add(_soTienHienTai);

        var (tongLuotKhach, tongTien) = CafeSinhVienLogic.TongKet(_dsGiaoDichDaThanhToan);
        txtTongKhachHang.Text = tongLuotKhach.ToString();
        txtTongTienThanhToan.Text = $"{tongTien:N0} đ";

        DatLaiTrangThaiNhapLieu();
    }

    // Dung chung cho ca Nhap Lai va sau khi Thanh Toan xong: dua Form ve trang thai
    // ban dau de san sang nhap nhom khach hang moi.
    private void DatLaiTrangThaiNhapLieu()
    {
        txtTenKhachHang.Clear();
        txtSoKhachHang.Clear();
        chkSinhVien.Checked = false;
        foreach (var rdo in new[] { rdoCafeDen, rdoCafeDa, rdoCafeSua, rdoCafeSuaDa, rdoCafeKem })
            rdo.Checked = false;
        foreach (var chk in new[] { chkBanhMyTrung, chkBanhMyCa, chkMyTomTrung, chkMyXaoBo, chkMyCay })
            chk.Checked = false;

        _soTienHienTai = 0;
        btnTinhTien.Enabled = false;
        btnNhapLai.Enabled = false;
        btnThanhToan.Enabled = false;
        txtTenKhachHang.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmNangCaoCafeSinhVien_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có chắc chắn muốn thoát khỏi chương trình?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
