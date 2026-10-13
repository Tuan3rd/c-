using WinFormContinueLogic;

namespace Lab04ContinueWinForms;

// Bai 1 (BT ve nha): thanh toan tien phong khach san Thanh Thanh.
public partial class frmBtvnKhachSan : Form
{
    private readonly List<int> _dsGiaoDichChuaTongKet = new();
    private int _thanhTienHienTai;

    public frmBtvnKhachSan()
    {
        InitializeComponent();
    }

    private void frmBtvnKhachSan_Load(object sender, EventArgs e)
    {
        txtHoTen.Focus();
    }

    private void txtSoNgayO_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private void DuLieuThayDoi(object sender, EventArgs e)
    {
        bool duDuLieu = KhachSanThanhThanhLogic.TenKhachHopLe(txtHoTen.Text) &&
                        KhachSanThanhThanhLogic.DiaChiHopLe(txtDiaChi.Text) &&
                        KhachSanThanhThanhLogic.SoNgayOHopLe(txtSoNgayO.Text, out _);

        btnThanhToan.Enabled = duDuLieu;
    }

    private LoaiPhong LayLoaiPhongDangChon()
    {
        if (rdoPhongDoi.Checked) return LoaiPhong.PhongDoi;
        if (rdoPhongBa.Checked) return LoaiPhong.PhongBa;
        return LoaiPhong.PhongDon;
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        if (!KhachSanThanhThanhLogic.SoNgayOHopLe(txtSoNgayO.Text, out int soNgayO))
        {
            errorProvider1.SetError(txtSoNgayO, "Số ngày ở phải là số nguyên dương");
            return;
        }

        int soLuongTienNghi = new[] { chkTivi, chkInternet, chkMayNuocNong }.Count(c => c.Checked);

        _thanhTienHienTai = KhachSanThanhThanhLogic.TinhThanhTien(
            LayLoaiPhongDangChon(), soNgayO, soLuongTienNghi, chkKaraoke.Checked, chkAnSang.Checked);

        txtThanhTien.Text = $"{_thanhTienHienTai:N0} VNĐ";
        _dsGiaoDichChuaTongKet.Add(_thanhTienHienTai);

        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;
    }

    private void btnNhapMoi_Click(object sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtDiaChi.Clear();
        txtSoNgayO.Clear();
        rdoPhongDon.Checked = true;
        chkTivi.Checked = false;
        chkInternet.Checked = false;
        chkMayNuocNong.Checked = false;
        chkKaraoke.Checked = false;
        chkAnSang.Checked = false;
        txtThanhTien.Clear();
        _thanhTienHienTai = 0;

        btnNhapMoi.Enabled = false;
        txtHoTen.Focus();
    }

    private void btnTongKet_Click(object sender, EventArgs e)
    {
        var (tongLuotKhach, tongTien) = KhachSanThanhThanhLogic.TongKet(_dsGiaoDichChuaTongKet);

        txtSoLuotNguoi.Text = tongLuotKhach.ToString();
        txtTongSoTien.Text = $"{tongTien:N0} VNĐ";

        // Dung yeu cau de bai: sau khi tong ket, dat lai bo dem ve 0 de bat dau ngay moi.
        _dsGiaoDichChuaTongKet.Clear();
        btnTongKet.Enabled = false;
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBtvnKhachSan_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có chắc chắn muốn thoát khỏi chương trình?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
