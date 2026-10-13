using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 2 (mau): ListView quan ly Ma SV - Ho ten (Them/Xoa/Sua), kiem tra trung ma truoc khi them.
public partial class frmMauBai2ListView : Form
{
    public frmMauBai2ListView()
    {
        InitializeComponent();
    }

    private void btnthem_Click(object sender, EventArgs e)
    {
        if (!Bai2ListViewLogic.ThongTinHopLe(txtmssv.Text, txthoten.Text))
        {
            errorProvider1.SetError(txtmssv, "Vui lòng nhập đủ Mã SV và Họ tên");
            return;
        }

        var dsMaHienCo = lstv1.Items.Cast<ListViewItem>().Select(i => i.Text);
        if (Bai2ListViewLogic.TrungMaSinhVien(dsMaHienCo, txtmssv.Text))
        {
            MessageBox.Show(this, "Mã sinh viên đã tồn tại!", "Trùng dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        errorProvider1.SetError(txtmssv, string.Empty);

        var item = new ListViewItem(txtmssv.Text);
        item.SubItems.Add(txthoten.Text);
        lstv1.Items.Add(item);

        txtmssv.Clear();
        txthoten.Clear();
        txtmssv.Focus();
    }

    private void btnxoa_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem item in lstv1.SelectedItems)
            item.Remove();
    }

    private void btnsua_Click(object sender, EventArgs e)
    {
        if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
        {
            var item = lstv1.FocusedItem;
            item.SubItems[0].Text = txtmssv.Text;
            item.SubItems[1].Text = txthoten.Text;
        }
    }

    private void frmMauBai2ListView_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
