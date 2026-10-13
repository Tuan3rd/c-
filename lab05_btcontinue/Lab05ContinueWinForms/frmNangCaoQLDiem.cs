using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 2 (nang cao, ADO.NET): quan ly Diem.
// Xoa khong can nhap Diem; Them/Sua bat buoc Diem va phai la so (khac Khoa/MonHoc).
public partial class frmNangCaoQLDiem : Form
{
    private readonly IDiemRepository _repo = new InMemoryDiemRepository(QLSinhVienDuLieuMau.DiemMau());

    public frmNangCaoQLDiem()
    {
        InitializeComponent();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!DiemValidation.ThemHopLe(txtMaSv.Text, txtMaMh.Text, txtDiem.Text))
        {
            errorProvider1.SetError(txtDiem, "Mã sv, Mã mh không được để trống và Điểm phải là số");
            return;
        }

        DiemValidation.LaDiemHopLe(txtDiem.Text, out double diem);

        try
        {
            _repo.Them(new Diem { MaSinhVien = txtMaSv.Text, MaMonHoc = txtMaMh.Text, DiemSo = diem });
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
        if (!DiemValidation.XoaHopLe(txtMaSv.Text, txtMaMh.Text))
        {
            errorProvider1.SetError(txtMaSv, "Mã sv và Mã mh không được để trống");
            return;
        }

        try
        {
            _repo.Xoa(txtMaSv.Text, txtMaMh.Text);
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
        if (!DiemValidation.SuaHopLe(txtMaSv.Text, txtMaMh.Text, txtDiem.Text))
        {
            errorProvider1.SetError(txtDiem, "Mã sv, Mã mh không được để trống và Điểm phải là số");
            return;
        }

        DiemValidation.LaDiemHopLe(txtDiem.Text, out double diem);

        try
        {
            _repo.Sua(txtMaSv.Text, txtMaMh.Text, diem);
            errorProvider1.Clear();
            MessageBox.Show(this, "Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "Thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
