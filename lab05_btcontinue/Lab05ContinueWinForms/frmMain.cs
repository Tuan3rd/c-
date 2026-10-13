namespace Lab05ContinueWinForms;

// BTVN Bai 2: Form main co MenuStrip, gan tat ca bai tap trong tuan va hien thi cac
// Form khi chon menu tuong ung.
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void mnuMau1DongHo_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai1DongHo();
        form.ShowDialog(this);
    }

    private void mnuMau2ListView_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai2ListView();
        form.ShowDialog(this);
    }

    private void mnuMau3FileDialog_Click(object sender, EventArgs e)
    {
        using var form = new frmMauBai3FileDialog();
        form.ShowDialog(this);
    }

    private void mnuTaiLop1SinhVien_Click(object sender, EventArgs e)
    {
        using var form = new frmBai1SinhVienListView();
        form.ShowDialog(this);
    }

    private void mnuTaiLop2TaiKhoan_Click(object sender, EventArgs e)
    {
        using var form = new frmBai2TaiKhoan();
        form.ShowDialog(this);
    }

    private void mnuNangCaoHocVien_Click(object sender, EventArgs e)
    {
        using var form = new frmNangCaoHocVien();
        form.ShowDialog(this);
    }

    private void mnuVeNha1DemNguoc_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnDemNguoc();
        form.ShowDialog(this);
    }

    private void mnuMauKhoa_Click(object sender, EventArgs e)
    {
        using var form = new frmMauQLKhoa();
        form.ShowDialog(this);
    }

    private void mnuTaiLopMonHoc_Click(object sender, EventArgs e)
    {
        using var form = new frmTaiLopQLMonHoc();
        form.ShowDialog(this);
    }

    private void mnuNangCaoSinhVien_Click(object sender, EventArgs e)
    {
        using var form = new frmNangCaoQLSinhVien();
        form.ShowDialog(this);
    }

    private void mnuNangCaoDiem_Click(object sender, EventArgs e)
    {
        using var form = new frmNangCaoQLDiem();
        form.ShowDialog(this);
    }

    private void mnuVeNhaLop_Click(object sender, EventArgs e)
    {
        using var form = new frmBtvnQLLop();
        form.ShowDialog(this);
    }

    private void mnuThoat_Click(object sender, EventArgs e)
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
