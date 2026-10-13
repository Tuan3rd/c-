using QLSinhVienLogic;

namespace Lab06ContinueWinForms;

// Bai 1 (tai lop, phan 2): hien thi danh sach Lop (kem ten Khoa) len ListView.
public partial class frmDanhSachLop : Form
{
    private readonly IKhoaRepository _khoaRepo = new InMemoryKhoaRepository(QLSinhVienDuLieuMau.KhoaMau());
    private readonly ILopRepository _lopRepo = new InMemoryLopRepository(QLSinhVienDuLieuMau.LopMau());

    public frmDanhSachLop()
    {
        InitializeComponent();
    }

    private void btnHienThi_Click(object sender, EventArgs e)
    {
        lvDanhSach.Items.Clear();

        var dsKhoa = _khoaRepo.LayTatCa();
        foreach (var lop in _lopRepo.LayTatCa())
        {
            string tenKhoa = dsKhoa.FirstOrDefault(k => k.MaKhoa == lop.MaKhoa)?.TenKhoa ?? "";

            var item = new ListViewItem(lop.MaLop);
            item.SubItems.Add(lop.TenLop);
            item.SubItems.Add(lop.MaKhoa);
            item.SubItems.Add(tenKhoa);
            lvDanhSach.Items.Add(item);
        }
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }
}
