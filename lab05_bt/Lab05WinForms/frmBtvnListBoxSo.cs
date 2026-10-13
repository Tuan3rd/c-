using WinForm05Logic;

namespace Lab05WinForms;

// Bai 2 (BT ve nha): them cac so tu nhien vao ListBox (chon nhieu phan tu) va xu ly.
public partial class frmBtvnListBoxSo : Form
{
    public frmBtvnListBoxSo()
    {
        InitializeComponent();
    }

    private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled = true;
    }

    private List<int> LayDanhSach() => lstSo.Items.Cast<int>().ToList();

    private void GanLaiDanhSach(List<int> ds)
    {
        lstSo.Items.Clear();
        lstSo.Items.AddRange(ds.Cast<object>().ToArray());
    }

    private void btnNhap_Click(object sender, EventArgs e)
    {
        if (!Bai2ListBoxSoLogic.LaSoTuNhienHopLe(txtNhapSo.Text, out int so))
        {
            errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một số tự nhiên (>= 0)");
            return;
        }

        errorProvider1.SetError(txtNhapSo, string.Empty);
        lstSo.Items.Add(so);
        txtNhapSo.Clear();
        txtNhapSo.Focus();
    }

    private void btnTongPhanTu_Click(object sender, EventArgs e)
    {
        MessageBox.Show(this, $"Tổng các phần tử trong List: {Bai2ListBoxSoLogic.TinhTong(LayDanhSach())}",
            "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnXoaDauCuoi_Click(object sender, EventArgs e)
    {
        if (lstSo.Items.Count == 0)
            return;

        if (lstSo.Items.Count == 1)
        {
            lstSo.Items.RemoveAt(0);
            return;
        }

        lstSo.Items.RemoveAt(lstSo.Items.Count - 1); // xoa cuoi truoc de khong lech chi so dau
        lstSo.Items.RemoveAt(0);
    }

    private void btnXoaDangChon_Click(object sender, EventArgs e)
    {
        for (int i = lstSo.SelectedIndices.Count - 1; i >= 0; i--)
            lstSo.Items.RemoveAt(lstSo.SelectedIndices[i]);
    }

    private void btnTang2_Click(object sender, EventArgs e) =>
        GanLaiDanhSach(Bai2ListBoxSoLogic.TangMoiPhanTu(LayDanhSach(), 2));

    private void btnBinhPhuong_Click(object sender, EventArgs e) =>
        GanLaiDanhSach(Bai2ListBoxSoLogic.BinhPhuongMoiPhanTu(LayDanhSach()));

    private void btnChonChan_Click(object sender, EventArgs e)
    {
        var soChan = Bai2ListBoxSoLogic.LocSoChan(LayDanhSach());
        ChonCacPhanTu(soChan);
    }

    private void btnChonLe_Click(object sender, EventArgs e)
    {
        var soLe = Bai2ListBoxSoLogic.LocSoLe(LayDanhSach());
        ChonCacPhanTu(soLe);
    }

    // Chon (highlight) cac phan tu co gia tri nam trong danhSachCanChon; cac phan tu
    // khac bi bo chon. Duyet theo chi so de xu ly dung khi co gia tri trung lap.
    private void ChonCacPhanTu(List<int> danhSachCanChon)
    {
        var conLai = new List<int>(danhSachCanChon);

        for (int i = 0; i < lstSo.Items.Count; i++)
        {
            int giaTri = (int)lstSo.Items[i];
            bool chon = conLai.Remove(giaTri);
            lstSo.SetSelected(i, chon);
        }
    }

    private void btnKetThuc_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBtvnListBoxSo_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
