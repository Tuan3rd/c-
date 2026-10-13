namespace WinForm05ContinueLogic;

// Bai 3 (mau): luu/doc noi dung text ra file - boc lai File.WriteAllText/ReadAllText
// thanh 2 ham mong de Form khong goi thang System.IO (de thay the/kiem tra sau nay),
// va de co the unit test bang file tam that (khong gia lap he thong file).
public static class Bai3FileLogic
{
    public const string BoLocFileText = "Text files (*.txt)|*.txt";

    public static void GhiNoiDung(string duongDan, string noiDung) => File.WriteAllText(duongDan, noiDung);

    public static string DocNoiDung(string duongDan) => File.ReadAllText(duongDan);
}
