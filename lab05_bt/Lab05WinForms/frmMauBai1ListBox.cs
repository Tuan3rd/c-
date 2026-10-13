using WinForm05Logic;

namespace Lab05WinForms;

// Bai 1 (mau): chuyen phan tu qua lai giua 2 ListBox.
public partial class frmMauBai1ListBox : Form
{
    private static readonly string[] DuLieuMau = { "Cốc", "Ổi", "Xoài", "Me", "Bưởi", "Cam" };

    public frmMauBai1ListBox()
    {
        InitializeComponent();
    }

    private void frmMauBai1ListBox_Load(object sender, EventArgs e)
    {
        lst_Trai.Items.AddRange(DuLieuMau);
    }

    private static List<string> LayDanhSach(ListBox listBox) => listBox.Items.Cast<string>().ToList();

    private static void GanLaiDanhSach(ListBox listBox, List<string> danhSach)
    {
        listBox.Items.Clear();
        listBox.Items.AddRange(danhSach.ToArray());
    }

    private void btnQuaPhai_Click(object sender, EventArgs e)
    {
        if (lst_Trai.SelectedItem is not string phanTu)
            return;

        var trai = LayDanhSach(lst_Trai);
        var phai = LayDanhSach(lst_Phai);
        Bai1ListBoxLogic.ChuyenMotPhanTu(trai, phai, phanTu);
        GanLaiDanhSach(lst_Trai, trai);
        GanLaiDanhSach(lst_Phai, phai);
    }

    private void btnQuaPhaiAll_Click(object sender, EventArgs e)
    {
        var trai = LayDanhSach(lst_Trai);
        var phai = LayDanhSach(lst_Phai);
        Bai1ListBoxLogic.ChuyenTatCa(trai, phai);
        GanLaiDanhSach(lst_Trai, trai);
        GanLaiDanhSach(lst_Phai, phai);
    }

    private void btnQuaTrai_Click(object sender, EventArgs e)
    {
        if (lst_Phai.SelectedItem is not string phanTu)
            return;

        var phai = LayDanhSach(lst_Phai);
        var trai = LayDanhSach(lst_Trai);
        Bai1ListBoxLogic.ChuyenMotPhanTu(phai, trai, phanTu);
        GanLaiDanhSach(lst_Phai, phai);
        GanLaiDanhSach(lst_Trai, trai);
    }

    private void btnQuaTraiAll_Click(object sender, EventArgs e)
    {
        var phai = LayDanhSach(lst_Phai);
        var trai = LayDanhSach(lst_Trai);
        Bai1ListBoxLogic.ChuyenTatCa(phai, trai);
        GanLaiDanhSach(lst_Phai, phai);
        GanLaiDanhSach(lst_Trai, trai);
    }

    // "Chuyen tuy y": lst_Trai cho phep chon nhieu item (SelectionMode.MultiExtended),
    // chon item nao thi chuyen het cac item do qua listbox phai.
    private void btnChuyenTuyY_Click(object sender, EventArgs e)
    {
        var dsDangChon = lst_Trai.SelectedItems.Cast<string>().ToList();

        var trai = LayDanhSach(lst_Trai);
        var phai = LayDanhSach(lst_Phai);
        Bai1ListBoxLogic.ChuyenNhieuPhanTu(trai, phai, dsDangChon);
        GanLaiDanhSach(lst_Trai, trai);
        GanLaiDanhSach(lst_Phai, phai);
    }

    private void frmMauBai1ListBox_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
