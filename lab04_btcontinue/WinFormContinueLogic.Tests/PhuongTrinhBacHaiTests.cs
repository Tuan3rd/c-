namespace WinFormContinueLogic.Tests;

public class PhuongTrinhBacHaiTests
{
    // ---------- Bac nhat: ax + b = 0 ----------

    [Fact]
    public void GiaiBacNhat_MauTrongDeBai_1VaAm2_TraVeNghiem2()
    {
        // a=1, b=-2 -> x = -b/a = 2.00, dung nhu hinh minh hoa trong de
        var pt = new PhuongTrinhBacHai(1, -2);

        var (loai, x) = pt.GiaiBacNhat();

        Assert.Equal(LoaiNghiemBacNhat.MotNghiem, loai);
        Assert.Equal(2f, x);
        Assert.Equal("Phương trình có nghiệm x = 2.00", pt.MoTaKetQuaBacNhat());
    }

    [Fact]
    public void GiaiBacNhat_ABang0VaBKhac0_VoNghiem()
    {
        var pt = new PhuongTrinhBacHai(0, 5);

        var (loai, _) = pt.GiaiBacNhat();

        Assert.Equal(LoaiNghiemBacNhat.VoNghiem, loai);
        Assert.Equal("Phương trình vô nghiệm", pt.MoTaKetQuaBacNhat());
    }

    [Fact]
    public void GiaiBacNhat_ABang0VaBBang0_VoSoNghiem()
    {
        var pt = new PhuongTrinhBacHai(0, 0);

        var (loai, _) = pt.GiaiBacNhat();

        Assert.Equal(LoaiNghiemBacNhat.VoSoNghiem, loai);
        Assert.Equal("Phương trình vô số nghiệm", pt.MoTaKetQuaBacNhat());
    }

    // ---------- Bac hai: ax^2 + bx + c = 0 ----------

    [Fact]
    public void GiaiBacHai_MauTrongDeBai_1Am2_1_NghiemKepBang1()
    {
        // a=1, b=-2, c=1 -> delta=0 -> nghiem kep x1=x2=1.00, dung nhu hinh minh hoa
        var pt = new PhuongTrinhBacHai(1, -2, 1);

        var (loai, x1, x2) = pt.GiaiBacHai();

        Assert.Equal(LoaiNghiemBacHai.NghiemKep, loai);
        Assert.Equal(1f, x1);
        Assert.Equal(1f, x2);
        Assert.Equal("Phương trình có nghiệm kép x1 = x2 = 1.00", pt.MoTaKetQuaBacHai());
    }

    [Fact]
    public void GiaiBacHai_DeltaDuong_HaiNghiemPhanBiet()
    {
        // x^2 - 5x + 6 = 0 -> x = 2 hoac x = 3
        var pt = new PhuongTrinhBacHai(1, -5, 6);

        var (loai, x1, x2) = pt.GiaiBacHai();

        Assert.Equal(LoaiNghiemBacHai.HaiNghiemPhanBiet, loai);
        Assert.Equal(3f, x1);
        Assert.Equal(2f, x2);
    }

    [Fact]
    public void GiaiBacHai_DeltaAm_VoNghiem()
    {
        // x^2 + x + 1 = 0 -> delta = 1 - 4 = -3 < 0
        var pt = new PhuongTrinhBacHai(1, 1, 1);

        var (loai, _, _) = pt.GiaiBacHai();

        Assert.Equal(LoaiNghiemBacHai.VoNghiem, loai);
        Assert.Equal("Phương trình vô nghiệm", pt.MoTaKetQuaBacHai());
    }

    [Fact]
    public void GiaiBacHai_ABang0_NemArgumentException()
    {
        var pt = new PhuongTrinhBacHai(0, 2, 1);

        Assert.Throws<ArgumentException>(() => pt.GiaiBacHai());
    }
}
