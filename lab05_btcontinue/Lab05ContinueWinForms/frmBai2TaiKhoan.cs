using System.Globalization;
using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 2 (BT tai lop): quan ly thong tin tai khoan ngan hang.
public partial class frmBai2TaiKhoan : Form
{
    private bool _dangThem;

    public frmBai2TaiKhoan()
    {
        InitializeComponent();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        _dangThem = !_dangThem;

        if (_dangThem)
        {
            btnThem.Text = "Hủy";
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            lstv1.SelectedItems.Clear();
            XoaTrangThaiNhap();
            txtSoTaiKhoan.Focus();
        }
        else
        {
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            XoaTrangThaiNhap();
        }
    }

    private void XoaTrangThaiNhap()
    {
        txtSoTaiKhoan.Clear();
        txtTenKhachHang.Clear();
        txtDiaChi.Clear();
        txtSoTien.Clear();
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
        if (!Bai2TaiKhoanLogic.ThongTinHopLe(txtSoTaiKhoan.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoTien.Text))
        {
            errorProvider1.SetError(txtSoTaiKhoan, "Vui lòng nhập đủ thông tin, số tiền phải là số không âm");
            return;
        }

        var dsSoTkHienCo = lstv1.Items.Cast<ListViewItem>().Select(i => i.SubItems[1].Text);
        if (Bai2TaiKhoanLogic.TrungSoTaiKhoan(dsSoTkHienCo, txtSoTaiKhoan.Text))
        {
            MessageBox.Show(this, "Số tài khoản đã tồn tại!", "Trùng dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        errorProvider1.SetError(txtSoTaiKhoan, string.Empty);
        Bai2TaiKhoanLogic.LaSoTienHopLe(txtSoTien.Text, out decimal soTien);

        var item = new ListViewItem((lstv1.Items.Count + 1).ToString());
        item.SubItems.Add(txtSoTaiKhoan.Text);
        item.SubItems.Add(txtTenKhachHang.Text);
        item.SubItems.Add(txtDiaChi.Text);
        item.SubItems.Add(soTien.ToString("N0", CultureInfo.InvariantCulture));
        lstv1.Items.Add(item);

        CapNhatTongTien();

        _dangThem = false;
        btnThem.Text = "Thêm";
        btnLuu.Enabled = false;
        XoaTrangThaiNhap();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        if (lstv1.SelectedItems.Count == 0)
            return;

        lstv1.SelectedItems[0].Remove();
        DanhSoLaiStt();
        CapNhatTongTien();
        XoaTrangThaiNhap();
        btnXoa.Enabled = false;
    }

    // Danh lai STT (cot dau tien) sau khi xoa, de luon lien tuc 1..n.
    private void DanhSoLaiStt()
    {
        for (int i = 0; i < lstv1.Items.Count; i++)
            lstv1.Items[i].SubItems[0].Text = (i + 1).ToString();
    }

    private void CapNhatTongTien()
    {
        var dsSoTien = lstv1.Items.Cast<ListViewItem>()
            .Select(i => decimal.Parse(i.SubItems[4].Text, NumberStyles.Number, CultureInfo.InvariantCulture));

        txtTongTien.Text = Bai2TaiKhoanLogic.TinhTongTien(dsSoTien).ToString("N0", CultureInfo.InvariantCulture);
    }

    private void lstv1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstv1.SelectedItems.Count == 0)
        {
            btnXoa.Enabled = false;
            return;
        }

        var item = lstv1.SelectedItems[0];
        txtSoTaiKhoan.Text = item.SubItems[1].Text;
        txtTenKhachHang.Text = item.SubItems[2].Text;
        txtDiaChi.Text = item.SubItems[3].Text;
        txtSoTien.Text = item.SubItems[4].Text;
        btnXoa.Enabled = true;
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai2TaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
