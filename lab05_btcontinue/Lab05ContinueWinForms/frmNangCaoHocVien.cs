using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 1 (nang cao): quan ly hoc vien giua Lop A - Lop B bang MenuStrip.
public partial class frmNangCaoHocVien : Form
{
    public frmNangCaoHocVien()
    {
        InitializeComponent();
    }

    private void mnuNhapHocVienMoi_Click(object sender, EventArgs e)
    {
        using var form = new frmNhapHocVienMoi(ThemHocVien);
        form.ShowDialog(this);
    }

    private void ThemHocVien(string hoTen, LopHocVien lop)
    {
        if (lop == LopHocVien.LopA)
            lstLopA.Items.Add(hoTen);
        else
            lstLopB.Items.Add(hoTen);
    }

    private void mnuChuyenSangLopA_Click(object sender, EventArgs e)
    {
        if (lstLopB.SelectedItems.Count == 0)
        {
            MessageBox.Show(this, "Vui lòng chọn học viên trước.", "Chưa chọn học viên",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ChuyenHocVien(lstLopB, lstLopA);
    }

    private void mnuChuyenSangLopB_Click(object sender, EventArgs e)
    {
        if (lstLopA.SelectedItems.Count == 0)
        {
            MessageBox.Show(this, "Vui lòng chọn học viên trước.", "Chưa chọn học viên",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ChuyenHocVien(lstLopA, lstLopB);
    }

    private static void ChuyenHocVien(ListBox nguon, ListBox dich)
    {
        var dsNguon = nguon.Items.Cast<string>().ToList();
        var dsDich = dich.Items.Cast<string>().ToList();
        var dsDangChon = nguon.SelectedItems.Cast<string>().ToList();

        NangCaoBai1HocVienLogic.ChuyenHocVien(dsNguon, dsDich, dsDangChon);

        nguon.Items.Clear();
        nguon.Items.AddRange(dsNguon.ToArray());
        dich.Items.Clear();
        dich.Items.AddRange(dsDich.ToArray());
    }

    private void mnuXoaHocVien_Click(object sender, EventArgs e)
    {
        if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
        {
            MessageBox.Show(this, "Vui lòng chọn học viên trước.", "Chưa chọn học viên",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        XoaHocVienDangChon(lstLopA);
        XoaHocVienDangChon(lstLopB);
    }

    private static void XoaHocVienDangChon(ListBox listBox)
    {
        var ds = listBox.Items.Cast<string>().ToList();
        var dsDangChon = listBox.SelectedItems.Cast<string>().ToList();

        NangCaoBai1HocVienLogic.XoaHocVien(ds, dsDangChon);

        listBox.Items.Clear();
        listBox.Items.AddRange(ds.ToArray());
    }

    // Dung yeu cau de bai: click "Ket thuc" hoi xac nhan roi moi quyet dinh co DUNG CHUONG
    // TRINH hay khong (khac voi dong form thong thuong - day la dung toan bo ung dung).
    private void mnuKetThuc_Click(object sender, EventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn dừng chương trình?", "Kết thúc",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.Yes)
            Application.Exit();
    }
}
