using System;

namespace OOPLib;

// ============================================================
// Bai 1.4: lop Phan So (a/b), co rut gon tu dong va day du toan tu
// ============================================================
// PhanSo implement ca IComparable<PhanSo> (dung cho Array.Sort() o Bai 3.1)
// va ISoSanhDuoc<PhanSo> (dung cho SapXepTongQuat tu viet o Bai 3.2),
// de mot lop co the demo duoc ca 2 cach sap xep tren cung du lieu.
public class PhanSo : IComparable<PhanSo>, ISoSanhDuoc<PhanSo>
{
    private int tuSo;
    private int mauSo;

    public int TuSo { get => tuSo; }
    public int MauSo { get => mauSo; }

    // Constructor mac nhien: 0/1
    public PhanSo()
    {
        tuSo = 0;
        mauSo = 1;
    }

    // Constructor sao chep
    public PhanSo(PhanSo nguon)
    {
        tuSo = nguon.tuSo;
        mauSo = nguon.mauSo;
    }

    public PhanSo(int tu, int mau)
    {
        if (mau == 0)
            throw new ArgumentException("Mau so khong duoc bang 0.");

        tuSo = tu;
        mauSo = mau;
        RutGon();
    }

    // Rut gon phan so bang cach chia ca tu va mau cho UCLN,
    // dong thoi chuyen dau am ve tu so cho thong nhat (vd 1/-2 -> -1/2)
    private void RutGon()
    {
        if (mauSo < 0)
        {
            mauSo = -mauSo;
            tuSo = -tuSo;
        }

        int uc = UCLN(Math.Abs(tuSo), mauSo);
        if (uc > 1)
        {
            tuSo /= uc;
            mauSo /= uc;
        }
    }

    private static int UCLN(int a, int b)
    {
        if (a == 0) return b == 0 ? 1 : b;
        while (b != 0)
        {
            int tmp = b;
            b = a % b;
            a = tmp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{tuSo}/{mauSo}";
    }

    // ---------- Toan tu mot ngoi ----------

    public static PhanSo operator +(PhanSo p) => new PhanSo(p.tuSo, p.mauSo);

    public static PhanSo operator -(PhanSo p) => new PhanSo(-p.tuSo, p.mauSo);

    // ---------- Toan tu hai ngoi ----------

    public static PhanSo operator +(PhanSo a, PhanSo b)
        => new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);

    public static PhanSo operator -(PhanSo a, PhanSo b)
        => new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);

    public static PhanSo operator *(PhanSo a, PhanSo b)
        => new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);

    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        if (b.tuSo == 0)
            throw new DivideByZeroException("Khong the chia cho phan so co tu so bang 0.");

        return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
    }

    // ---------- Toan tu so sanh ----------
    // So sanh bang cach quy dong roi so sanh tu so (vi mauSo sau RutGon() luon duong)

    public static bool operator >(PhanSo a, PhanSo b) => a.tuSo * b.mauSo > b.tuSo * a.mauSo;
    public static bool operator <(PhanSo a, PhanSo b) => a.tuSo * b.mauSo < b.tuSo * a.mauSo;
    public static bool operator >=(PhanSo a, PhanSo b) => a.tuSo * b.mauSo >= b.tuSo * a.mauSo;
    public static bool operator <=(PhanSo a, PhanSo b) => a.tuSo * b.mauSo <= b.tuSo * a.mauSo;

    public static bool operator ==(PhanSo a, PhanSo b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.tuSo == b.tuSo && a.mauSo == b.mauSo;
    }

    public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);

    // Bat buoc override Equals/GetHashCode khi da overload == va !=,
    // neu khong Equals() mac dinh (so sanh tham chieu) se mau thuan voi ==
    public override bool Equals(object obj) => obj is PhanSo p && this == p;

    public override int GetHashCode() => HashCode.Combine(tuSo, mauSo);

    // Cho phep dung Array.Sort() truc tiep tren mang PhanSo (dung o Bai 3.1)
    public int CompareTo(PhanSo other)
    {
        if (other is null) return 1;
        return (tuSo * other.mauSo).CompareTo(other.tuSo * mauSo);
    }

    // Trien khai ISoSanhDuoc<PhanSo> cho Bai 3.2, don gian la goi lai CompareTo()
    public int SoSanh(PhanSo other) => CompareTo(other);
}
