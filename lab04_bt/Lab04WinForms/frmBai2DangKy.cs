using WinFormLogic;

namespace Lab04WinForms;

// Bai 2 (BT tai lop): Form dang ky tai khoan.
public partial class frmBai2DangKy : Form
{
    public frmBai2DangKy()
    {
        InitializeComponent();
    }

    // Kiem tra dinh dang email ngay khi nguoi dung roi khoi textbox.
    private void txtEmail_Leave(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !Bai2DangKyLogic.LaEmailHopLe(txtEmail.Text))
            errorProvider1.SetError(txtEmail, "Địa chỉ email không đúng định dạng");
        else
            errorProvider1.SetError(txtEmail, string.Empty);
    }

    // Cac truong co (*) bat buoc nhap: bao loi ngay khi roi khoi textbox neu de trong.
    private void txtTenDangNhap_Leave(object sender, EventArgs e)
    {
        BaoLoiNeuTrong(txtTenDangNhap, "Tên đăng nhập không được để trống");
    }

    private void txtMatKhau_Leave(object sender, EventArgs e)
    {
        BaoLoiNeuTrong(txtMatKhau, "Mật khẩu không được để trống");
    }

    private void BaoLoiNeuTrong(TextBox textBox, string noiDungLoi)
    {
        errorProvider1.SetError(textBox, string.IsNullOrWhiteSpace(textBox.Text) ? noiDungLoi : string.Empty);
    }

    private void btnDangKy_Click(object sender, EventArgs e)
    {
        var danhSachLoi = Bai2DangKyLogic.KiemTraDangKy(
            txtTenDangNhap.Text, txtEmail.Text, txtMatKhau.Text, txtXacNhanMatKhau.Text);

        if (danhSachLoi.Count > 0)
        {
            MessageBox.Show(this, string.Join("\n", danhSachLoi), "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string thongBao = Bai2DangKyLogic.TaoThongBaoDangKy(txtTenDangNhap.Text, txtEmail.Text, txtMatKhau.Text);
        MessageBox.Show(this, thongBao, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void frmBai2DangKy_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
