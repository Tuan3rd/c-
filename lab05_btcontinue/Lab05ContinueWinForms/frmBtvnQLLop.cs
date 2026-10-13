using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 1 (ve nha, ADO.NET): quan ly Lop.
// Xoa chi can Ma lop; Sua chi can Ma lop + it nhat 1 trong (Ma khoa/Ten lop) co du lieu.
public partial class frmBtvnQLLop : Form
{
    private readonly ILopRepository _repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

    public frmBtvnQLLop()
    {
        InitializeComponent();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!LopValidation.ThemHopLe(txtMaKhoa.Text, txtMaLop.Text, txtTenLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Mã khoa, Mã lớp, Tên lớp không được để trống");
            return;
        }

        try
        {
            _repo.Them(new Lop { MaLop = txtMaLop.Text, TenLop = txtTenLop.Text, MaKhoa = txtMaKhoa.Text });
            errorProvider1.Clear();
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (!LopValidation.XoaHopLe(txtMaLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Mã lớp không được để trống");
            return;
        }

        try
        {
            _repo.Xoa(txtMaLop.Text);
            errorProvider1.Clear();
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (!LopValidation.SuaHopLe(txtMaLop.Text, txtMaKhoa.Text, txtTenLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Mã lớp bắt buộc, và cần ít nhất 1 trong Mã khoa/Tên lớp");
            return;
        }

        try
        {
            _repo.Sua(
                txtMaLop.Text,
                tenLopMoi: string.IsNullOrWhiteSpace(txtTenLop.Text) ? null : txtTenLop.Text,
                maKhoaMoi: string.IsNullOrWhiteSpace(txtMaKhoa.Text) ? null : txtMaKhoa.Text);
            errorProvider1.Clear();
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
