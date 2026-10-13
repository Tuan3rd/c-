using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 3 (mau): nhap van ban roi luu thanh file *.txt; bo sung doc lai file *.txt va
// hien thi len RichTextBox.
public partial class frmMauBai3FileDialog : Form
{
    public frmMauBai3FileDialog()
    {
        InitializeComponent();
    }

    private void btnLuuFile_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            textBox1.Text = saveFileDialog1.FileName;
            Bai3FileLogic.GhiNoiDung(saveFileDialog1.FileName, richTextBox1.Text);
        }
    }

    private void btnMoFile_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
        {
            textBox1.Text = openFileDialog1.FileName;
            richTextBox1.Text = Bai3FileLogic.DocNoiDung(openFileDialog1.FileName);
        }
    }

    private void frmMauBai3FileDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
