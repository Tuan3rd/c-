namespace WinFormContinueLogic;

// Bai 2 (mau): dinh dang label theo Checkbox (Font Style) + RadioButton (Color).
// 4 checkbox Font Style (Regular/Bold/Italic/Bold and Italic) duoc Form lam cho
// hoat dong loai tru lan nhau (giong radio) ngay trong CheckedChanged; lop nay chi
// giu phan logic thuan: tu 4 trang thai Checked suy ra kieu chu dang chon, va map
// kieu chu đó sang co dam/nghieng hay khong - de co the unit test khong can Form.
public enum KieuChuNhan
{
    Regular,
    Bold,
    Italic,
    BoldItalic
}

public static class MauBai2FormatLogic
{
    // Neu nguoi dung (hoac code) lam cho nhieu hon 1 checkbox dang Checked cung luc,
    // uu tien theo thu tu BoldItalic > Bold > Italic > Regular (truong hop dac biet
    // nhat duoc uu tien truoc) de ket qua luon xac dinh duy nhat.
    public static KieuChuNhan XacDinhKieuChu(bool regular, bool bold, bool italic, bool boldItalic)
    {
        if (boldItalic) return KieuChuNhan.BoldItalic;
        if (bold) return KieuChuNhan.Bold;
        if (italic) return KieuChuNhan.Italic;
        return KieuChuNhan.Regular;
    }

    public static bool LaDam(KieuChuNhan kieuChu) =>
        kieuChu is KieuChuNhan.Bold or KieuChuNhan.BoldItalic;

    public static bool LaNghieng(KieuChuNhan kieuChu) =>
        kieuChu is KieuChuNhan.Italic or KieuChuNhan.BoldItalic;
}
