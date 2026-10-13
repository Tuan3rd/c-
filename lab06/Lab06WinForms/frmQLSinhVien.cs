using QLSinhVienLogic;

namespace Lab06WinForms;

// Bai 1 (nang cao): quan ly Sinh vien.
// Khac voi Khoa/MonHoc, bai nay co quy tac rieng: Xoa can Ma SV + Ho ten khop nhau;
// Sua chi can Ma SV + it nhat 1 truong khac co du lieu (cac truong con lai giu nguyen).
public partial class frmQLSinhVien : Form
{
    private readonly ISinhVienRepository _repo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());

    public frmQLSinhVien()
    {
        InitializeComponent();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!SinhVienValidation.ThemHopLe(txtMaLop.Text, txtMaSv.Text, txtHoTen.Text, txtNgaySinh.Text))
        {
            errorProvider1.SetError(txtMaSv, "Vui lòng nhập đủ Mã lớp, Mã sv, Họ tên, Ngày sinh");
            return;
        }

        if (!SinhVienValidation.NgaySinhHopLe(txtNgaySinh.Text, out DateTime ngaySinh))
        {
            errorProvider1.SetError(txtNgaySinh, "Ngày sinh không hợp lệ (dd/MM/yyyy)");
            return;
        }

        try
        {
            _repo.Them(new SinhVien
            {
                MaLop = txtMaLop.Text,
                MaSinhVien = txtMaSv.Text,
                HoTen = txtHoTen.Text,
                NgaySinh = ngaySinh
            });
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
        if (!SinhVienValidation.XoaHopLe(txtMaSv.Text, txtHoTen.Text))
        {
            errorProvider1.SetError(txtMaSv, "Mã sv và Họ tên không được để trống");
            return;
        }

        try
        {
            _repo.Xoa(txtMaSv.Text, txtHoTen.Text);
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
        if (!SinhVienValidation.SuaHopLe(txtMaSv.Text, txtMaLop.Text, txtHoTen.Text, txtNgaySinh.Text))
        {
            errorProvider1.SetError(txtMaSv, "Mã sv bắt buộc, và cần ít nhất 1 trong Mã lớp/Họ tên/Ngày sinh");
            return;
        }

        DateTime? ngaySinhMoi = null;
        if (!string.IsNullOrWhiteSpace(txtNgaySinh.Text))
        {
            if (!SinhVienValidation.NgaySinhHopLe(txtNgaySinh.Text, out DateTime ns))
            {
                errorProvider1.SetError(txtNgaySinh, "Ngày sinh không hợp lệ (dd/MM/yyyy)");
                return;
            }
            ngaySinhMoi = ns;
        }

        try
        {
            _repo.Sua(
                txtMaSv.Text,
                maLopMoi: string.IsNullOrWhiteSpace(txtMaLop.Text) ? null : txtMaLop.Text,
                hoTenMoi: string.IsNullOrWhiteSpace(txtHoTen.Text) ? null : txtHoTen.Text,
                ngaySinhMoi: ngaySinhMoi);
            errorProvider1.Clear();
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
