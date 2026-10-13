using WinForm05Logic;

namespace Lab05WinForms;

// Bai 1 (nang cao): xu ly chuoi ten ngau nhien tren ListBox.
public partial class frmNangCaoChuoi : Form
{
    private readonly Random _ngauNhien = new();

    public frmNangCaoChuoi()
    {
        InitializeComponent();
    }

    private void btnNgauNhien_Click(object sender, EventArgs e)
    {
        lstTen.Items.Clear();
        var dsTen = Bai1ChuoiLogic.TaoDanhSachTenNgauNhien(50, _ngauNhien);
        lstTen.Items.AddRange(dsTen.ToArray());
    }

    private void btnXoaDangChon_Click(object sender, EventArgs e)
    {
        // Xoa tu cuoi ve dau de khong lam lech chi so cac phan tu con lai.
        for (int i = lstTen.SelectedIndices.Count - 1; i >= 0; i--)
            lstTen.Items.RemoveAt(lstTen.SelectedIndices[i]);
    }

    private void btnXoaTenSon_Click(object sender, EventArgs e)
    {
        for (int i = lstTen.Items.Count - 1; i >= 0; i--)
        {
            if (Bai1ChuoiLogic.CoTen((string)lstTen.Items[i], "Sơn"))
                lstTen.Items.RemoveAt(i);
        }
    }

    private void btnXoaHoLe_Click(object sender, EventArgs e)
    {
        for (int i = lstTen.Items.Count - 1; i >= 0; i--)
        {
            if (Bai1ChuoiLogic.CoHo((string)lstTen.Items[i], "Lê"))
                lstTen.Items.RemoveAt(i);
        }
    }

    private void btnChuyenHoa_Click(object sender, EventArgs e) =>
        BienDoiCacPhanTuDangChon(Bai1ChuoiLogic.ChuyenThanhChuHoa);

    private void btnChuyenThuong_Click(object sender, EventArgs e) =>
        BienDoiCacPhanTuDangChon(Bai1ChuoiLogic.ChuyenThanhChuThuong);

    private void btnVietHoaDau_Click(object sender, EventArgs e) =>
        BienDoiCacPhanTuDangChon(Bai1ChuoiLogic.VietHoaDauMoiTu);

    private void BienDoiCacPhanTuDangChon(Func<string, string> bienDoi)
    {
        foreach (int index in lstTen.SelectedIndices)
            lstTen.Items[index] = bienDoi((string)lstTen.Items[index]);
    }

    private void btnXoaTatCa_Click(object sender, EventArgs e)
    {
        lstTen.Items.Clear();
    }

    // Double click vao ten dang chon se mo InputBox cho phep doi ten moi vao vi tri do.
    private void lstTen_DoubleClick(object sender, EventArgs e)
    {
        if (lstTen.SelectedIndex < 0)
            return;

        int index = lstTen.SelectedIndex;
        string tenHienTai = (string)lstTen.Items[index];

        string? tenMoi = frmInputBox.Hien(this, "Đổi tên", "Nhập tên mới:", tenHienTai);
        if (tenMoi is not null)
            lstTen.Items[index] = tenMoi;
    }

    private void frmNangCaoChuoi_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
