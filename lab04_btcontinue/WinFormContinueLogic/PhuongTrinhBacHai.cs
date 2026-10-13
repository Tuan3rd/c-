using System.Globalization;

namespace WinFormContinueLogic;

public enum LoaiNghiemBacNhat
{
    VoSoNghiem,
    VoNghiem,
    MotNghiem
}

public enum LoaiNghiemBacHai
{
    VoNghiem,
    NghiemKep,
    HaiNghiemPhanBiet
}

// Bai 1 (BT tai lop): giai phuong trinh bac nhat (ax + b = 0) va bac hai (ax^2 + bx + c = 0).
// Form chi doc a, b, (c) tu TextBox roi tao PhuongTrinhBacHai de goi GiaiBacNhat/GiaiBacHai -
// khong co phep toan nao nam truc tiep trong code-behind.
public class PhuongTrinhBacHai
{
    public float A { get; set; }
    public float B { get; set; }
    public float C { get; set; }

    public PhuongTrinhBacHai() { }

    public PhuongTrinhBacHai(float a, float b)
    {
        A = a;
        B = b;
    }

    public PhuongTrinhBacHai(float a, float b, float c)
    {
        A = a;
        B = b;
        C = c;
    }

    // ax + b = 0
    public (LoaiNghiemBacNhat Loai, float X) GiaiBacNhat()
    {
        if (A == 0)
            return B == 0
                ? (LoaiNghiemBacNhat.VoSoNghiem, 0f)
                : (LoaiNghiemBacNhat.VoNghiem, 0f);

        return (LoaiNghiemBacNhat.MotNghiem, -B / A);
    }

    // ax^2 + bx + c = 0, yeu cau a != 0 (day la bai toan bac hai that su).
    public (LoaiNghiemBacHai Loai, float X1, float X2) GiaiBacHai()
    {
        if (A == 0)
            throw new ArgumentException("He so a phai khac 0 doi voi phuong trinh bac hai");

        float delta = B * B - 4 * A * C;

        if (delta < 0)
            return (LoaiNghiemBacHai.VoNghiem, 0f, 0f);

        if (delta == 0)
        {
            float x = -B / (2 * A);
            return (LoaiNghiemBacHai.NghiemKep, x, x);
        }

        float can = MathF.Sqrt(delta);
        float x1 = (-B + can) / (2 * A);
        float x2 = (-B - can) / (2 * A);
        return (LoaiNghiemBacHai.HaiNghiemPhanBiet, x1, x2);
    }

    public string MoTaKetQuaBacNhat()
    {
        var (loai, x) = GiaiBacNhat();
        return loai switch
        {
            LoaiNghiemBacNhat.VoSoNghiem => "Phương trình vô số nghiệm",
            LoaiNghiemBacNhat.VoNghiem => "Phương trình vô nghiệm",
            _ => $"Phương trình có nghiệm x = {x.ToString("F2", CultureInfo.InvariantCulture)}"
        };
    }

    public string MoTaKetQuaBacHai()
    {
        var (loai, x1, x2) = GiaiBacHai();
        return loai switch
        {
            LoaiNghiemBacHai.VoNghiem => "Phương trình vô nghiệm",
            LoaiNghiemBacHai.NghiemKep =>
                $"Phương trình có nghiệm kép x1 = x2 = {x1.ToString("F2", CultureInfo.InvariantCulture)}",
            _ =>
                $"Phương trình có 2 nghiệm x1 = {x1.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"x2 = {x2.ToString("F2", CultureInfo.InvariantCulture)}"
        };
    }
}
