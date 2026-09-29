using System;
using BaiTapLogic;

namespace Bai2345_NhapXuat
{
    // ============================================================
    // Chuong trinh gom Bai 2, Bai 3, Bai 4, Bai 5 cua phan
    // "Nhap xuat co ban: Console.WriteLine(), Console.ReadLine()"
    // Chay chuong trinh se hien menu de chon chay tung bai.
    // ============================================================
    class Program
    {
        static void Main(string[] args)
        {
            bool thoat = false;

            while (!thoat)
            {
                Console.WriteLine("\n===== CHON BAI TAP DE CHAY =====");
                Console.WriteLine("2. Bai 2 - Xuat va nhap chuoi");
                Console.WriteLine("3. Bai 3 - Nhap so nguyen, tinh x^y");
                Console.WriteLine("4. Bai 4 - Nhap so nguyen co kiem tra loi nhap");
                Console.WriteLine("5. Bai 5 - Menu tinh toan (x^y, can bac 2)");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Chon bai: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "2": Bai2(); break;
                    case "3": Bai3(); break;
                    case "4": Bai4(); break;
                    case "5": Bai5(); break;
                    case "0": thoat = true; break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                        break;
                }
            }
        }

        // ================== BAI 2: Xuat va nhap chuoi ==================
        // Nhap ho ten, roi xuat ra loi chao theo dung dinh dang de bai yeu cau
        static void Bai2()
        {
            Console.Write("Nhap ho ten cua ban: ");
            string hoTen = Console.ReadLine();

            Console.WriteLine(BaiTapService.ChaoBan(hoTen));
        }

        // ================== BAI 3: Nhap so nguyen ==================
        // Nhap 2 so nguyen x, y va tinh x^y
        static void Bai3()
        {
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());

            long ketQua = BaiTapService.TinhLuyThua(x, y);

            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }

        // ================== BAI 4: Lam lai Bai 3, co kiem tra loi ==================
        // Neu x hoac y nguoi dung nhap vao khong phai so nguyen thi bao loi,
        // khong duoc de chuong trinh bi crash (khac voi Bai 3 dung int.Parse truc tiep)
        static void Bai4()
        {
            Console.Write("Nhap so nguyen x: ");
            string inputX = Console.ReadLine();

            Console.Write("Nhap so nguyen y: ");
            string inputY = Console.ReadLine();

            // ThuTinhLuyThua dung int.TryParse ben trong, tra ve false + thong bao loi
            // neu inputX/inputY khong phai so nguyen hop le, thay vi de crash nhu Bai 3
            if (!BaiTapService.ThuTinhLuyThua(inputX, inputY, out long ketQua, out string? loi))
            {
                Console.WriteLine(loi);
                return;
            }

            Console.WriteLine($"Ket qua {inputX} mu {inputY} la: {ketQua}");
        }

        // ================== BAI 5: Menu tinh toan ==================
        // In menu, nguoi dung chon chuc nang: nhap x,y (so thuc) - tinh x^y - tinh can bac 2 - thoat
        static void Bai5()
        {
            double x = 0, y = 0;
            bool daNhap = false; // co du lieu x, y hay chua, de tranh tinh toan khi chua nhap
            bool thoatBai5 = false;

            while (!thoatBai5)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "1":
                        Console.Write("Nhap x: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Nhap y: ");
                        y = double.Parse(Console.ReadLine());
                        daNhap = true;
                        break;

                    case "2":
                        if (!daNhap)
                            Console.WriteLine("Ban chua nhap x, y! Vao muc 1 truoc.");
                        else
                            Console.WriteLine($"{x} ^ {y} = {BaiTapService.TinhLuyThuaThuc(x, y)}");
                        break;

                    case "3":
                        if (!daNhap)
                        {
                            Console.WriteLine("Ban chua nhap x, y! Vao muc 1 truoc.");
                        }
                        else if (!BaiTapService.ThuTinhCanBac2(x, y, out double canX, out double canY, out string? loiCanBac2))
                        {
                            Console.WriteLine(loiCanBac2);
                        }
                        else
                        {
                            Console.WriteLine($"Can bac 2 cua x = {canX}");
                            Console.WriteLine($"Can bac 2 cua y = {canY}");
                        }
                        break;

                    case "4":
                        thoatBai5 = true;
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le!");
                        break;
                }
            }
        }
    }
}
