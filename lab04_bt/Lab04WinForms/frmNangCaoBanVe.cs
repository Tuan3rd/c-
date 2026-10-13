using WinFormLogic;

namespace Lab04WinForms;

// Bai 1 (nang cao): Ban ve rap chieu phim.
// 15 nut ghe duoc tao dong (thay vi khai bao thu cong tung nut trong Designer) vi
// chung lap lai cung mot kieu dang va chi khac nhau o vi tri + so ghe.
public partial class frmNangCaoBanVe : Form
{
    private static readonly Color MauChuaBan = Color.White;
    private static readonly Color MauDaBan = Color.Gold;
    private static readonly Color MauDangChon = Color.DeepSkyBlue;

    // Danh sach ghe da ban san (gia lap du lieu ban dau cua rap).
    private static readonly HashSet<int> GheDaBanSan = new() { 2, 4, 7, 9, 12, 14 };

    private readonly Dictionary<int, TrangThaiGhe> _trangThaiGhe = new();
    private readonly Dictionary<int, Button> _nutGhe = new();

    public frmNangCaoBanVe()
    {
        InitializeComponent();
        TaoSoDoGhe();
    }

    private void TaoSoDoGhe()
    {
        const int rong = 65, cao = 35, khoangCachX = 78, khoangCachY = 48;

        for (int soGhe = 1; soGhe <= NangCaoBai1RapChieuPhimLogic.TongSoGhe; soGhe++)
        {
            int chiSo = soGhe - 1;
            int hang = chiSo / NangCaoBai1RapChieuPhimLogic.SoGheMoiHang;
            int cot = chiSo % NangCaoBai1RapChieuPhimLogic.SoGheMoiHang;

            var trangThaiBanDau = GheDaBanSan.Contains(soGhe) ? TrangThaiGhe.DaBan : TrangThaiGhe.ChuaBan;
            _trangThaiGhe[soGhe] = trangThaiBanDau;

            var nut = new Button
            {
                Name = $"btnGhe{soGhe}",
                Text = soGhe.ToString(),
                Tag = soGhe,
                Location = new Point(10 + cot * khoangCachX, 10 + hang * khoangCachY),
                Size = new Size(rong, cao),
                BackColor = MauCuaTrangThai(trangThaiBanDau),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Tahoma", 9F, FontStyle.Bold)
            };
            nut.Click += btnGhe_Click;

            pnlSoDoGhe.Controls.Add(nut);
            _nutGhe[soGhe] = nut;
        }
    }

    private static Color MauCuaTrangThai(TrangThaiGhe trangThai) => trangThai switch
    {
        TrangThaiGhe.ChuaBan => MauChuaBan,
        TrangThaiGhe.DangChon => MauDangChon,
        TrangThaiGhe.DaBan => MauDaBan,
        _ => MauChuaBan
    };

    private void btnGhe_Click(object? sender, EventArgs e)
    {
        var nut = (Button)sender!;
        int soGhe = (int)nut.Tag!;
        var trangThaiHienTai = _trangThaiGhe[soGhe];

        if (trangThaiHienTai == TrangThaiGhe.DaBan)
        {
            MessageBox.Show(this, $"Ghế số {soGhe} đã được bán!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var trangThaiMoi = NangCaoBai1RapChieuPhimLogic.ChuyenTrangThaiKhiClick(trangThaiHienTai);
        _trangThaiGhe[soGhe] = trangThaiMoi;
        nut.BackColor = MauCuaTrangThai(trangThaiMoi);
    }

    private void btnChon_Click(object sender, EventArgs e)
    {
        var gheDangChon = _trangThaiGhe.Where(kv => kv.Value == TrangThaiGhe.DangChon).Select(kv => kv.Key).ToList();

        if (gheDangChon.Count == 0)
        {
            MessageBox.Show(this, "Vui lòng chọn ít nhất một ghế.", "Chưa chọn ghế",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        foreach (int soGhe in gheDangChon)
        {
            _trangThaiGhe[soGhe] = TrangThaiGhe.DaBan;
            _nutGhe[soGhe].BackColor = MauCuaTrangThai(TrangThaiGhe.DaBan);
        }

        txtThanhTien.Text = NangCaoBai1RapChieuPhimLogic.TinhThanhTien(gheDangChon).ToString();
    }

    private void btnHuyBo_Click(object sender, EventArgs e)
    {
        var gheDangChon = _trangThaiGhe.Where(kv => kv.Value == TrangThaiGhe.DangChon).Select(kv => kv.Key).ToList();

        foreach (int soGhe in gheDangChon)
        {
            _trangThaiGhe[soGhe] = TrangThaiGhe.ChuaBan;
            _nutGhe[soGhe].BackColor = MauCuaTrangThai(TrangThaiGhe.ChuaBan);
        }

        txtThanhTien.Text = "0";
    }

    private void btnKetThuc_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmNangCaoBanVe_FormClosing(object sender, FormClosingEventArgs e)
    {
        var ketQua = MessageBox.Show(this, "Bạn có muốn đóng form này?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (ketQua == DialogResult.No)
            e.Cancel = true;
    }
}
