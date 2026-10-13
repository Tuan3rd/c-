using WinFormContinueLogic;

namespace Lab04ContinueWinForms;

// Bai 1 (mau): Cong - Tru - Nhan - Chia hai so a, b, chon phep toan bang RadioButton.
public partial class frmMauBai1CongTruRadio : Form
{
    public frmMauBai1CongTruRadio()
    {
        InitializeComponent();
    }

    // Muc 2: chan ky tu khac so.
    private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
    {
        var textBox = (TextBox)sender;

        if (!Bai1RadioTinhToanLogic.LaKyTuNhapSoDuocPhep(e.KeyChar, textBox.Text, textBox.SelectionStart))
            e.Handled = true;
    }

    // Muc 1: ErrorProvider khi roi khoi textbox.
    private void txtSo_Leave(object sender, EventArgs e)
    {
        var textBox = (TextBox)sender;

        errorProvider1.SetError(textBox,
            Bai1RadioTinhToanLogic.LaSoHopLe(textBox.Text) ? string.Empty : "Giá trị nhập vào không phải là số hợp lệ");
    }

    private void btnTinh_Click(object sender, EventArgs e)
    {
        if (!Bai1RadioTinhToanLogic.LaSoHopLe(txtA.Text) || !Bai1RadioTinhToanLogic.LaSoHopLe(txtB.Text))
        {
            MessageBox.Show(this, "Vui lòng nhập đầy đủ số hợp lệ cho a và b.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        char? phepToan = Bai1RadioTinhToanLogic.PhepToanDangChon(
            rdoCong.Checked, rdoTru.Checked, rdoNhan.Checked, rdoChia.Checked);

        if (phepToan is null)
        {
            MessageBox.Show(this, "Vui lòng chọn một phép toán.", "Chưa chọn phép toán",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        float a = float.Parse(txtA.Text);
        float b = float.Parse(txtB.Text);

        if (phepToan == '/' && b == 0)
        {
            MessageBox.Show(this, "Phép chia bị lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var dt = new TinhToan(a, b);
        float ketQua = phepToan switch
        {
            '+' => dt.Cong(),
            '-' => dt.Tru(),
            '*' => dt.Nhan(),
            _ => dt.Chia()
        };

        txtKetQua.Text = $"{a} {phepToan} {b} = {ketQua}";
    }

    private void frmMauBai1CongTruRadio_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
