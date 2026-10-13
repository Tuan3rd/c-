using WinFormLogic;

namespace Lab04WinForms;

// Bai 1 (BT ve nha): May tinh bo tui don gian (+, -, *, /, xoa).
// Toan bo logic tinh toan nam o WinFormLogic.MayTinhBoTuiLogic (co unit test rieng);
// Form chi tao luoi phim bam va cap nhat man hinh hien thi.
public partial class frmBtvnMayTinh : Form
{
    private static readonly string[,] NhanPhim =
    {
        { "1", "2", "3", "4" },
        { "5", "6", "7", "8" },
        { "9", "0", "=", "C" },
        { "+", "-", "*", "/" }
    };

    private readonly MayTinhBoTuiLogic _mayTinh = new();

    public frmBtvnMayTinh()
    {
        InitializeComponent();
        TaoLuoiPhim();
    }

    private void TaoLuoiPhim()
    {
        const int rong = 65, cao = 45, khoangCachX = 80, khoangCachY = 55;

        for (int hang = 0; hang < 4; hang++)
        {
            for (int cot = 0; cot < 4; cot++)
            {
                string nhan = NhanPhim[hang, cot];
                var nut = new Button
                {
                    Text = nhan,
                    Tag = nhan,
                    Location = new Point(cot * khoangCachX, hang * khoangCachY),
                    Size = new Size(rong, cao),
                    Font = new Font("Tahoma", 11F, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat
                };
                nut.Click += btnPhim_Click;

                pnlPhim.Controls.Add(nut);
            }
        }
    }

    private void btnPhim_Click(object? sender, EventArgs e)
    {
        string nhan = (string)((Button)sender!).Tag!;

        try
        {
            if (char.IsDigit(nhan[0]))
            {
                _mayTinh.NhapChuSo(nhan[0]);
            }
            else if (nhan == "=")
            {
                _mayTinh.TinhKetQua();
            }
            else if (nhan == "C")
            {
                _mayTinh.Xoa();
            }
            else
            {
                _mayTinh.ChonPhepToan(nhan[0]);
            }

            txtManHinh.Text = _mayTinh.ManHinh;
        }
        catch (DivideByZeroException ex)
        {
            MessageBox.Show(this, ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _mayTinh.Xoa();
            txtManHinh.Text = _mayTinh.ManHinh;
        }
    }

    private void frmBtvnMayTinh_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
