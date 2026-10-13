namespace WinFormContinueLogic.Tests;

public class TinhToanTests
{
    [Fact]
    public void KhoiTaoMacDinh_AVaB_Bang0()
    {
        var dt = new TinhToan();

        Assert.Equal(0, dt.A);
        Assert.Equal(0, dt.B);
    }

    [Fact]
    public void KhoiTaoCoThamSo_GanDungAVaB()
    {
        var dt = new TinhToan(5, 3);

        Assert.Equal(5, dt.A);
        Assert.Equal(3, dt.B);
    }

    [Fact]
    public void Cong_5Va3_TraVe8()
    {
        var dt = new TinhToan(5, 3);

        Assert.Equal(8, dt.Cong());
    }

    [Fact]
    public void Tru_5Va3_TraVe2()
    {
        var dt = new TinhToan(5, 3);

        Assert.Equal(2, dt.Tru());
    }

    [Fact]
    public void Nhan_5Va3_TraVe15()
    {
        var dt = new TinhToan(5, 3);

        Assert.Equal(15, dt.Nhan());
    }

    [Fact]
    public void Chia_10Va4_TraVe2Phay5()
    {
        var dt = new TinhToan(10, 4);

        Assert.Equal(2.5f, dt.Chia());
    }

    [Fact]
    public void Chia_ChoKhong_TraVeDuongVoCuc_KhongNemLoi()
    {
        var dt = new TinhToan(10, 0);

        Assert.True(float.IsPositiveInfinity(dt.Chia()));
    }

    [Fact]
    public void SetAVaB_SauKhoiTao_CapNhatDung()
    {
        var dt = new TinhToan { A = 7, B = 2 };

        Assert.Equal(9, dt.Cong());
    }
}

public class Bai1RadioTinhToanLogicTests
{
    [Theory]
    [InlineData("10", true)]
    [InlineData("-3.5", true)]
    [InlineData("", false)]
    [InlineData("abc", false)]
    public void LaSoHopLe_CacChuoiNhap_TraVeDungSai(string text, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1RadioTinhToanLogic.LaSoHopLe(text));
    }

    [Theory]
    [InlineData('5', "12", 2, true)]
    [InlineData('a', "12", 2, false)]
    [InlineData('-', "", 0, true)]
    [InlineData('-', "5", 1, false)]
    [InlineData('.', "12", 2, true)]
    [InlineData('.', "1.2", 3, false)]
    public void LaKyTuNhapSoDuocPhep_CacTruongHop_TraVeDungSai(char kyTu, string textHienTai, int viTri, bool ketQuaMongDoi)
    {
        Assert.Equal(ketQuaMongDoi, Bai1RadioTinhToanLogic.LaKyTuNhapSoDuocPhep(kyTu, textHienTai, viTri));
    }

    [Fact]
    public void PhepToanDangChon_RadioCongDuocChon_TraVeDauCong()
    {
        Assert.Equal('+', Bai1RadioTinhToanLogic.PhepToanDangChon(true, false, false, false));
    }

    [Fact]
    public void PhepToanDangChon_RadioChiaDuocChon_TraVeDauChia()
    {
        Assert.Equal('/', Bai1RadioTinhToanLogic.PhepToanDangChon(false, false, false, true));
    }

    [Fact]
    public void PhepToanDangChon_KhongRadioNaoDuocChon_TraVeNull()
    {
        Assert.Null(Bai1RadioTinhToanLogic.PhepToanDangChon(false, false, false, false));
    }
}
