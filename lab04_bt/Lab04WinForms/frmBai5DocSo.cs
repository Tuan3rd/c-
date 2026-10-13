using WinFormLogic;

namespace Lab04WinForms;

// Bai 5 (BT tai lop): Doc so (1..999) thanh chu tieng Viet.
public partial class frmBai5DocSo : Form
{
    public frmBai5DocSo()
    {
        InitializeComponent();
    }

    private void btnThucHien_Click(object sender, EventArgs e)
    {
        if (!Bai5DocSoLogic.LaSoHopLe(txtNhapSo.Text, out int so))
        {
            errorProvider1.SetError(txtNhapSo, "Vui lòng nhập số nguyên từ 1 đến 999");
            lblKetQua.Text = string.Empty;
            return;
        }

        errorProvider1.SetError(txtNhapSo, string.Empty);
        lblKetQua.Text = Bai5DocSoLogic.DocSo(so);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        txtNhapSo.Clear();
        lblKetQua.Text = string.Empty;
        errorProvider1.Clear();
        txtNhapSo.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai5DocSo_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
