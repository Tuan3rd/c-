namespace WinForm05Logic;

// Bai 2 (BT ve nha): them cac so tu nhien N vao ListBox (chon nhieu phan tu) va xu ly.
public static class Bai2ListBoxSoLogic
{
    public static bool LaSoTuNhienHopLe(string? text, out int giaTri) =>
        int.TryParse(text, out giaTri) && giaTri >= 0;

    public static int TinhTong(IEnumerable<int> ds) => ds.Sum();

    public static List<int> TangMoiPhanTu(IEnumerable<int> ds, int luongTang) =>
        ds.Select(x => x + luongTang).ToList();

    public static List<int> BinhPhuongMoiPhanTu(IEnumerable<int> ds) => ds.Select(x => x * x).ToList();

    public static List<int> LocSoChan(IEnumerable<int> ds) => ds.Where(x => x % 2 == 0).ToList();

    public static List<int> LocSoLe(IEnumerable<int> ds) => ds.Where(x => x % 2 != 0).ToList();
}
