namespace WinFormLogic.Tests;

public class Bai5Tests
{
    [Theory]
    [InlineData(1, "Một")]
    [InlineData(5, "Năm")]
    [InlineData(10, "Mười")]
    [InlineData(11, "Mười Một")]
    [InlineData(15, "Mười Lăm")]
    [InlineData(20, "Hai Mươi")]
    [InlineData(21, "Hai Mươi Mốt")]
    [InlineData(23, "Hai Mươi Ba")] // Dung mau trong de bai: 23 -> "Hai Mươi Ba"
    [InlineData(25, "Hai Mươi Lăm")]
    [InlineData(100, "Một Trăm")]
    [InlineData(101, "Một Trăm Lẻ Một")]
    [InlineData(105, "Một Trăm Lẻ Năm")]
    [InlineData(110, "Một Trăm Mười")]
    [InlineData(115, "Một Trăm Mười Lăm")]
    [InlineData(121, "Một Trăm Hai Mươi Mốt")]
    [InlineData(999, "Chín Trăm Chín Mươi Chín")]
    public void DocSo_CacGiaTri_TraVeChuoiDocDung(int so, string ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai5DocSoLogic.DocSo(so));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1000)]
    [InlineData(-1)]
    public void DocSo_NgoaiKhoang1Den999_NemArgumentOutOfRangeException(int so)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Bai5DocSoLogic.DocSo(so));
    }

    [Theory]
    [InlineData("23", true, 23)]
    [InlineData("0", false, 0)]
    [InlineData("1000", false, 1000)]
    [InlineData("abc", false, 0)]
    public void LaSoHopLe_CacChuoiNhap_TraVeDungSaiVaGiaTri(string text, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = Bai5DocSoLogic.LaSoHopLe(text, out int giaTri);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, giaTri);
    }
}
