using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai nang cao 2 (phan 2): hien thi danh sach Diem (join SinhVien + MonHoc) len ListView,
// co the loc theo 1 Mon hoc cu the hoac chon dong trong trong ComboBox de xem tat ca.
public partial class frmDanhSachDiem : Form
{
    private readonly IDiemRepository _diemRepo = new InMemoryDiemRepository(QLSinhVienDuLieuMau.DiemMau());
    private readonly ISinhVienRepository _svRepo = new InMemorySinhVienRepository(QLSinhVienDuLieuMau.SinhVienMau());
    private readonly IMonHocRepository _mhRepo = new InMemoryMonHocRepository(QLSinhVienDuLieuMau.MonHocMau());

    public frmDanhSachDiem()
    {
        InitializeComponent();
        LoadMonHoc_ComboBox();
    }

    private void LoadMonHoc_ComboBox()
    {
        cboMaMh.Items.Clear();
        cboMaMh.Items.Add(""); // dong trong = tat ca mon hoc
        foreach (var mh in _mhRepo.LayTatCa())
            cboMaMh.Items.Add(mh.MaMonHoc);

        cboMaMh.SelectedIndex = 0;
    }

    private void btnLoc_Click(object sender, EventArgs e)
    {
        string? maMonHocLoc = cboMaMh.SelectedItem as string;

        var danhSach = DiemChiTietLogic.LayDanhSach(_diemRepo.LayTatCa(), _svRepo.LayTatCa(), _mhRepo.LayTatCa(), maMonHocLoc);

        lvDanhSach.Items.Clear();
        foreach (var dong in danhSach)
        {
            var item = new ListViewItem(dong.TenSV);
            item.SubItems.Add(dong.NgaySinh?.ToString("dd/MM/yyyy") ?? "");
            item.SubItems.Add(dong.TenMonHoc);
            item.SubItems.Add(dong.DiemSo.ToString("0.0"));
            lvDanhSach.Items.Add(item);
        }

        txtTongDiem.Text = DiemChiTietLogic.TinhTongDiem(danhSach).ToString("0.0");
    }
}
