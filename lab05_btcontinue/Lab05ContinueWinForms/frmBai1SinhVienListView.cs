using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 1 (BT tai lop): ListView sinh vien day du (gioi tinh, ngoai ngu, dan toc) +
// ContextMenuStrip xoa khi kich phai chuot.
public partial class frmBai1SinhVienListView : Form
{
    public frmBai1SinhVienListView()
    {
        InitializeComponent();
    }

    private void frmBai1SinhVienListView_Load(object sender, EventArgs e)
    {
        cboDanToc.Items.AddRange(Bai1SinhVienListViewLogic.DanToc);
        cboDanToc.SelectedIndex = 0;
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        if (!Bai1SinhVienListViewLogic.ThongTinHopLe(txtHoTen.Text, txtMaSV.Text))
        {
            errorProvider1.SetError(txtMaSV, "Vui lòng nhập đủ Họ tên và Mã sinh viên");
            return;
        }

        var dsMaHienCo = lstv1.Items.Cast<ListViewItem>().Select(i => i.SubItems[1].Text);
        if (Bai1SinhVienListViewLogic.TrungMaSinhVien(dsMaHienCo, txtMaSV.Text))
        {
            MessageBox.Show(this, "Mã sinh viên đã tồn tại!", "Trùng dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        errorProvider1.SetError(txtMaSV, string.Empty);

        var item = new ListViewItem(txtHoTen.Text);
        item.SubItems.Add(txtMaSV.Text);
        item.SubItems.Add(Bai1SinhVienListViewLogic.MoTaGioiTinh(rdoNam.Checked));
        item.SubItems.Add(Bai1SinhVienListViewLogic.MoTaNgoaiNgu(chkAnh.Checked, chkPhap.Checked, chkHoa.Checked));
        item.SubItems.Add((string)cboDanToc.SelectedItem!);
        lstv1.Items.Add(item);

        txtHoTen.Clear();
        txtMaSV.Clear();
        txtHoTen.Focus();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        XoaCacMucDangChon();
    }

    private void mnuXoaContext_Click(object sender, EventArgs e)
    {
        XoaCacMucDangChon();
    }

    private void XoaCacMucDangChon()
    {
        foreach (ListViewItem item in lstv1.SelectedItems)
            item.Remove();
    }

    // "Khong cho sua Ma sinh vien" - SubItems[1] (Ma SV) khong bi ghi de, chi cac truong con lai.
    private void btnSua_Click(object sender, EventArgs e)
    {
        if (lstv1.FocusedItem is null || lstv1.FocusedItem.Index < 0)
            return;

        var item = lstv1.FocusedItem;
        item.SubItems[0].Text = txtHoTen.Text;
        item.SubItems[2].Text = Bai1SinhVienListViewLogic.MoTaGioiTinh(rdoNam.Checked);
        item.SubItems[3].Text = Bai1SinhVienListViewLogic.MoTaNgoaiNgu(chkAnh.Checked, chkPhap.Checked, chkHoa.Checked);
        item.SubItems[4].Text = (string)cboDanToc.SelectedItem!;
    }

    private void frmBai1SinhVienListView_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
