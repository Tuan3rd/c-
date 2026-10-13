namespace WinForm05Logic;

// Bai 1 (mau): chuyen phan tu qua lai giua 2 ListBox (trai/phai).
// Form giu List<string> song song voi ListBox.Items; cac thao tac Add/Remove/
// AddRange/Clear duoc goi qua day de co the unit test ma khong can dung ListBox.
public static class Bai1ListBoxLogic
{
    public static void ChuyenMotPhanTu(List<string> nguon, List<string> dich, string phanTu)
    {
        dich.Add(phanTu);
        nguon.Remove(phanTu);
    }

    public static void ChuyenTatCa(List<string> nguon, List<string> dich)
    {
        dich.AddRange(nguon);
        nguon.Clear();
    }

    // "Chuyen tuy y": lst_Trai dat SelectionMode nhieu lua chon, chuyen het cac phan tu
    // dang duoc chon (khong chi 1 phan tu nhu button ">"), chon item nao chuyen item do.
    public static void ChuyenNhieuPhanTu(List<string> nguon, List<string> dich, IEnumerable<string> dsDangChon)
    {
        foreach (string phanTu in dsDangChon.ToList())
        {
            dich.Add(phanTu);
            nguon.Remove(phanTu);
        }
    }
}
