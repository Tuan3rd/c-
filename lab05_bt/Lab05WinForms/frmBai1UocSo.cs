using WinForm05Logic;

namespace Lab05WinForms;

// Bai 1 (BT tai lop): nhap so vao ComboBox, liet ke va thong ke uoc so.
public partial class frmBai1UocSo : Form
{
    public frmBai1UocSo()
    {
        InitializeComponent();
    }

    private void btnCapNhat_Click(object sender, EventArgs e)
    {
        if (!Bai1UocSoLogic.LaSoHopLe(txtNhapSo.Text, out int so))
        {
            errorProvider1.SetError(txtNhapSo, "Vui lòng nhập một số nguyên dương");
            return;
        }

        errorProvider1.SetError(txtNhapSo, string.Empty);

        bool daTonTai = cboSo.Items.Cast<object>().Any(item => item.ToString() == so.ToString());
        if (daTonTai)
        {
            MessageBox.Show(this, $"Số {so} đã có trong danh sách.", "Trùng dữ liệu",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            cboSo.Items.Add(so);
        }

        txtNhapSo.Clear();
        txtNhapSo.Focus();
    }

    private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboSo.SelectedItem is not int so)
            return;

        var uocSo = Bai1UocSoLogic.DanhSachUocSo(so);
        lstUocSo.Items.Clear();
        foreach (int u in uocSo)
            lstUocSo.Items.Add(u);
    }

    private List<int> LayDanhSachUocSoTuListBox() => lstUocSo.Items.Cast<int>().ToList();

    private void btnTongUocSo_Click(object sender, EventArgs e)
    {
        var uocSo = LayDanhSachUocSoTuListBox();
        MessageBox.Show(this, $"Tổng các ước số: {Bai1UocSoLogic.TongUocSo(uocSo)}", "Kết quả",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSoLuongChan_Click(object sender, EventArgs e)
    {
        var uocSo = LayDanhSachUocSoTuListBox();
        MessageBox.Show(this, $"Số lượng các ước số chẵn: {Bai1UocSoLogic.SoLuongUocSoChan(uocSo)}", "Kết quả",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSoLuongNguyenTo_Click(object sender, EventArgs e)
    {
        var uocSo = LayDanhSachUocSoTuListBox();
        MessageBox.Show(this, $"Số lượng các ước số nguyên tố: {Bai1UocSoLogic.SoLuongUocSoNguyenTo(uocSo)}", "Kết quả",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai1UocSo_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
