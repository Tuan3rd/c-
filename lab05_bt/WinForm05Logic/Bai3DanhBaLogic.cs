namespace WinForm05Logic;

// Bai 3 (BT ve nha): danh ba, TreeView goc la 26 chu cai A-Z, moi nguoi duoc xep
// vao dung node chu cai dau cua First Name.
public static class Bai3DanhBaLogic
{
    public static IEnumerable<char> DanhSachChuCaiAZ()
    {
        for (char c = 'A'; c <= 'Z'; c++)
            yield return c;
    }

    public static bool ThongTinHopLe(string? firstName, string? lastName) =>
        !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName);

    public static char XacDinhChuCaiDau(string firstName) =>
        char.ToUpperInvariant(firstName.Trim()[0]);

    // Hien thi node theo dung mau trong de: "<First Name>, <Last Name>".
    public static string TaoNoiDungNode(string firstName, string lastName) => $"{firstName}, {lastName}";
}
