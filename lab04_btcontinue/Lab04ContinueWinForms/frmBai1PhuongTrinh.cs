using WinFormContinueLogic;

namespace Lab04ContinueWinForms;

// Bai 1 (BT tai lop): giai phuong trinh bac nhat / bac hai, chon loai bang RadioButton.
public partial class frmBai1PhuongTrinh : Form
{
    public frmBai1PhuongTrinh()
    {
        InitializeComponent();
    }

    private void frmBai1PhuongTrinh_Load(object sender, EventArgs e)
    {
        txtA.Focus();
    }

    private void rdoLoaiPhuongTrinh_CheckedChanged(object sender, EventArgs e)
    {
        txtC.Enabled = rdoBacHai.Checked;
        if (!txtC.Enabled)
        {
            txtC.Clear();
            errorProvider1.SetError(txtC, string.Empty);
        }

        CapNhatTrangThaiNutGiai();
    }

    // Button Giai chi duoc bat khi da nhap du cac o can thiet (a, b, va c neu la bac hai).
    private void txtHeSo_TextChanged(object sender, EventArgs e)
    {
        CapNhatTrangThaiNutGiai();
    }

    private void CapNhatTrangThaiNutGiai()
    {
        bool duDuLieu = txtA.Text.Trim().Length > 0 && txtB.Text.Trim().Length > 0;

        if (rdoBacHai.Checked)
            duDuLieu &= txtC.Text.Trim().Length > 0;

        btnGiai.Enabled = duDuLieu;
    }

    private void btnGiai_Click(object sender, EventArgs e)
    {
        if (!TryDocHeSoHopLe(out float a, out float b, out float c))
            return;

        var pt = rdoBacHai.Checked ? new PhuongTrinhBacHai(a, b, c) : new PhuongTrinhBacHai(a, b);

        txtKetQua.Text = rdoBacHai.Checked ? pt.MoTaKetQuaBacHai() : pt.MoTaKetQuaBacNhat();

        // Dung yeu cau de bai: sau khi giai xong, Button Giai mo di cho den khi du lieu thay doi.
        btnGiai.Enabled = false;
    }

    private bool TryDocHeSoHopLe(out float a, out float b, out float c)
    {
        a = b = c = 0;
        bool hopLe = true;

        if (!float.TryParse(txtA.Text, out a))
        {
            errorProvider1.SetError(txtA, "Hệ số a không hợp lệ");
            hopLe = false;
        }
        else
        {
            errorProvider1.SetError(txtA, string.Empty);
        }

        if (!float.TryParse(txtB.Text, out b))
        {
            errorProvider1.SetError(txtB, "Hệ số b không hợp lệ");
            hopLe = false;
        }
        else
        {
            errorProvider1.SetError(txtB, string.Empty);
        }

        if (rdoBacHai.Checked)
        {
            if (!float.TryParse(txtC.Text, out c))
            {
                errorProvider1.SetError(txtC, "Hệ số c không hợp lệ");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtC, string.Empty);
            }
        }

        if (rdoBacHai.Checked && hopLe && a == 0)
        {
            errorProvider1.SetError(txtA, "Hệ số a phải khác 0 đối với phương trình bậc hai");
            hopLe = false;
        }

        if (!hopLe)
            MessageBox.Show(this, "Vui lòng kiểm tra lại dữ liệu nhập.", "Dữ liệu không hợp lệ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

        return hopLe;
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai1PhuongTrinh_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
