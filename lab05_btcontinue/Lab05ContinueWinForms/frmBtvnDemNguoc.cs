using WinForm05ContinueLogic;

namespace Lab05ContinueWinForms;

// Bai 1 (BT ve nha): dem nguoc thoi gian, bat dau tu 30:00.
public partial class frmBtvnDemNguoc : Form
{
    private TimeSpan _thoiGianConLai = Btvn1DemNguocLogic.ThoiGianBanDau;

    public frmBtvnDemNguoc()
    {
        InitializeComponent();
        lblThoiGian.Text = Btvn1DemNguocLogic.DinhDang(_thoiGianConLai);
    }

    private void btnBatDau_Click(object sender, EventArgs e)
    {
        if (timer1.Enabled)
        {
            timer1.Stop();
            btnBatDau.Text = "Bắt đầu";
        }
        else
        {
            if (Btvn1DemNguocLogic.DaKetThuc(_thoiGianConLai))
                _thoiGianConLai = Btvn1DemNguocLogic.ThoiGianBanDau;

            timer1.Start();
            btnBatDau.Text = "Dừng";
        }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        _thoiGianConLai = Btvn1DemNguocLogic.GiamMotGiay(_thoiGianConLai);
        lblThoiGian.Text = Btvn1DemNguocLogic.DinhDang(_thoiGianConLai);

        if (Btvn1DemNguocLogic.DaKetThuc(_thoiGianConLai))
        {
            timer1.Stop();
            btnBatDau.Text = "Bắt đầu";
            MessageBox.Show(this, "Hết giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void frmBtvnDemNguoc_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
