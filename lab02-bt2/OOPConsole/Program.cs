using System;
using System.Linq;
using OOPLib;

namespace OOPConsole;

// ============================================================
// Menu demo cho toan bo Bai 1.1 -> Bai 3.6. Moi muc goi thang vao
// cac lop trong OOPLib, chuong trinh nay chi lo phan nhap/xuat.
// ============================================================
class Program
{
    static void Main(string[] args)
    {
        bool thoat = false;
        while (!thoat)
        {
            Console.WriteLine("\n===== MENU BAI TAP OOP (Bai 1 -> Bai 3) =====");
            Console.WriteLine("1.1  Tinh tuoi sinh vien");
            Console.WriteLine("1.2  Lop Point (toan tu, khoang cach, trung diem)");
            Console.WriteLine("1.3  Lop Person");
            Console.WriteLine("1.4  Lop Phan So");
            Console.WriteLine("1.5  Lop Don Thuc");
            Console.WriteLine("2.1  ArrayPoint (ArrayList + indexer)");
            Console.WriteLine("2.2  PersonList");
            Console.WriteLine("2.3  Day So (mang 1 chieu, tim so chan)");
            Console.WriteLine("2.4  Mang 2 chieu (tim so nguyen to)");
            Console.WriteLine("2.5  Da thuc (tinh gia tri theo x)");
            Console.WriteLine("2.6  Day phan so (tinh tong)");
            Console.WriteLine("2.7  Phong ban (tong luong nhan vien)");
            Console.WriteLine("3.1  Array.Sort() voi PhanSo (IComparable)");
            Console.WriteLine("3.2  Sap xep tong quat bang interface");
            Console.WriteLine("3.3  Sap xep tong quat bang delegate");
            Console.WriteLine("3.4  ConsoleMenu + PTBac2Console (event/ke thua)");
            Console.WriteLine("3.5  Luong nhan vien kinh doanh / san xuat (da hinh)");
            Console.WriteLine("3.6  Diem thi sinh Chuyen / Sieu cup (da hinh)");
            Console.WriteLine("0    Thoat chuong trinh");
            Console.Write("Chon bai: ");
            string chon = Console.ReadLine();

            // ReadLine() tra ve null khi gap EOF (vd input duoc pipe vao da het) -
            // neu khong thoat o day, vong lap se chay mai mai voi chon = null
            if (chon is null) break;

            switch (chon)
            {
                case "1.1": Bai1_1(); break;
                case "1.2": Bai1_2(); break;
                case "1.3": Bai1_3(); break;
                case "1.4": Bai1_4(); break;
                case "1.5": Bai1_5(); break;
                case "2.1": Bai2_1(); break;
                case "2.2": Bai2_2(); break;
                case "2.3": Bai2_3(); break;
                case "2.4": Bai2_4(); break;
                case "2.5": Bai2_5(); break;
                case "2.6": Bai2_6(); break;
                case "2.7": Bai2_7(); break;
                case "3.1": Bai3_1(); break;
                case "3.2": Bai3_2(); break;
                case "3.3": Bai3_3(); break;
                case "3.4": Bai3_4(); break;
                case "3.5": Bai3_5(); break;
                case "3.6": Bai3_6(); break;
                case "0": thoat = true; break;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }
        }
    }

    static void Bai1_1()
    {
        Console.Write("Nhap ho ten: ");
        string hoTen = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        int namSinh = int.Parse(Console.ReadLine());

        SinhVien sv = new SinhVien(hoTen, namSinh);
        Console.Write("Nhap nam hien tai: ");
        int namHienTai = int.Parse(Console.ReadLine());

        Console.WriteLine($"{sv.HoTen} nam nay {sv.TinhTuoi(namHienTai)} tuoi.");
    }

    static void Bai1_2()
    {
        Point a = new Point();
        Console.WriteLine("Nhap toa do diem A:");
        a.Input();
        Point b = new Point();
        Console.WriteLine("Nhap toa do diem B:");
        b.Input();

        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);
        Console.WriteLine("A + B = " + (a + b));
        Console.WriteLine("A - B = " + (a - b));
        Console.WriteLine("-A = " + (-a));
        Console.WriteLine($"Khoang cach (thanh vien) = {a.KhoangCachDen(b)}");
        Console.WriteLine($"Khoang cach (tinh)      = {Point.KhoangCach(a, b)}");
        Console.WriteLine($"Trung diem (thanh vien) = {a.TrungDiemVoi(b)}");
        Console.WriteLine($"Trung diem (tinh)       = {Point.TrungDiem(a, b)}");
    }

    static void Bai1_3()
    {
        Person p = new Person();
        p.Input();
        p.Output();
        Console.WriteLine(p.IsLiving() ? "Nguoi nay con song." : "Nguoi nay da mat.");

        Person p2 = new Person(p); // copy constructor
        Console.WriteLine("Ban sao (copy constructor): " + p2.Name);
    }

    static void Bai1_4()
    {
        Console.Write("Nhap tu so phan so A: ");
        int tuA = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so phan so A: ");
        int mauA = int.Parse(Console.ReadLine());
        Console.Write("Nhap tu so phan so B: ");
        int tuB = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so phan so B: ");
        int mauB = int.Parse(Console.ReadLine());

        PhanSo a = new PhanSo(tuA, mauA);
        PhanSo b = new PhanSo(tuB, mauB);

        Console.WriteLine($"A = {a}, B = {b}");
        Console.WriteLine($"A + B = {a + b}");
        Console.WriteLine($"A - B = {a - b}");
        Console.WriteLine($"A * B = {a * b}");
        Console.WriteLine($"A / B = {a / b}");
        Console.WriteLine($"A > B: {a > b}, A < B: {a < b}, A == B: {a == b}");
    }

    static void Bai1_5()
    {
        Console.Write("Nhap he so a: ");
        double heSo = double.Parse(Console.ReadLine());
        Console.Write("Nhap so mu n: ");
        int soMu = int.Parse(Console.ReadLine());

        DonThuc p = new DonThuc(heSo, soMu);
        Console.Write("Nhap x de tinh gia tri: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine($"P(x) = {p}");
        Console.WriteLine($"P({x}) = {p.TinhGiaTri(x)}");
        Console.WriteLine($"Dao ham Q(x) = {p.DaoHam()}");
    }

    static void Bai2_1()
    {
        ArrayPoint arr = new ArrayPoint();
        Console.Write("Nhap so luong diem: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Point p = new Point();
            Console.WriteLine($"Diem thu {i + 1}:");
            p.Input();
            arr.Add(p);
        }

        for (int i = 0; i < arr.SoLuong; i++)
            Console.WriteLine($"arr[{i}] = {arr[i]}");
    }

    static void Bai2_2()
    {
        Console.Write("Nhap so nguoi: ");
        int n = int.Parse(Console.ReadLine());

        PersonList ds = new PersonList();
        ds.Input(n);
        Console.WriteLine("-- Danh sach --");
        ds.Output();

        PersonList conSong = ds.LivingPeople();
        Console.WriteLine("-- Nguoi con song --");
        conSong.Output();
    }

    static void Bai2_3()
    {
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        DaySo day = new DaySo(n);
        day.Input();
        Console.Write("Day vua nhap: ");
        day.Output();

        int[] soChan = day.TimSoChan();
        Console.WriteLine("Cac so chan: " + string.Join(" ", soChan));
    }

    static void Bai2_4()
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());

        Mang2Chieu mang = new Mang2Chieu(n, m);
        mang.Input();
        Console.WriteLine("Mang vua nhap:");
        mang.Output();

        int[] soNguyenTo = mang.TimSoNguyenTo();
        Console.WriteLine("Cac so nguyen to: " + string.Join(" ", soNguyenTo));
    }

    static void Bai2_5()
    {
        Console.Write("Nhap bac da thuc: ");
        int bac = int.Parse(Console.ReadLine());
        DaThuc p = new DaThuc(bac);
        p.Input();

        Console.Write("Nhap x de tinh gia tri da thuc: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine($"P(x) = {p}");
        Console.WriteLine($"P({x}) = {p.TinhGiaTri(x)}");
    }

    static void Bai2_6()
    {
        Console.Write("Nhap so luong phan so: ");
        int n = int.Parse(Console.ReadLine());
        DayPhanSo day = new DayPhanSo(n);
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap tu so phan so {i + 1}: ");
            int tu = int.Parse(Console.ReadLine());
            Console.Write($"Nhap mau so phan so {i + 1}: ");
            int mau = int.Parse(Console.ReadLine());
            day[i] = new PhanSo(tu, mau);
        }

        Console.WriteLine("Tong cac phan so = " + day.TinhTong());
    }

    static void Bai2_7()
    {
        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());
        PhongBan pb = new PhongBan();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap ho ten nhan vien {i + 1}: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            double luong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            int vang = int.Parse(Console.ReadLine());
            pb.Add(new NhanVienDonGian(hoTen, luong, vang));
        }

        Console.WriteLine($"Tong luong phong ban = {pb.TongLuong():N0} VND");
    }

    static void Bai3_1()
    {
        PhanSo[] mang =
        {
            new PhanSo(3, 4),
            new PhanSo(1, 2),
            new PhanSo(-1, 3),
            new PhanSo(5, 6),
        };

        Console.WriteLine("Truoc khi sap xep: " + string.Join(", ", mang.Select(p => p.ToString())));
        Array.Sort(mang); // dung Array.Sort() tinh, hoat dong vi PhanSo implement IComparable<PhanSo>
        Console.WriteLine("Sau khi Array.Sort(): " + string.Join(", ", mang.Select(p => p.ToString())));
    }

    static void Bai3_2()
    {
        PhanSo[] mang =
        {
            new PhanSo(3, 4),
            new PhanSo(1, 2),
            new PhanSo(-1, 3),
            new PhanSo(5, 6),
        };

        Console.WriteLine("Truoc khi sap xep: " + string.Join(", ", mang.Select(p => p.ToString())));
        SapXepTongQuat.SapXep(mang); // sap xep bang interface ISoSanhDuoc<T> tu viet
        Console.WriteLine("Sau khi SapXepTongQuat: " + string.Join(", ", mang.Select(p => p.ToString())));
    }

    static void Bai3_3()
    {
        int[] mang = { 5, 2, 9, 1, 7 };
        Console.WriteLine("Truoc khi sap xep: " + string.Join(", ", mang));

        // Delegate cho phep sap xep GIAM DAN chi bang cach doi chieu so sanh,
        // khong can PhanSo hay int phai implement interface nao ca
        SapXepBangDelegate.SapXep(mang, (a, b) => b.CompareTo(a));
        Console.WriteLine("Sau khi sap xep giam dan bang delegate: " + string.Join(", ", mang));
    }

    static void Bai3_4()
    {
        var app = new PTBac2Console();
        app.Run();
    }

    static void Bai3_5()
    {
        NhanVienCongTy[] danhSach =
        {
            new NhanVienKinhDoanh("KD01", "Nguyen Van A", 8_000_000, 5),
            new NhanVienSanXuat("SX01", "Tran Thi B", 3500),
        };

        // Da hinh: goi TinhLuong() tren bien kieu NhanVienCongTy (lop cha),
        // nhung C# tu dong chay dung phien ban override cua tung lop con
        foreach (var nv in danhSach)
            Console.WriteLine($"{nv.HoTen} ({nv.GetType().Name}): {nv.TinhLuong():N0} VND");
    }

    static void Bai3_6()
    {
        ThiSinh[] danhSach =
        {
            new ThiSinhChuyen("TS001", "Le Van C", 8, 9, 7, 9),
            new ThiSinhSieuCup("TS002", "Pham Thi D", 8, 8, 8, 9),
        };

        foreach (var ts in danhSach)
            Console.WriteLine($"{ts.HoTen} ({ts.GetType().Name}): tong diem = {ts.TinhTongDiem()}");
    }
}
