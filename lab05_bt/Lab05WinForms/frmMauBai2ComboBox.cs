using WinForm05Logic;

namespace Lab05WinForms;

// Bai 2 (mau): ComboBox dan toc - load du lieu, hien thi theo 2 cach (Label + MessageBox).
public partial class frmMauBai2ComboBox : Form
{
    public frmMauBai2ComboBox()
    {
        InitializeComponent();
    }

    private void btn_loadDL_Click(object sender, EventArgs e)
    {
        cbo_dt.Items.Clear();
        cbo_dt.Items.AddRange(Bai2DanTocLogic.DanhSachDanToc);
    }

    // Cach 1: click button Hien thi.
    private void btn_hienthi_Click(object sender, EventArgs e)
    {
        lbl_kq.Text = Bai2DanTocLogic.TaoThongBaoHienThi(cbo_dt.SelectedItem as string);
    }

    // Cach 2: xuat hien ngay tren MessageBox khi chon.
    private void cbo_dt_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_dt.SelectedItem is string danToc)
            MessageBox.Show(this, Bai2DanTocLogic.TaoThongBaoHienThi(danToc));
    }

    private void frmMauBai2ComboBox_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
