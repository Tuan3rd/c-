using WinForm05Logic;

namespace Lab05WinForms;

// Bai 3 (mau): TreeView phong ban - nhan vien.
public partial class frmMauBai3TreeView : Form
{
    public frmMauBai3TreeView()
    {
        InitializeComponent();
    }

    private void frmMauBai3TreeView_Load(object sender, EventArgs e)
    {
        foreach (string s in Bai3PhongBanLogic.PhongBanMacDinh)
        {
            trv_DS.Nodes.Add(s);        // them node vao treeview
            cbo_phongban.Items.Add(s);  // them item vao combobox
        }

        cbo_phongban.SelectedIndex = 0; // item dau tien duoc chon
    }

    // Kiem tra txt_Phongban co ton tai trong TreeView chua - dung Bai3PhongBanLogic.TrungTenPhongBan
    // (so sanh khong phan biet hoa/thuong qua string.Compare nhu de bai goi y).
    private bool KiemTra(string s)
    {
        var dsPhongBanHienCo = trv_DS.Nodes.Cast<TreeNode>().Select(n => n.Text);
        return !Bai3PhongBanLogic.TrungTenPhongBan(dsPhongBanHienCo, s);
    }

    private void btn_ThemPB_Click(object sender, EventArgs e)
    {
        if (KiemTra(txt_Phongban.Text))
        {
            trv_DS.Nodes.Add(txt_Phongban.Text);
            cbo_phongban.Items.Add(txt_Phongban.Text);
        }
        else
        {
            MessageBox.Show(this, "Phòng ban đã tồn tại!");
        }

        txt_Phongban.Text = "";
        txt_Phongban.Focus();
    }

    private void btn_XoaPB_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show(this, "Bạn có chắc muốn xóa?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        {
            if (trv_DS.SelectedNode != null)
            {
                cbo_phongban.Items.Remove(trv_DS.SelectedNode.Text);
                trv_DS.Nodes.Remove(trv_DS.SelectedNode);
            }
        }
    }

    private void btn_ThemNV_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txt_maso.Text) || string.IsNullOrWhiteSpace(txt_hoten.Text) ||
            cbo_phongban.SelectedItem is null)
        {
            MessageBox.Show(this, "Vui lòng nhập đầy đủ mã số, họ tên và chọn phòng ban.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Tim index cua node co noi dung la item duoc chon trong combobox phong ban.
        int index = -1;
        foreach (TreeNode node in trv_DS.Nodes)
        {
            if (node.Text == cbo_phongban.Text)
            {
                index = node.Index;
                break;
            }
        }

        if (index < 0)
            return;

        trv_DS.Nodes[index].Nodes.Add(Bai3PhongBanLogic.TaoNoiDungNodeNhanVien(txt_hoten.Text, txt_maso.Text));
        trv_DS.ExpandAll(); // mo rong treeview
    }

    private void btn_Thoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmMauBai3TreeView_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
