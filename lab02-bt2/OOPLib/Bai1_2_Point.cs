using System;

namespace OOPLib;

// ============================================================
// Bai 1.2: lop Point - toa do (x, y) trong mat phang
// ============================================================
public class Point
{
    private double x;
    private double y;

    public double X
    {
        get => x;
        set => x = value;
    }

    public double Y
    {
        get => y;
        set => y = value;
    }

    // Default constructor: khoi tao x = y = 0 dung theo yeu cau de bai
    public Point()
    {
        x = 0;
        y = 0;
    }

    // Constructor co tham so, tien loi khi tao Point tu code (vd trong unit test)
    // ma khong can goi Input() doc tu ban phim
    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Nhap toa do tu ban phim (I/O that su, khong unit test duoc phan nay)
    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }

    // ---------- Toan tu ----------

    public static Point operator +(Point a, Point b) => new Point(a.x + b.x, a.y + b.y);

    public static Point operator -(Point a, Point b) => new Point(a.x - b.x, a.y - b.y);

    // Lay am (unary minus): -(x, y) = (-x, -y)
    public static Point operator -(Point a) => new Point(-a.x, -a.y);

    // ---------- (a) Khoang cach giua 2 diem: 2 cach ----------

    // Cach 1: phuong thuc thanh vien - goi tren mot doi tuong Point cu the (this),
    // so sanh khoang cach tu "diem nay" den mot diem khac truyen vao
    public double KhoangCachDen(Point b)
    {
        double dx = x - b.x;
        double dy = y - b.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    // Cach 2: phuong thuc tinh - khong gan voi doi tuong nao, nhan ca 2 diem lam tham so
    public static double KhoangCach(Point a, Point b)
    {
        double dx = a.x - b.x;
        double dy = a.y - b.y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    // ---------- (b) Trung diem cua 2 diem: 2 cach ----------

    public Point TrungDiemVoi(Point b)
    {
        return new Point((x + b.x) / 2, (y + b.y) / 2);
    }

    public static Point TrungDiem(Point a, Point b)
    {
        return new Point((a.x + b.x) / 2, (a.y + b.y) / 2);
    }
}
