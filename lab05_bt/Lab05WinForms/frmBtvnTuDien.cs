using WinForm05Logic;

namespace Lab05WinForms;

// Bai 1 (BT ve nha): tu dien Anh - Viet va Viet - Anh, dung TabControl cho 2 chieu tra cuu.
// ComboBox dung thuoc tinh AutoCompleteMode/AutoCompleteSource co san cua WinForms de
// "do tim den chu nao khop voi ky tu gan nhat" - day chinh la co che autocomplete chuan.
public partial class frmBtvnTuDien : Form
{
    private readonly TuDienLogic _tuDien = new();

    public frmBtvnTuDien()
    {
        InitializeComponent();
    }

    private void frmBtvnTuDien_Load(object sender, EventArgs e)
    {
        var dsTuAnh = _tuDien.DanhSachTuAnh.OrderBy(t => t).ToArray();
        var dsTuViet = _tuDien.DanhSachTuViet.OrderBy(t => t).ToArray();

        lstTuAnh.Items.AddRange(dsTuAnh);
        cboTuAnh.Items.AddRange(dsTuAnh);

        lstTuViet.Items.AddRange(dsTuViet);
        cboTuViet.Items.AddRange(dsTuViet);
    }

    private void HienNghiaAnhViet(string? tuAnh)
    {
        if (string.IsNullOrWhiteSpace(tuAnh))
            return;

        txtNghiaViet.Text = _tuDien.TraNghiaAnhViet(tuAnh, out string nghia)
            ? nghia
            : "Không tìm thấy nghĩa của từ này";
    }

    private void HienNghiaVietAnh(string? tuViet)
    {
        if (string.IsNullOrWhiteSpace(tuViet))
            return;

        txtNghiaAnh.Text = _tuDien.TraNghiaVietAnh(tuViet, out string nghia)
            ? nghia
            : "Không tìm thấy nghĩa của từ này";
    }

    // Nhan Enter trong ComboBox se hien nghia ngay (thay cho mot button "Tra cuu" rieng).
    private void cboTuAnh_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            HienNghiaAnhViet(cboTuAnh.Text);
            e.SuppressKeyPress = true;
        }
    }

    private void cboTuViet_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            HienNghiaVietAnh(cboTuViet.Text);
            e.SuppressKeyPress = true;
        }
    }

    private void lstTuAnh_DoubleClick(object sender, EventArgs e)
    {
        if (lstTuAnh.SelectedItem is string tuAnh)
        {
            cboTuAnh.Text = tuAnh;
            HienNghiaAnhViet(tuAnh);
        }
    }

    private void lstTuViet_DoubleClick(object sender, EventArgs e)
    {
        if (lstTuViet.SelectedItem is string tuViet)
        {
            cboTuViet.Text = tuViet;
            HienNghiaVietAnh(tuViet);
        }
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBtvnTuDien_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
