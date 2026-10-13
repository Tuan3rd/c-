using System.Globalization;

namespace WinFormLogic;

// Bai 1 (BT ve nha): May tinh bo tui don gian (+, -, *, /, xoa).
// Dong vai tro "dong co" tinh toan phia sau cac nut bam 0-9, +, -, *, /, =, C;
// Form chi can goi cac ham nay va cap nhat ManHinh len Label/TextBox.
public class MayTinhBoTuiLogic
{
    public string ManHinh { get; private set; } = "0";

    private double _soThuNhat;
    private char _phepToanDangCho = '\0';
    private bool _chuanBiNhapSoMoi;

    // Nguoi dung bam mot phim so (0-9).
    public void NhapChuSo(char chuSo)
    {
        if (!char.IsDigit(chuSo))
            throw new ArgumentException("Chi chap nhan ky tu so 0-9", nameof(chuSo));

        if (ManHinh == "0" || _chuanBiNhapSoMoi)
        {
            ManHinh = chuSo.ToString();
            _chuanBiNhapSoMoi = false;
        }
        else
        {
            ManHinh += chuSo;
        }
    }

    // Nguoi dung bam mot phim phep toan (+, -, *, /).
    public void ChonPhepToan(char phepToan)
    {
        _soThuNhat = double.Parse(ManHinh, CultureInfo.InvariantCulture);
        _phepToanDangCho = phepToan;
        _chuanBiNhapSoMoi = true;
    }

    // Nguoi dung bam "=".
    public void TinhKetQua()
    {
        if (_phepToanDangCho == '\0')
            return;

        double soThuHai = double.Parse(ManHinh, CultureInfo.InvariantCulture);

        double ketQua = _phepToanDangCho switch
        {
            '+' => _soThuNhat + soThuHai,
            '-' => _soThuNhat - soThuHai,
            '*' => _soThuNhat * soThuHai,
            '/' => soThuHai == 0
                ? throw new DivideByZeroException("Khong the chia cho 0")
                : _soThuNhat / soThuHai,
            _ => soThuHai
        };

        ManHinh = ketQua.ToString(CultureInfo.InvariantCulture);
        _phepToanDangCho = '\0';
        _chuanBiNhapSoMoi = true;
    }

    // Nguoi dung bam "C".
    public void Xoa()
    {
        ManHinh = "0";
        _soThuNhat = 0;
        _phepToanDangCho = '\0';
        _chuanBiNhapSoMoi = false;
    }
}
