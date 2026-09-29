using System;
using BaiTapLogic;

namespace Bai1_HoTen
{
    // ============================================================
    // BAI 1: Nhap ho ten va xuat ho ten da nhap ra man hinh console
    // (Chuong trinh nay duoc dung lam file PE goc cho phan B2, B3:
    //  dung ildasm.exe de xem MSIL, roi dung ilasm.exe de dich nguoc lai)
    // ============================================================
    class Program
    {
        static void Main(string[] args)
        {
            // Buoc 1: nhap ho ten tu ban phim
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            // Buoc 2: xuat lai ho ten vua nhap ra man hinh
            // (dung ham dung chung trong BaiTapService de logic nay co the unit test duoc)
            Console.WriteLine(BaiTapService.TaoLoiChaoHoTen(hoTen));

            // Dung man hinh lai de nguoi dung kip xem ket qua truoc khi cua so console dong
            Console.WriteLine("\nNhan Enter de thoat...");
            Console.ReadLine();
        }
    }
}
