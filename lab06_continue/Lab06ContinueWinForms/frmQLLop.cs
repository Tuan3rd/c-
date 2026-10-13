using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai 1 (tai lop): quan ly Lop.
// So voi frmQLLop cua Lab06 (06a), lab nay bo sung:
//  - ComboBox chon Ma khoa (lay tu IKhoaRepository) thay vi go tay, giong cach
//    LoadKhoa_ComboBox() trong de bai dung SqlDataReader de do du lieu vao ComboBox.
//  - Kiem tra TonTai() truoc khi Them(), bao dung "Trùng mã lớp" - de bai mau (sao chep
//    tu form Khoa) bi loi, hien thi nham "Trung ma khoa" khi them lop bi trung ma; em
//    sua lai cho dung ngu canh cua form Lop.
//  - Sua bay gio bat buoc nhap du CA Ma khoa moi va Ten lop moi (xem LopValidation.SuaHopLe).
public partial class frmQLLop : Form
{
    private readonly IKhoaRepository _khoaRepo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());
    private readonly ILopRepository _repo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

    public frmQLLop()
    {
        InitializeComponent();
        LoadKhoa_ComboBox();
    }

    private void LoadKhoa_ComboBox()
    {
        cboMaKhoa.Items.Clear();
        foreach (var khoa in _khoaRepo.LayTatCa())
            cboMaKhoa.Items.Add(khoa.MaKhoa);

        if (cboMaKhoa.Items.Count > 0)
            cboMaKhoa.SelectedIndex = 0;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string? maKhoa = cboMaKhoa.SelectedItem as string;

        if (!LopValidation.ThemHopLe(maKhoa, txtMaLop.Text, txtTenLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Mã khoa, Mã lớp, Tên lớp không được để trống");
            return;
        }

        if (_repo.TonTai(txtMaLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Trùng mã lớp");
            MessageBox.Show(this, "Trùng mã lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Them(new Lop { MaLop = txtMaLop.Text, TenLop = txtTenLop.Text, MaKhoa = maKhoa! });
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (!LopValidation.XoaHopLe(txtMaLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Mã lớp không được để trống");
            return;
        }

        if (!_repo.TonTai(txtMaLop.Text))
        {
            MessageBox.Show(this, "Không tìm thấy mã lớp này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Rang buoc khoa ngoai: khong cho xoa Lop con Sinh vien (mo phong SQL Server tu
        // choi DELETE khi vi pham FOREIGN KEY). Du lieu sinh vien mau lay tu cung mot
        // repository mau de kiem tra nhat quan voi du lieu dang hien thi trong ung dung.
        var dsSinhVien = QLSinhVienDuLieuMau.SinhVienMau();
        if (!LopValidation.CoTheXoa(txtMaLop.Text, dsSinhVien))
        {
            MessageBox.Show(this, "Không thể xóa: vẫn còn sinh viên thuộc lớp này",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Xoa(txtMaLop.Text);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        string? maKhoaMoi = cboMaKhoa.SelectedItem as string;

        if (!LopValidation.SuaHopLe(txtMaLop.Text, maKhoaMoi, txtTenLop.Text))
        {
            errorProvider1.SetError(txtMaLop, "Mã lớp, Mã khoa mới, Tên lớp mới không được để trống");
            return;
        }

        if (!_repo.TonTai(txtMaLop.Text))
        {
            MessageBox.Show(this, "Không tìm thấy mã lớp này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Sua(txtMaLop.Text, tenLopMoi: txtTenLop.Text, maKhoaMoi: maKhoaMoi);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
