using WinForm05Logic;

namespace Lab05WinForms;

// Bai 2 (BT tai lop): quan ly Lop - Sinh vien bang TreeView.
// Cau truc cay: "Danh sach lop" (goc) -> moi Lop (cap 1) -> moi Sinh vien (cap 2,
// noi dung "MaSV, HoTen") -> dung 1 node con la Dia chi (cap 3).
public partial class frmBai2QuanLySinhVien : Form
{
    private TreeNode _nodeGoc = null!;

    public frmBai2QuanLySinhVien()
    {
        InitializeComponent();
    }

    private void frmBai2QuanLySinhVien_Load(object sender, EventArgs e)
    {
        _nodeGoc = trv_DS.Nodes.Add("Danh sách lớp");

        foreach (string lop in Bai2SinhVienLogic.LopMacDinh)
        {
            _nodeGoc.Nodes.Add(lop);
            cbo_ChonLop.Items.Add(lop);
        }

        _nodeGoc.Expand();
        cbo_ChonLop.SelectedIndex = 0;
        chk_ThemLop.Checked = false;
        grp_ThongTinLop.Visible = false;
    }

    private void chk_ThemLop_CheckedChanged(object sender, EventArgs e)
    {
        grp_ThongTinLop.Visible = chk_ThemLop.Checked;
    }

    private void btn_ThemLop_Click(object sender, EventArgs e)
    {
        string tenLop = txt_TenLop.Text.Trim();

        if (string.IsNullOrWhiteSpace(tenLop))
        {
            errorProvider1.SetError(txt_TenLop, "Tên lớp không được để trống");
            return;
        }

        var dsLopHienCo = _nodeGoc.Nodes.Cast<TreeNode>().Select(n => n.Text);
        if (Bai2SinhVienLogic.TrungTenLop(dsLopHienCo, tenLop))
        {
            MessageBox.Show(this, "Tên lớp đã tồn tại!", "Trùng dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        errorProvider1.SetError(txt_TenLop, string.Empty);
        _nodeGoc.Nodes.Add(tenLop);
        cbo_ChonLop.Items.Add(tenLop);
        txt_TenLop.Clear();
        txt_TenLop.Focus();
    }

    private TreeNode? TimNodeLop(string tenLop) =>
        _nodeGoc.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Text == tenLop);

    // Kiem tra trung ma sinh vien tren toan bo danh sach lop (khong chi rieng lop dang chon),
    // vi ma sinh vien can duy nhat toan truong.
    private bool TrungMaSinhVienToanBo(string maSV)
    {
        var dsMaSvHienCo = _nodeGoc.Nodes.Cast<TreeNode>()
            .SelectMany(lop => lop.Nodes.Cast<TreeNode>())
            .Select(sv => Bai2SinhVienLogic.TachMaSvTuNoiDungNode(sv.Text));

        return Bai2SinhVienLogic.TrungMaSinhVien(dsMaSvHienCo, maSV);
    }

    private void btn_CapNhat_Click(object sender, EventArgs e)
    {
        string maSV = txt_MaSV.Text.Trim();
        string hoTen = txt_HoTen.Text.Trim();
        string diaChi = txt_DiaChi.Text.Trim();

        if (!Bai2SinhVienLogic.ThongTinSinhVienHopLe(maSV, hoTen, diaChi))
        {
            MessageBox.Show(this, "Vui lòng nhập đầy đủ Mã SV, Họ Tên và Địa Chỉ.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (TrungMaSinhVienToanBo(maSV))
        {
            MessageBox.Show(this, "Mã sinh viên đã tồn tại!", "Trùng dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cbo_ChonLop.SelectedItem is not string tenLop || TimNodeLop(tenLop) is not TreeNode nodeLop)
        {
            MessageBox.Show(this, "Vui lòng chọn lớp trước khi thêm sinh viên.", "Chưa chọn lớp",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var nodeSinhVien = nodeLop.Nodes.Add(Bai2SinhVienLogic.TaoNoiDungNodeSinhVien(maSV, hoTen));
        nodeSinhVien.Nodes.Add(diaChi);
        nodeLop.Expand();

        txt_MaSV.Clear();
        txt_HoTen.Clear();
        txt_DiaChi.Clear();
        txt_MaSV.Focus();
    }

    // Mot node duoc xem la "sinh vien" neu no co node cha va node ong (cha cua cha la goc).
    private bool LaNodeSinhVien(TreeNode? node) =>
        node is not null && node.Parent is not null && node.Parent.Parent == _nodeGoc;

    private void btn_Xoa_Click(object sender, EventArgs e)
    {
        if (!LaNodeSinhVien(trv_DS.SelectedNode))
        {
            MessageBox.Show(this, "Vui lòng chọn đúng một sinh viên trên TreeView để xóa.", "Lựa chọn không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var ketQua = MessageBox.Show(this, "Bạn có chắc muốn xóa sinh viên này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua != DialogResult.Yes)
            return;

        trv_DS.SelectedNode!.Remove();
        txt_MaSV.Clear();
        txt_HoTen.Clear();
        txt_DiaChi.Clear();
    }

    private void trv_DS_AfterSelect(object sender, TreeViewEventArgs e)
    {
        if (!LaNodeSinhVien(e.Node))
            return;

        string noiDungNode = e.Node!.Text;
        string maSV = Bai2SinhVienLogic.TachMaSvTuNoiDungNode(noiDungNode);
        string hoTen = noiDungNode.Contains(',') ? noiDungNode[(noiDungNode.IndexOf(',') + 1)..].Trim() : string.Empty;
        string diaChi = e.Node.Nodes.Count > 0 ? e.Node.Nodes[0].Text : string.Empty;

        txt_MaSV.Text = maSV;
        txt_HoTen.Text = hoTen;
        txt_DiaChi.Text = diaChi;
        cbo_ChonLop.SelectedItem = e.Node.Parent!.Text;
    }

    private void frmBai2QuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
