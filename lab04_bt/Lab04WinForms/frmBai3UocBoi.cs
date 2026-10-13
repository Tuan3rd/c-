using WinFormLogic;

namespace Lab04WinForms;

// Bai 3 (BT tai lop): Uoc so chung lon nhat - Boi so chung nho nhat cua 2 so a, b.
public partial class frmBai3UocBoi : Form
{
    public frmBai3UocBoi()
    {
        InitializeComponent();
    }

    private void btnThucHien_Click(object sender, EventArgs e)
    {
        bool aHopLe = Bai3UocBoiLogic.LaSoNguyenDuongHopLe(txtA.Text, out int a);
        bool bHopLe = Bai3UocBoiLogic.LaSoNguyenDuongHopLe(txtB.Text, out int b);

        errorProvider1.SetError(txtA, aHopLe ? string.Empty : "a phải là số nguyên dương");
        errorProvider1.SetError(txtB, bHopLe ? string.Empty : "b phải là số nguyên dương");

        if (!aHopLe || !bHopLe)
        {
            MessageBox.Show(this, "Vui lòng nhập a, b là số nguyên dương hợp lệ.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        txtUCLN.Text = Bai3UocBoiLogic.UCLN(a, b).ToString();
        txtBCNN.Text = Bai3UocBoiLogic.BCNN(a, b).ToString();
    }

    private void btnTiepTuc_Click(object sender, EventArgs e)
    {
        txtA.Clear();
        txtB.Clear();
        txtUCLN.Clear();
        txtBCNN.Clear();
        errorProvider1.Clear();
        txtA.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai3UocBoi_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
