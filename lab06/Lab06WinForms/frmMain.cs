namespace Lab06WinForms;

// Form menu chinh: mo cac form Quan ly Khoa/MonHoc/SinhVien/Diem/Lop bang ShowDialog().
public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void btnMauKhoa_Click(object sender, EventArgs e)
    {
        using var form = new frmQLKhoa();
        form.ShowDialog(this);
    }

    private void btnTaiLopMonHoc_Click(object sender, EventArgs e)
    {
        using var form = new frmQLMonHoc();
        form.ShowDialog(this);
    }

    private void btnNangCaoSinhVien_Click(object sender, EventArgs e)
    {
        using var form = new frmQLSinhVien();
        form.ShowDialog(this);
    }

    private void btnNangCaoDiem_Click(object sender, EventArgs e)
    {
        using var form = new frmQLDiem();
        form.ShowDialog(this);
    }

    private void btnVeNhaLop_Click(object sender, EventArgs e)
    {
        using var form = new frmQLLop();
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
