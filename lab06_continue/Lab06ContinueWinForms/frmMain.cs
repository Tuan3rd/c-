namespace Lab06ContinueWinForms;

// Form menu chinh: mo cac form Quan ly Khoa/Lop/SinhVien/Diem/Cua hang bang ShowDialog().
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

    private void btnTaiLopLop_Click(object sender, EventArgs e)
    {
        using var form = new frmQLLop();
        form.ShowDialog(this);
    }

    private void btnDanhSachLop_Click(object sender, EventArgs e)
    {
        using var form = new frmDanhSachLop();
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

    private void btnDanhSachDiem_Click(object sender, EventArgs e)
    {
        using var form = new frmDanhSachDiem();
        form.ShowDialog(this);
    }

    private void btnVeNhaCuaHang_Click(object sender, EventArgs e)
    {
        using var form = new frmQLCuaHang();
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
