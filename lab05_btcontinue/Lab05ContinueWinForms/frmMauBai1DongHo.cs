using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 1 (mau): moi giay su kien Tick phat sinh, lay gio he thong hien thi len label.
public partial class frmMauBai1DongHo : Form
{
    public frmMauBai1DongHo()
    {
        InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        label1.Text = Bai1DongHoLogic.DinhDangGio(DateTime.Now);
    }

    private void frmMauBai1DongHo_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
