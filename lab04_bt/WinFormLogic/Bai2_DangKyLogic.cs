using System.Text.RegularExpressions;

namespace WinFormLogic;

// Bai 2 (BT tai lop): Form dang ky tai khoan.
// Cac quy tac kiem tra du lieu duoc viet thanh ham thuan (khong dong goi) de test
// khong phu thuoc Form/Control.
public static partial class Bai2DangKyLogic
{
    // Dinh dang email don gian: ten@mien.dumien (du dung cho bai tap, khong can RFC day du).
    [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
    private static partial Regex RegexEmail();

    public static bool LaEmailHopLe(string? email) =>
        !string.IsNullOrWhiteSpace(email) && RegexEmail().IsMatch(email.Trim());

    // Cac textbox co (*) la bat buoc nhap: Ten dang nhap, Dia chi email, Mat khau.
    public static bool ThieuDuLieuBatBuoc(string? tenDangNhap, string? email, string? matKhau) =>
        string.IsNullOrWhiteSpace(tenDangNhap) ||
        string.IsNullOrWhiteSpace(email) ||
        string.IsNullOrWhiteSpace(matKhau);

    public static bool MatKhauKhopNhau(string? matKhau, string? xacNhanMatKhau) =>
        matKhau == xacNhanMatKhau;

    // Tong hop toan bo loi hop le truoc khi cho phep dang ky; tra ve danh sach rong neu hop le.
    public static List<string> KiemTraDangKy(string? tenDangNhap, string? email, string? matKhau, string? xacNhanMatKhau)
    {
        var loi = new List<string>();

        if (string.IsNullOrWhiteSpace(tenDangNhap))
            loi.Add("Ten dang nhap khong duoc de trong");

        if (string.IsNullOrWhiteSpace(email))
            loi.Add("Dia chi email khong duoc de trong");
        else if (!LaEmailHopLe(email))
            loi.Add("Dia chi email khong dung dinh dang");

        if (string.IsNullOrWhiteSpace(matKhau))
            loi.Add("Mat khau khong duoc de trong");
        else if (!MatKhauKhopNhau(matKhau, xacNhanMatKhau))
            loi.Add("Xac nhan mat khau khong khop");

        return loi;
    }

    // Noi dung hien thi len MessageBox khi dang ky thanh cong.
    public static string TaoThongBaoDangKy(string tenDangNhap, string email, string matKhau) =>
        $"Dang ky thanh cong!\nTen dang nhap: {tenDangNhap}\nEmail: {email}\nMat khau: {matKhau}";
}
