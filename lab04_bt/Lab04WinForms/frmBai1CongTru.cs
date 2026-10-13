using WinFormLogic;

namespace Lab04WinForms;

// Bai 1 (BT tai lop): May tinh Cong - Tru - Nhan - Chia hai so a, b.
// Toan bo phep tinh/validate nam o WinFormLogic.Bai1TinhToanLogic (co unit test rieng);
// Form chi lam nhiem vu lay du lieu tu control va hien thi ket qua.
public partial class frmBai1CongTru : Form
{
    public frmBai1CongTru()
    {
        InitializeComponent();
    }

    // Muc 2: chan khong cho nguoi dung go ky tu khac so vao txtA/txtB.
    private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
    {
        var textBox = (TextBox)sender;

        if (!Bai1TinhToanLogic.LaKyTuNhapSoDuocPhep(e.KeyChar, textBox.Text, textBox.SelectionStart))
            e.Handled = true;
    }

    // Muc 1: khi roi khoi textbox, neu du lieu khong hop le thi bao loi bang ErrorProvider.
    private void txtSo_Leave(object sender, EventArgs e)
    {
        var textBox = (TextBox)sender;

        if (!Bai1TinhToanLogic.LaSoHopLe(textBox.Text))
            errorProvider1.SetError(textBox, "Giá trị nhập vào không phải là số hợp lệ");
        else
            errorProvider1.SetError(textBox, string.Empty);
    }

    private void btnCong_Click(object sender, EventArgs e) => ThucHienPhepTinh(Bai1TinhToanLogic.Cong);

    private void btnTru_Click(object sender, EventArgs e) => ThucHienPhepTinh(Bai1TinhToanLogic.Tru);

    private void btnNhan_Click(object sender, EventArgs e) => ThucHienPhepTinh(Bai1TinhToanLogic.Nhan);

    private void btnChia_Click(object sender, EventArgs e) => ThucHienPhepTinh(Bai1TinhToanLogic.Chia);

    private void ThucHienPhepTinh(Func<double, double, double> phepTinh)
    {
        if (!TryLayDuLieuHopLe(out double a, out double b))
            return;

        try
        {
            txtKetQua.Text = phepTinh(a, b).ToString();
        }
        catch (DivideByZeroException ex)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool TryLayDuLieuHopLe(out double a, out double b)
    {
        a = b = 0;

        if (!Bai1TinhToanLogic.LaSoHopLe(txtA.Text) || !Bai1TinhToanLogic.LaSoHopLe(txtB.Text))
        {
            MessageBox.Show(this, "Vui lòng nhập đầy đủ số hợp lệ cho a và b.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        a = double.Parse(txtA.Text);
        b = double.Parse(txtB.Text);
        return true;
    }

    private void frmBai1CongTru_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
