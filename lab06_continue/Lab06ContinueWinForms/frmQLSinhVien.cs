using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai nang cao 1: quan ly Sinh vien.
// So voi Lab06 (06a), bo sung: ComboBox chon Ma lop (thay go tay), kiem tra TonTai()
// truoc khi Them (bao "Trùng mã sinh viên"), va rang buoc tuoi >= 17 (chi tinh nam sinh).
// Xoa trong lab nay chi can Ma SV (xem SinhVienValidation.XoaHopLe) - Ho ten duoc tu
// dong lay tu dong dang chon trong danh sach mau, khong can nguoi dung go lai.
public partial class frmQLSinhVien : Form
{
    private readonly ILopRepository _lopRepo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());
    private readonly ISinhVienRepository _repo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());

    public frmQLSinhVien()
    {
        InitializeComponent();
        LoadLop_ComboBox();
    }

    private void LoadLop_ComboBox()
    {
        cboMaLop.Items.Clear();
        foreach (var lop in _lopRepo.LayTatCa())
            cboMaLop.Items.Add(lop.MaLop);

        if (cboMaLop.Items.Count > 0)
            cboMaLop.SelectedIndex = 0;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string? maLop = cboMaLop.SelectedItem as string;

        if (!SinhVienValidation.ThemHopLe(maLop, txtMaSv.Text, txtHoTen.Text, txtNgaySinh.Text))
        {
            errorProvider1.SetError(txtMaSv, "Vui lòng chọn Mã lớp và nhập đủ Mã sv, Họ tên, Ngày sinh");
            return;
        }

        if (!SinhVienValidation.NgaySinhHopLe(txtNgaySinh.Text, out DateTime ngaySinh))
        {
            errorProvider1.SetError(txtNgaySinh, "Ngày sinh không hợp lệ (dd/MM/yyyy)");
            return;
        }

        if (!SinhVienValidation.TuoiHopLe(ngaySinh))
        {
            errorProvider1.SetError(txtNgaySinh, $"Sinh viên phải từ {SinhVienValidation.TuoiToiThieu} tuổi trở lên");
            MessageBox.Show(this, $"Sinh viên phải từ {SinhVienValidation.TuoiToiThieu} tuổi trở lên (tính theo năm sinh)",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_repo.TonTai(txtMaSv.Text))
        {
            errorProvider1.SetError(txtMaSv, "Trùng mã sinh viên");
            MessageBox.Show(this, "Trùng mã sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Them(new SinhVien { MaLop = maLop!, MaSinhVien = txtMaSv.Text, HoTen = txtHoTen.Text, NgaySinh = ngaySinh });
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (!SinhVienValidation.XoaHopLe(txtMaSv.Text))
        {
            errorProvider1.SetError(txtMaSv, "Mã sv không được để trống");
            return;
        }

        var sv = _repo.LayTatCa().FirstOrDefault(s => s.MaSinhVien == txtMaSv.Text);
        if (sv is null)
        {
            MessageBox.Show(this, "Không tìm thấy mã sinh viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Xoa(sv.MaSinhVien, sv.HoTen);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        string? maLopMoi = cboMaLop.SelectedItem as string;

        if (!SinhVienValidation.SuaHopLe(txtMaSv.Text, maLopMoi, txtHoTen.Text, txtNgaySinh.Text))
        {
            errorProvider1.SetError(txtMaSv, "Vui lòng nhập đủ Mã sv, Mã lớp, Họ tên, Ngày sinh");
            return;
        }

        if (!SinhVienValidation.NgaySinhHopLe(txtNgaySinh.Text, out DateTime ngaySinh))
        {
            errorProvider1.SetError(txtNgaySinh, "Ngày sinh không hợp lệ (dd/MM/yyyy)");
            return;
        }

        if (!SinhVienValidation.TuoiHopLe(ngaySinh))
        {
            errorProvider1.SetError(txtNgaySinh, $"Sinh viên phải từ {SinhVienValidation.TuoiToiThieu} tuổi trở lên");
            MessageBox.Show(this, $"Sinh viên phải từ {SinhVienValidation.TuoiToiThieu} tuổi trở lên (tính theo năm sinh)",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!_repo.TonTai(txtMaSv.Text))
        {
            MessageBox.Show(this, "Không tìm thấy mã sinh viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Sua(txtMaSv.Text, maLopMoi: maLopMoi, hoTenMoi: txtHoTen.Text, ngaySinhMoi: ngaySinh);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
