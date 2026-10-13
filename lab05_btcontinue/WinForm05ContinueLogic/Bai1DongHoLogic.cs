namespace WinForm05ContinueLogic;

// Bai 1 (mau): Timer hien thi gio he thong.
// Tach rieng ham dinh dang de co the unit test khong phu thuoc DateTime.Now (thoi
// diem "bay gio" that su khong the kiem tra bang unit test).
public static class Bai1DongHoLogic
{
    public static string DinhDangGio(DateTime thoiDiem) => thoiDiem.ToString();
}
