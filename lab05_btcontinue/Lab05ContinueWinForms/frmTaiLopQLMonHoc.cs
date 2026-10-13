using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 1 (tai lop, ADO.NET): quan ly Mon hoc - cung mau CRUD 2 truong nhu Khoa.
public partial class frmTaiLopQLMonHoc : Form
{
    private readonly IMonHocRepository _repo = new InMemoryMonHocRepository(QLSinhVienDuLieuMau.MonHocMau());

    public frmTaiLopQLMonHoc()
    {
        InitializeComponent();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!MonHocValidation.ThemHopLe(txtMaMh.Text, txtTenMh.Text))
        {
            errorProvider1.SetError(txtMaMh, "Mã môn học và Tên môn học không được để trống");
            return;
        }

        try
        {
            _repo.Them(new MonHoc { MaMonHoc = txtMaMh.Text, TenMonHoc = txtTenMh.Text });
            errorProvider1.SetError(txtMaMh, string.Empty);
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (!MonHocValidation.XoaHopLe(txtMaMh.Text))
        {
            errorProvider1.SetError(txtMaMh, "Mã môn học không được để trống");
            return;
        }

        try
        {
            _repo.Xoa(txtMaMh.Text);
            errorProvider1.SetError(txtMaMh, string.Empty);
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (!MonHocValidation.SuaHopLe(txtMaMh.Text, txtTenMh.Text))
        {
            errorProvider1.SetError(txtMaMh, "Mã môn học và Tên môn học không được để trống");
            return;
        }

        try
        {
            _repo.Sua(new MonHoc { MaMonHoc = txtMaMh.Text, TenMonHoc = txtTenMh.Text });
            errorProvider1.SetError(txtMaMh, string.Empty);
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
