using System.Globalization;

namespace WinFormContinueLogic;

// Bai 1 (mau): ho tro kiem tra du lieu nhap cho txtA/txtB - giong 2 muc canh bao
// de bai yeu cau: Muc 1 (ErrorProvider) dung LaSoHopLe, Muc 2 (chan ky tu) dung
// LaKyTuNhapSoDuocPhep. Day la ban sao co chu dich cua Bai1TinhToanLogic trong
// lab04_bt - tach rieng vi 2 lab la 2 solution doc lap khong dung chung thu vien.
public static class Bai1RadioTinhToanLogic
{
    public static bool LaSoHopLe(string? text) =>
        float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out _);

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

    // Tra ve ten phep toan dang chon tren 4 radio button, dung de Form quyet dinh
    // goi phuong thuc nao cua TinhToan. Tra ve null neu khong radio nao duoc chon.
    public static char? PhepToanDangChon(bool congChecked, bool truChecked, bool nhanChecked, bool chiaChecked)
    {
        if (congChecked) return '+';
        if (truChecked) return '-';
        if (nhanChecked) return '*';
        if (chiaChecked) return '/';
        return null;
    }
}
