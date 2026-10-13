using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai mau (ADO.NET): quan ly Khoa.
// Mac dinh dung InMemoryKhoaRepository (co san du lieu mau) de chay thu va kiem thu
// duoc ngay ma khong can cai SQL Server that. Muon dung SQL Server that, doi dong
// _repo ben duoi thanh: new SqlKhoaRepository(chuoiKetNoi) voi chuoi ket noi phu hop -
// toan bo code con lai cua Form khong can sua gi them vi deu di qua IKhoaRepository.
public partial class frmMauQLKhoa : Form
{
    private readonly IKhoaRepository _repo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());

    public frmMauQLKhoa()
    {
        InitializeComponent();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!KhoaValidation.ThemHopLe(txtMaKhoa.Text, txtTenKhoa.Text))
        {
            errorProvider1.SetError(txtMaKhoa, "Mã khoa và Tên khoa không được để trống");
            return;
        }

        try
        {
            _repo.Them(new Khoa { MaKhoa = txtMaKhoa.Text, TenKhoa = txtTenKhoa.Text });
            errorProvider1.SetError(txtMaKhoa, string.Empty);
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (!KhoaValidation.XoaHopLe(txtMaKhoa.Text))
        {
            errorProvider1.SetError(txtMaKhoa, "Mã khoa không được để trống");
            return;
        }

        try
        {
            _repo.Xoa(txtMaKhoa.Text);
            errorProvider1.SetError(txtMaKhoa, string.Empty);
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (!KhoaValidation.SuaHopLe(txtMaKhoa.Text, txtTenKhoa.Text))
        {
            errorProvider1.SetError(txtMaKhoa, "Mã khoa và Tên khoa không được để trống");
            return;
        }

        try
        {
            _repo.Sua(new Khoa { MaKhoa = txtMaKhoa.Text, TenKhoa = txtTenKhoa.Text });
            errorProvider1.SetError(txtMaKhoa, string.Empty);
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
