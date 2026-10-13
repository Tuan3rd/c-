using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Modal nho de them 1 San pham moi (MaSP tu dong tang, chi can nhap Ten SP).
public partial class frmThemSanPham : Form
{
    private readonly ISanPhamRepository _repo;

    public frmThemSanPham(ISanPhamRepository repo)
    {
        InitializeComponent();
        _repo = repo;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtTenSP.Text))
        {
            errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được để trống");
            return;
        }

        var sanPhamMoi = _repo.Them(txtTenSP.Text);
        MessageBox.Show(this, $"Đã thêm sản phẩm mới, Mã SP = {sanPhamMoi.MaSP}", "Thành công",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
