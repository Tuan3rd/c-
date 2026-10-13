using WinFormContinueLogic;

namespace Lab04ContinueWinForms;

// Bai 2 (mau): dinh dang Font Style (Checkbox) + Color (RadioButton) cho label.
// 4 checkbox Font Style duoc lam cho loai tru lan nhau ngay trong code (giong radio)
// vi CheckBox vat ly khong tu loai tru nhu RadioButton cung nhom.
public partial class frmMauBai2Format : Form
{
    private bool _dangCapNhatCheckbox;

    public frmMauBai2Format()
    {
        InitializeComponent();
    }

    private void chkFontStyle_CheckedChanged(object sender, EventArgs e)
    {
        if (_dangCapNhatCheckbox)
            return;

        var chk = (CheckBox)sender;
        if (chk.Checked)
        {
            _dangCapNhatCheckbox = true;
            foreach (var other in new[] { chkRegular, chkBold, chkItalic, chkBoldItalic })
            {
                if (other != chk)
                    other.Checked = false;
            }
            _dangCapNhatCheckbox = false;
        }

        CapNhatFont();
    }

    private void CapNhatFont()
    {
        var kieuChu = MauBai2FormatLogic.XacDinhKieuChu(
            chkRegular.Checked, chkBold.Checked, chkItalic.Checked, chkBoldItalic.Checked);

        var style = FontStyle.Regular;
        if (MauBai2FormatLogic.LaDam(kieuChu)) style |= FontStyle.Bold;
        if (MauBai2FormatLogic.LaNghieng(kieuChu)) style |= FontStyle.Italic;

        lblNoiDung.Font = new Font(lblNoiDung.Font, style);
    }

    private void rdoColor_CheckedChanged(object sender, EventArgs e)
    {
        if (rdoAutoColor.Checked) lblNoiDung.ForeColor = SystemColors.ControlText;
        else if (rdoRed.Checked) lblNoiDung.ForeColor = Color.Red;
        else if (rdoGreen.Checked) lblNoiDung.ForeColor = Color.Green;
        else if (rdoBlue.Checked) lblNoiDung.ForeColor = Color.Blue;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn thoát khỏi Form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.Yes)
            Close();
    }
}
