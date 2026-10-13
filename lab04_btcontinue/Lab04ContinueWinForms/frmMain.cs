namespace Lab04ContinueWinForms;

// Form menu chinh: mo cac form bai tap bang ShowDialog().
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void btnMauBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai1CongTruRadio();
        form.ShowDialog(this);
    }

    private void btnMauBai2_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai2Format();
        form.ShowDialog(this);
    }

    private void btnBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmBai1PhuongTrinh();
        form.ShowDialog(this);
    }

    private void btnBai2_Click(object sender, EventArgs e)
    {
        using var form = new frmBai2MangSoNguyen();
        form.ShowDialog(this);
    }

    private void btnNangCaoBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmNangCaoCafeSinhVien();
        form.ShowDialog(this);
    }

    private void btnBtvnBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnKhachSan();
        form.ShowDialog(this);
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn thoát chương trình?", "Thoát",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
