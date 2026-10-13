using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Form con cua Bai 1 (nang cao): nhap hoc vien moi, cap nhat truc tiep len form chinh
// qua callback (khong dong form sau moi lan Cap Nhat - chi dong khi bam Tro Ve).
public partial class frmNhapHocVienMoi : Form
{
    private readonly Action<string, LopHocVien> _themHocVien;

    public frmNhapHocVienMoi(Action<string, LopHocVien> themHocVien)
    {
        InitializeComponent();
        _themHocVien = themHocVien;
    }

    private void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (!NangCaoBai1HocVienLogic.TenHopLe(txtHoVaTen.Text))
        {
            MessageBox.Show(this, "Vui lòng nhập họ tên.", "Thiếu thông tin",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoVaTen.Focus();
            return;
        }

        var lop = cboLop.SelectedIndex == 0 ? LopHocVien.LopA : LopHocVien.LopB;
        _themHocVien(txtHoVaTen.Text, lop);

        txtHoVaTen.Clear();
        txtHoVaTen.Focus();
    }

    private void btnTroVe_Click(object sender, EventArgs e)
    {
        Close();
    }
}
