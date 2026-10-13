namespace WinFormContinueLogic;

// Bai 1 (mau): class TinhToan theo dung huong dan trong tai lieu thuc hanh -
// giu nguyen ten lop/phuong thuc nhu de bai yeu cau, chi doi kieu float -> giu float
// vi de bai dung float. Chia() khong tu nem loi khi b = 0 (giong code mau trong de,
// phep chia float cho 0 cho ra float.PositiveInfinity/NaN) - noi nao goi Chia() phai
// tu kiem tra b != 0 truoc, dung nhu vi du MessageBox trong de "Phep chia bi loi!".
public class TinhToan
{
    private float _a, _b;

    public float A
    {
        get => _a;
        set => _a = value;
    }

    public float B
    {
        get => _b;
        set => _b = value;
    }

    public TinhToan()
    {
        _a = _b = 0;
    }

    public TinhToan(float a, float b)
    {
        _a = a;
        _b = b;
    }

    public float Cong() => _a + _b;

    public float Tru() => _a - _b;

    public float Nhan() => _a * _b;

    public float Chia() => _a / _b;
}
