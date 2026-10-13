using System.Globalization;

namespace WinFormLogic;

// Bai 1 (BT tai lop): May tinh Cong - Tru - Nhan - Chia hai so a, b.
// Tach rieng phan tinh toan va kiem tra hop le ra khoi Form de co the unit test
// ma khong can dung len giao dien WinForms.
public static class Bai1TinhToanLogic
{
    // Muc 1: kiem tra chuoi nhap vao co phai la so thuc hop le khong (dung cho ErrorProvider).
    public static bool LaSoHopLe(string? text) =>
        double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out _);

    // Muc 2: kiem tra tung ky tu go vao textbox co duoc phep hay khong (dung trong KeyPress
    // de chan nguoi dung nhap ky tu khac so). Cho phep: chu so, dau tru o dau chuoi, dau cham
    // thap phan (chi 1 lan), phim dieu khien (Backspace...).
    public static bool LaKyTuNhapSoDuocPhep(char kyTu, string textHienTai, int viTriCon)
    {
        if (char.IsControl(kyTu))
            return true;

        if (char.IsDigit(kyTu))
            return true;

        if (kyTu == '-')
            return viTriCon == 0 && !textHienTai.Contains('-');

        if (kyTu == '.')
            return !textHienTai.Contains('.');

        return false;
    }

    public static double Cong(double a, double b) => a + b;

    public static double Tru(double a, double b) => a - b;

    public static double Nhan(double a, double b) => a * b;

    public static double Chia(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Khong the chia cho 0");

        return a / b;
    }
}
