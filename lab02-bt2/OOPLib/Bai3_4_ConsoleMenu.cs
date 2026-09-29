using System;
using System.Collections.Generic;

namespace OOPLib;

// ============================================================
// Bai 3.4 (*): lop ConsoleMenu tong quat, mo rong bang event + ke thua
// ============================================================

// Delegate cho su kien Choose: bao "nguoi dung vua chon chuc nang nao"
public delegate void ChooseEventHandler(object sender, string chucNang);

public class ConsoleMenu
{
    private readonly List<(string Key, string MoTa)> danhSachChucNang = new();

    // Su kien duoc phat sinh moi khi nguoi dung chon mot chuc nang (khac "0. Thoat")
    public event ChooseEventHandler? Choose;

    public void ThemChucNang(string key, string moTa)
    {
        danhSachChucNang.Add((key, moTa));
    }

    // Vong lap chinh: in menu, doc lua chon, phat su kien Choose,
    // lap lai cho toi khi nguoi dung go "0"
    public void Run()
    {
        bool thoat = false;
        while (!thoat)
        {
            Console.WriteLine("\nMenu");
            foreach (var (key, moTa) in danhSachChucNang)
                Console.WriteLine($"{key}. {moTa}");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.Write("Thuc hien: ");
            string? luaChon = Console.ReadLine();

            // Null nghia la gap EOF (het input) - thoat luon de tranh lap vo han
            if (luaChon is null || luaChon == "0")
            {
                thoat = true;
                continue;
            }

            Console.WriteLine($"Ban thuc hien chuc nang {luaChon}");
            OnChoose(luaChon ?? "");
        }
    }

    // protected virtual de lop con (vd PTBac2Console) co the override thay vi
    // bat buoc phai dang ky qua event - day la 2 cach "mo rong" ma de bai nhac toi
    // (ke thua override, hoac dang ky event tu ben ngoai: app.Choose += ...)
    protected virtual void OnChoose(string chucNang)
    {
        Choose?.Invoke(this, chucNang);
    }
}

// Ap dung ConsoleMenu cho bai toan giai PT bac 2, bang cach KE THUA va override OnChoose
public class PTBac2Console : ConsoleMenu
{
    private const double EPS = 1e-9;

    public PTBac2Console()
    {
        ThemChucNang("1", "Giai phuong trinh bac 2");
    }

    protected override void OnChoose(string chucNang)
    {
        if (chucNang == "1")
        {
            Console.Write("Nhap he so a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap he so c: ");
            double c = double.Parse(Console.ReadLine());

            double x1 = 0, x2 = 0;
            int sn = GiaiPTBac2(a, b, c, ref x1, ref x2);
            Console.WriteLine($"So nghiem: {sn}");
            if (sn == 1) Console.WriteLine($"x1 = {x1}");
            if (sn == 2) Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else
        {
            // Chuc nang khong xac dinh van cho phep base phat su kien Choose binh thuong
            base.OnChoose(chucNang);
        }
    }

    // Dung lai chinh xac thuat toan da viet o lab02-bt1continue (co EPS)
    public static int GiaiPTBac2(double a, double b, double c, ref double x1, ref double x2)
    {
        int sn;
        if (Math.Abs(a) < EPS)
        {
            if (Math.Abs(b) < EPS) sn = Math.Abs(c) < EPS ? -1 : 0;
            else { sn = 1; x1 = -c / b; }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < -EPS) sn = 0;
            else if (Math.Abs(delta) < EPS) { sn = 1; x1 = -b / (2 * a); }
            else
            {
                sn = 2;
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                if (x1 > x2) { (x1, x2) = (x2, x1); }
            }
        }
        return sn;
    }
}
