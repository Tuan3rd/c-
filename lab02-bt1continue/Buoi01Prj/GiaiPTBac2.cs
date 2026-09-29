using System;
using MyLib;

namespace Buoi01Prj;

// Day la chuong trinh console "that" cua project, goi thu vien MyLib.LibBaiTap
// de giai phuong trinh bac 2 nguoi dung nhap tu ban phim.
public class GiaiPTBac2
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap he so a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap he so b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhap he so c: ");
        double c = double.Parse(Console.ReadLine());

        double x1 = 0, x2 = 0;
        int sn = LibBaiTap.GiaiPTBac2(a, b, c, ref x1, ref x2);

        Console.WriteLine($"So nghiem: {sn}");

        switch (sn)
        {
            case -1:
                Console.WriteLine("Phuong trinh co vo so nghiem.");
                break;
            case 0:
                Console.WriteLine("Phuong trinh vo nghiem.");
                break;
            case 1:
                Console.WriteLine($"x1 = {x1}");
                break;
            case 2:
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
                break;
        }
    }
}
