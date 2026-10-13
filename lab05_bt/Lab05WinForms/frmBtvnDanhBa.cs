using WinForm05Logic;

namespace Lab05WinForms;

// Bai 3 (BT ve nha): danh ba, TreeView goc la 26 chu cai A-Z.
public partial class frmBtvnDanhBa : Form
{
    public frmBtvnDanhBa()
    {
        InitializeComponent();
    }

    private void frmBtvnDanhBa_Load(object sender, EventArgs e)
    {
        foreach (char chuCai in Bai3DanhBaLogic.DanhSachChuCaiAZ())
            trv_DanhBa.Nodes.Add(chuCai.ToString());

        txtFirstName.Focus();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string firstName = txtFirstName.Text.Trim();
        string lastName = txtLastName.Text.Trim();

        if (!Bai3DanhBaLogic.ThongTinHopLe(firstName, lastName))
        {
            MessageBox.Show(this, "Vui lòng nhập đầy đủ First Name và Last Name.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        char chuCaiDau = Bai3DanhBaLogic.XacDinhChuCaiDau(firstName);
        var nodeChuCai = trv_DanhBa.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == chuCaiDau.ToString());

        if (nodeChuCai is null)
        {
            MessageBox.Show(this, "Tên phải bắt đầu bằng chữ cái A-Z.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        nodeChuCai.Nodes.Add(Bai3DanhBaLogic.TaoNoiDungNode(firstName, lastName));
        nodeChuCai.Expand();

        txtFirstName.Clear();
        txtLastName.Clear();
        txtFirstName.Focus();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBtvnDanhBa_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
