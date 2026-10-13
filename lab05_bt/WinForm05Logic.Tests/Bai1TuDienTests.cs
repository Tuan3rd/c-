namespace WinForm05Logic.Tests;

public class Bai1TuDienTests
{
    [Fact]
    public void TraNghiaAnhViet_TuCoTonTai_TraVeDungNghia()
    {
        var tuDien = new TuDienLogic();

        bool timThay = tuDien.TraNghiaAnhViet("student", out string nghia);

        Assert.True(timThay);
        Assert.Equal("Sinh viên, học sinh", nghia);
    }

    [Fact]
    public void TraNghiaAnhViet_KhongPhanBietHoaThuong_VanTimThay()
    {
        var tuDien = new TuDienLogic();

        bool timThay = tuDien.TraNghiaAnhViet("STUDENT", out string nghia);

        Assert.True(timThay);
        Assert.Equal("Sinh viên, học sinh", nghia);
    }

    [Fact]
    public void TraNghiaAnhViet_TuKhongTonTai_TraVeFalse()
    {
        var tuDien = new TuDienLogic();

        bool timThay = tuDien.TraNghiaAnhViet("elephant", out _);

        Assert.False(timThay);
    }

    [Fact]
    public void TraNghiaVietAnh_NghiaCoTonTai_TraVeDungTuAnh()
    {
        var tuDien = new TuDienLogic();

        bool timThay = tuDien.TraNghiaVietAnh("Con mèo", out string tuAnh);

        Assert.True(timThay);
        Assert.Equal("cat", tuAnh);
    }

    [Fact]
    public void ThemTu_TuMoi_TraCuuDuocCaHaiChieu()
    {
        var tuDien = new TuDienLogic();

        tuDien.ThemTu("book", "Quyển sách");

        Assert.True(tuDien.TraNghiaAnhViet("book", out string viet));
        Assert.Equal("Quyển sách", viet);
        Assert.True(tuDien.TraNghiaVietAnh("Quyển sách", out string anh));
        Assert.Equal("book", anh);
    }

    [Fact]
    public void TimTuKhopGanNhat_GoChuDau_TraVeDungCacTuBatDauTuongUng()
    {
        var tuDien = new TuDienLogic();

        var ketQua = tuDien.TimTuKhopGanNhat("s", tiengAnh: true);

        Assert.Equal(new[] { "sheep", "snake", "student" }, ketQua);
    }

    [Fact]
    public void TimTuKhopGanNhat_KhongTuNaoKhop_TraVeDanhSachRong()
    {
        var tuDien = new TuDienLogic();

        var ketQua = tuDien.TimTuKhopGanNhat("zz", tiengAnh: true);

        Assert.Empty(ketQua);
    }
}
