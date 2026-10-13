namespace Lab04WinForms;

// Form menu chinh: mo cac form bai tap bang ShowDialog() (dong vai tro cua
// "nhieu Form trong cung mot Project" theo huong dan trong tai lieu thuc hanh).
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void btnBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmBai1CongTru();
        form.ShowDialog(this);
    }

    private void btnBai2_Click(object sender, EventArgs e)
    {
        using var form = new frmBai2DangKy();
        form.ShowDialog(this);
    }

    private void btnBai3_Click(object sender, EventArgs e)
    {
        using var form = new frmBai3UocBoi();
        form.ShowDialog(this);
    }

    private void btnBai4_Click(object sender, EventArgs e)
    {
        using var form = new frmBai4DaySo();
        form.ShowDialog(this);
    }

    private void btnBai5_Click(object sender, EventArgs e)
    {
        using var form = new frmBai5DocSo();
        form.ShowDialog(this);
    }

    private void btnNangCaoBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmNangCaoBanVe();
        form.ShowDialog(this);
    }

    private void btnBtvnBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnMayTinh();
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
