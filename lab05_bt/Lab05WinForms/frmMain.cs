namespace Lab05WinForms;

// Form menu chinh: mo cac form bai tap bang ShowDialog().
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void btnMauBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai1ListBox();
        form.ShowDialog(this);
    }

    private void btnMauBai2_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai2ComboBox();
        form.ShowDialog(this);
    }

    private void btnMauBai3_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai3TreeView();
        form.ShowDialog(this);
    }

    private void btnBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmBai1UocSo();
        form.ShowDialog(this);
    }

    private void btnBai2_Click(object sender, EventArgs e)
    {
        using var form = new frmBai2QuanLySinhVien();
        form.ShowDialog(this);
    }

    private void btnNangCaoBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmNangCaoChuoi();
        form.ShowDialog(this);
    }

    private void btnBtvnBai1_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnTuDien();
        form.ShowDialog(this);
    }

    private void btnBtvnBai2_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnListBoxSo();
        form.ShowDialog(this);
    }

    private void btnBtvnBai3_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnDanhBa();
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
