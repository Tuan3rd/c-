namespace WinForm05ContinueLogic.Tests;

public class Bai1DongHoTests
{
    [Fact]
    public void DinhDangGio_ThoiDiemCuThe_TraVeChuoiKhongRong()
    {
        var thoiDiem = new DateTime(2026, 10, 15, 20, 35, 32);

        string ketQua = Bai1DongHoLogic.DinhDangGio(thoiDiem);

        Assert.False(string.IsNullOrEmpty(ketQua));
        Assert.Equal(thoiDiem.ToString(), ketQua);
    }
}
