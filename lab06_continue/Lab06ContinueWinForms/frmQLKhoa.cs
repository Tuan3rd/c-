using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai mau: quan ly Khoa.
// Khac frmQLKhoa cua Lab06 (06a): o day em lam theo DUNG mau cua de bai 06b - kiem tra
// TonTai() TRUOC khi goi Them(), bao "Trung ma khoa" ngay tu dau thay vi chi dua vao
// catch(Exception) sau khi _repo.Them() da nem loi.
public partial class frmQLKhoa : Form
{
    private readonly IKhoaRepository _repo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());

    public frmQLKhoa()
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

        if (_repo.TonTai(txtMaKhoa.Text))
        {
            errorProvider1.SetError(txtMaKhoa, "Trùng mã khoa");
            MessageBox.Show(this, "Trùng mã khoa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Them(new Khoa { MaKhoa = txtMaKhoa.Text, TenKhoa = txtTenKhoa.Text });
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (!KhoaValidation.XoaHopLe(txtMaKhoa.Text))
        {
            errorProvider1.SetError(txtMaKhoa, "Mã khoa không được để trống");
            return;
        }

        if (!_repo.TonTai(txtMaKhoa.Text))
        {
            MessageBox.Show(this, "Không tìm thấy mã khoa này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Xoa(txtMaKhoa.Text);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        if (!KhoaValidation.SuaHopLe(txtMaKhoa.Text, txtTenKhoa.Text))
        {
            errorProvider1.SetError(txtMaKhoa, "Mã khoa và Tên khoa không được để trống");
            return;
        }

        if (!_repo.TonTai(txtMaKhoa.Text))
        {
            MessageBox.Show(this, "Không tìm thấy mã khoa này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Sua(new Khoa { MaKhoa = txtMaKhoa.Text, TenKhoa = txtTenKhoa.Text });
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
