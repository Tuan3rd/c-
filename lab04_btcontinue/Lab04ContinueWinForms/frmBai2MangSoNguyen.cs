using System.Globalization;
using WinFormContinueLogic;

namespace Lab04ContinueWinForms;

// Bai 2 (BT tai lop): quan ly mang mot chieu so nguyen.
// Moi nhom chuc nang (Sap Xep, Tim Kiem, Xoa, Them, Tong, Max-Min, Thay The) goi
// thang vao MangSoNguyen - Form chi doc TextBox/RadioButton va hien ket qua.
public partial class frmBai2MangSoNguyen : Form
{
    private readonly MangSoNguyen _mang = new();

    public frmBai2MangSoNguyen()
    {
        InitializeComponent();
    }

    private void CapNhatKetQuaMang()
    {
        txtKetQuaMang.Text = string.Join(" ", _mang.DanhSach);
    }

    private void btnNhapMang_Click(object sender, EventArgs e)
    {
        string[] phanTu = txtNhapMang.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var giaTri = new List<int>();

        foreach (string s in phanTu)
        {
            if (!int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int n))
            {
                MessageBox.Show(this, $"\"{s}\" không phải là số nguyên hợp lệ.", "Dữ liệu không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            giaTri.Add(n);
        }

        _mang.Nhap(giaTri);
        CapNhatKetQuaMang();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        _mang.Xoa();
        txtNhapMang.Clear();
        txtKetQuaMang.Clear();
        txtTimGiaTri.Clear();
        txtTimViTri.Clear();
        txtSoTimDuoc.Clear();
        txtXoaGiaTri.Clear();
        txtXoaViTri.Clear();
        txtThemGiaTri.Clear();
        txtThemViTri.Clear();
        txtTongMang.Clear();
        txtTongChan.Clear();
        txtTongLe.Clear();
        txtMax.Clear();
        txtMin.Clear();
        txtThayTheChiTieu.Clear();
        txtSoThayThe.Clear();
        txtNhapMang.Focus();
    }

    private void btnThucHien_Click(object sender, EventArgs e)
    {
        if (rdoTang.Checked)
            _mang.SapXepTang();
        else
            _mang.SapXepGiam();

        CapNhatKetQuaMang();
    }

    private void btnTim_Click(object sender, EventArgs e)
    {
        try
        {
            if (rdoTimGiaTri.Checked)
            {
                int giaTri = ParseIntTu(txtTimGiaTri, "giá trị cần tìm");
                txtSoTimDuoc.Text = _mang.TimViTriTheoGiaTri(giaTri).ToString();
            }
            else
            {
                int viTri = ParseIntTu(txtTimViTri, "vị trí cần tìm");
                txtSoTimDuoc.Text = _mang.TimGiaTriTheoViTri(viTri).ToString();
            }
        }
        catch (Exception ex) when (ex is FormatException or ArgumentOutOfRangeException)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
        try
        {
            if (rdoXoaGiaTri.Checked)
                _mang.XoaTheoGiaTri(ParseIntTu(txtXoaGiaTri, "giá trị cần xóa"));
            else
                _mang.XoaTheoViTri(ParseIntTu(txtXoaViTri, "vị trí cần xóa"));

            CapNhatKetQuaMang();
        }
        catch (Exception ex) when (ex is FormatException or ArgumentOutOfRangeException or ArgumentException)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            int giaTri = ParseIntTu(txtThemGiaTri, "giá trị cần thêm");
            int viTri = ParseIntTu(txtThemViTri, "vị trí cần thêm");

            _mang.ThemTaiViTri(giaTri, viTri);
            CapNhatKetQuaMang();
        }
        catch (Exception ex) when (ex is FormatException or ArgumentOutOfRangeException)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnTong_Click(object sender, EventArgs e)
    {
        txtTongMang.Text = _mang.TinhTong().ToString();
        txtTongChan.Text = _mang.TinhTongChan().ToString();
        txtTongLe.Text = _mang.TinhTongLe().ToString();
    }

    private void btnTimMaxMin_Click(object sender, EventArgs e)
    {
        try
        {
            txtMax.Text = _mang.GiaTriLonNhat().ToString();
            txtMin.Text = _mang.GiaTriNhoNhat().ToString();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnThayThe_Click(object sender, EventArgs e)
    {
        try
        {
            int giaTriMoi = ParseIntTu(txtSoThayThe, "số thay thế");

            if (rdoThayTheGiaTri.Checked)
            {
                int giaTriCu = ParseIntTu(txtThayTheChiTieu, "giá trị cần thay thế");
                _mang.ThayTheTheoGiaTri(giaTriCu, giaTriMoi);
            }
            else
            {
                int viTri = ParseIntTu(txtThayTheChiTieu, "vị trí cần thay thế");
                _mang.ThayTheTheoViTri(viTri, giaTriMoi);
            }

            CapNhatKetQuaMang();
        }
        catch (Exception ex) when (ex is FormatException or ArgumentOutOfRangeException)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static int ParseIntTu(TextBox textBox, string tenTruong)
    {
        if (!int.TryParse(textBox.Text, out int giaTri))
            throw new FormatException($"Vui lòng nhập một số nguyên hợp lệ cho {tenTruong}.");

        return giaTri;
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmBai2MangSoNguyen_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
