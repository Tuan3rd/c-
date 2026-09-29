using System;
using BaiTapLogic;

namespace Bai6_17_LopVaMang
{
    // ============================================================
    // Chuong trinh gom Bai 6 -> Bai 17:
    //  - Truyen tham so: tham tri, ref, out
    //  - Chuoi (string)
    //  - Xay dung lop co ban (SinhVien, NhanVien)
    //  - Mang 1 chieu, mang 2 chieu
    // Toan bo phan logic (tinh toan, kiem tra) nam trong BaiTapLogic
    // de co the unit test rieng, o day chi lo phan nhap/xuat.
    // ============================================================
    class Program
    {
        static readonly Random rng = new Random();

        static void Main(string[] args)
        {
            bool thoat = false;

            while (!thoat)
            {
                Console.WriteLine("\n===== CHON BAI TAP DE CHAY (6 - 17) =====");
                Console.WriteLine("6.  Tim gia tri lon nhat cua 3 so nguyen");
                Console.WriteLine("7.  Kiem tra so nguyen to");
                Console.WriteLine("8.  Hoan vi 2 so thuc (ref)");
                Console.WriteLine("9.  Tim min/max cua 3 so thuc (out)");
                Console.WriteLine("10. Kiem tra chuoi doi xung");
                Console.WriteLine("11. Dao nguoc chuoi");
                Console.WriteLine("12. Hoa/thuong & dem so tu trong chuoi");
                Console.WriteLine("13. Nhap xuat thong tin sinh vien");
                Console.WriteLine("14. Tinh luong nhan vien");
                Console.WriteLine("15. Mang so nguyen: max/min/so nguyen to");
                Console.WriteLine("16. Sap xep mang ho ten tang dan");
                Console.WriteLine("17. Mang 2 chieu ngau nhien, tach chan/le");
                Console.WriteLine("0.  Thoat chuong trinh");
                Console.Write("Chon bai: ");
                string chon = Console.ReadLine();

                switch (chon)
                {
                    case "6": Bai6(); break;
                    case "7": Bai7(); break;
                    case "8": Bai8(); break;
                    case "9": Bai9(); break;
                    case "10": Bai10(); break;
                    case "11": Bai11(); break;
                    case "12": Bai12(); break;
                    case "13": Bai13(); break;
                    case "14": Bai14(); break;
                    case "15": Bai15(); break;
                    case "16": Bai16(); break;
                    case "17": Bai17(); break;
                    case "0": thoat = true; break;
                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long chon lai!");
                        break;
                }
            }
        }

        // ================== BAI 6: return gia tri ==================
        static void Bai6()
        {
            Console.Write("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());

            int max = Bai6_7_SoNguyenService.TimGiaTriLonNhat(a, b, c);
            Console.WriteLine($"Gia tri lon nhat trong 3 so la: {max}");
        }

        // ================== BAI 7: phuong thuc bool ==================
        static void Bai7()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            bool laSoNguyenTo = Bai6_7_SoNguyenService.KiemTraSoNguyenTo(n);
            Console.WriteLine(laSoNguyenTo ? $"{n} la so nguyen to" : $"{n} khong phai la so nguyen to");
        }

        // ================== BAI 8: tham chieu ref ==================
        static void Bai8()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");
            Bai8_9_SoThucService.HoanVi(ref a, ref b);
            Console.WriteLine($"Sau khi hoan vi:   a = {a}, b = {b}");
        }

        // ================== BAI 9: tham chieu out ==================
        static void Bai9()
        {
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine());

            Bai8_9_SoThucService.TimMinMax(a, b, c, out double min, out double max);
            Console.WriteLine($"Gia tri nho nhat: {min}");
            Console.WriteLine($"Gia tri lon nhat: {max}");
        }

        // ================== BAI 10: chuoi doi xung ==================
        static void Bai10()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            bool doiXung = Bai10_11_12_ChuoiService.KiemTraDoiXung(s);
            Console.WriteLine(doiXung ? "Chuoi doi xung" : "Chuoi khong doi xung");
        }

        // ================== BAI 11: dao chuoi ==================
        static void Bai11()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            Console.WriteLine("Chuoi dao nguoc: " + Bai10_11_12_ChuoiService.DaoNguoc(s));
        }

        // ================== BAI 12: hoa/thuong, dem tu ==================
        static void Bai12()
        {
            Console.Write("Nhap chuoi gom nhieu tu: ");
            string s = Console.ReadLine();

            Console.WriteLine("Chuoi in HOA: " + Bai10_11_12_ChuoiService.ChuyenHoa(s));
            Console.WriteLine("Chuoi in thuong: " + Bai10_11_12_ChuoiService.ChuyenThuong(s));
            Console.WriteLine("So tu trong chuoi: " + Bai10_11_12_ChuoiService.DemSoTu(s));
        }

        // ================== BAI 13: sinh vien ==================
        static void Bai13()
        {
            Console.Write("Nhap ma sinh vien: ");
            string maSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            string diaChi = Console.ReadLine();
            Console.Write("Nhap sinh vien nam thu may: ");
            int namThu = int.Parse(Console.ReadLine());

            SinhVien sv = new SinhVien(maSV, hoTen, diaChi, namThu);
            Console.WriteLine(sv.XuatThongTin());
        }

        // ================== BAI 14: nhan vien ==================
        static void Bai14()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            double mucLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            int soNgayVang = int.Parse(Console.ReadLine());

            NhanVien nv = new NhanVien(hoTen, mucLuong, soNgayVang);
            Console.WriteLine($"Luong thuc nhan cua {nv.HoTen} la: {nv.TinhLuong():N0} VND");
        }

        // ================== BAI 15: mang so nguyen ==================
        static void Bai15()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Mang vua nhap: ");
            Console.WriteLine(string.Join(" ", mang));

            Console.WriteLine("Gia tri lon nhat: " + Bai15_MangSoHocService.TimMax(mang));
            Console.WriteLine("Gia tri nho nhat: " + Bai15_MangSoHocService.TimMin(mang));

            int[] soNguyenTo = Bai15_MangSoHocService.LayMangSoNguyenTo(mang);
            Console.WriteLine(soNguyenTo.Length == 0
                ? "Mang khong co so nguyen to nao"
                : "Cac so nguyen to trong mang: " + string.Join(" ", soNguyenTo));
        }

        // ================== BAI 16: sap xep ho ten ==================
        static void Bai16()
        {
            Console.Write("Nhap so nguoi: ");
            int n = int.Parse(Console.ReadLine());

            string[] hoTenMang = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
                hoTenMang[i] = Console.ReadLine();
            }

            string[] daSapXep = Bai16_MangHoTenService.SapXepTangDan(hoTenMang);

            Console.WriteLine("Danh sach sau khi sap xep tang dan:");
            foreach (string ten in daSapXep)
                Console.WriteLine("- " + ten);
        }

        // ================== BAI 17: mang 2 chieu ==================
        static void Bai17()
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mang = Bai17_Mang2DService.SinhNgauNhien(n, m, 10, 100, rng);

            Console.WriteLine("Mang duoc sinh ngau nhien:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(mang[i, j].ToString().PadLeft(5));
                Console.WriteLine();
            }

            var (chan, le) = Bai17_Mang2DService.TachChanLe(mang);
            Console.WriteLine("Cac so chan: " + string.Join(" ", chan));
            Console.WriteLine("Cac so le:   " + string.Join(" ", le));
        }
    }
}
