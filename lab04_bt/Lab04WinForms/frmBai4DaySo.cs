using WinFormLogic;

namespace Lab04WinForms;

// Bai 4 (BT tai lop): Nhap mot day so nguyen, tinh tong - tong chan - tong le.
public partial class frmBai4DaySo : Form
{
    // Danh sach cac so nguyen da nhap, giu trang thai o Form (UI state);
    // phan tinh toan tren danh sach nay nam o Bai4DaySoLogic (co unit test rieng).
    private readonly List<int> _daySo = new();

    public frmBai4DaySo()
    {
        InitializeComponent();
    }

    private void btnNhap_Click(object sender, EventArgs e)
    {
        if (!Bai4DaySoLogic.LaSoNguyenHopLe(txtNhapSo.Text, out int so))
        {
            errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một số nguyên");
            return;
        }

        errorProvider1.SetError(txtNhapSo, string.Empty);
        _daySo.Add(so);
        txtDayVuaNhap.Text = string.Join(" ", _daySo);

        txtNhapSo.Clear();
        txtNhapSo.Focus();
    }

    private void btnTinhTong_Click(object sender, EventArgs e)
    {
        if (_daySo.Count == 0)
        {
            MessageBox.Show(this, "Vui lòng nhập ít nhất một số trước khi tính tổng.", "Chưa có dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        txtTongCacPhanTu.Text = Bai4DaySoLogic.TongCacPhanTu(_daySo).ToString();
        txtTongChan.Text = Bai4DaySoLogic.TongChan(_daySo).ToString();
        txtTongLe.Text = Bai4DaySoLogic.TongLe(_daySo).ToString();
    }

    private void btnTiepTuc_Click(object sender, EventArgs e)
    {
        _daySo.Clear();
        txtNhapSo.Clear();
        txtDayVuaNhap.Clear();
        txtTongCacPhanTu.Clear();
        txtTongChan.Clear();
        txtTongLe.Clear();
        errorProvider1.Clear();
        txtNhapSo.Focus();
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai4DaySo_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
