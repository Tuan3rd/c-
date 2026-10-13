using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai nang cao 2: quan ly Diem.
// So voi Lab06 (06a), bo sung: ComboBox chon Ma SV / Ma mon hoc (thay go tay nen luon
// dam bao ton tai FK), gioi han Diem trong [0, 10], va kiem tra TonTai() truoc khi Them.
public partial class frmQLDiem : Form
{
    private readonly ISinhVienRepository _svRepo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());
    private readonly IMonHocRepository _mhRepo = new InMemoryMonHocRepository(QLSinhVienDuLieuMau.MonHocMau());
    private readonly IDiemRepository _repo = new InMemoryDiemRepository(QLSinhVienDuLieuMau.DiemMau());

    public frmQLDiem()
    {
        InitializeComponent();
        LoadSinhVien_ComboBox();
        LoadMonHoc_ComboBox();
    }

    private void LoadSinhVien_ComboBox()
    {
        cboMaSv.Items.Clear();
        foreach (var sv in _svRepo.LayTatCa())
            cboMaSv.Items.Add(sv.MaSinhVien);

        if (cboMaSv.Items.Count > 0)
            cboMaSv.SelectedIndex = 0;
    }

    private void LoadMonHoc_ComboBox()
    {
        cboMaMh.Items.Clear();
        foreach (var mh in _mhRepo.LayTatCa())
            cboMaMh.Items.Add(mh.MaMonHoc);

        if (cboMaMh.Items.Count > 0)
            cboMaMh.SelectedIndex = 0;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string? maSv = cboMaSv.SelectedItem as string;
        string? maMh = cboMaMh.SelectedItem as string;

        if (!DiemValidation.ThemHopLe(maSv, maMh, txtDiem.Text))
        {
            errorProvider1.SetError(txtDiem, "Vui lòng chọn Mã sv, Mã mh và nhập Điểm hợp lệ (0-10)");
            return;
        }

        // FK: ca Sinh vien va Mon hoc phai da ton tai truoc khi them diem (ComboBox chi
        // chon tu danh sach da co nen truong hop nay chi xay ra neu danh sach bi rong).
        if (!_svRepo.TonTai(maSv!) || !_mhRepo.TonTai(maMh!))
        {
            MessageBox.Show(this, "Mã sinh viên hoặc Mã môn học không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_repo.TonTai(maSv!, maMh!))
        {
            errorProvider1.SetError(txtDiem, "Trùng điểm (sinh viên này đã có điểm môn này)");
            MessageBox.Show(this, "Trùng điểm (sinh viên này đã có điểm môn này)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DiemValidation.LaDiemHopLe(txtDiem.Text, out double diem);
        _repo.Them(new Diem { MaSinhVien = maSv!, MaMonHoc = maMh!, DiemSo = diem });
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        string? maSv = cboMaSv.SelectedItem as string;
        string? maMh = cboMaMh.SelectedItem as string;

        if (!DiemValidation.XoaHopLe(maSv, maMh))
        {
            errorProvider1.SetError(txtDiem, "Vui lòng chọn Mã sv và Mã mh");
            return;
        }

        if (!_repo.TonTai(maSv!, maMh!))
        {
            MessageBox.Show(this, "Không tìm thấy điểm của sinh viên/môn học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _repo.Xoa(maSv!, maMh!);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
        string? maSv = cboMaSv.SelectedItem as string;
        string? maMh = cboMaMh.SelectedItem as string;

        if (!DiemValidation.SuaHopLe(maSv, maMh, txtDiem.Text))
        {
            errorProvider1.SetError(txtDiem, "Vui lòng chọn Mã sv, Mã mh và nhập Điểm hợp lệ (0-10)");
            return;
        }

        if (!_repo.TonTai(maSv!, maMh!))
        {
            MessageBox.Show(this, "Không tìm thấy điểm của sinh viên/môn học này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DiemValidation.LaDiemHopLe(txtDiem.Text, out double diem);
        _repo.Sua(maSv!, maMh!, diem);
        errorProvider1.Clear();
        MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
