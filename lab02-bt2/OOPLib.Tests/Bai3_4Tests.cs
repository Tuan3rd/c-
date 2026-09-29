using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai3_4Tests
{
    // Lop test noi bo de "kich hoat" su kien Choose ma khong can doc ban phim that
    // (OnChoose la protected nen lop con goi truc tiep duoc, khong can reflection)
    private class MenuTest : ConsoleMenu
    {
        public void KichHoatChucNang(string chucNang) => OnChoose(chucNang);
    }

    [Fact]
    public void ConsoleMenu_Choose_SuKienDuocPhatDungThamSo()
    {
        var menu = new MenuTest();
        string? nhanDuoc = null;
        menu.Choose += (sender, chucNang) => nhanDuoc = chucNang;

        menu.KichHoatChucNang("1");

        Assert.Equal("1", nhanDuoc);
    }

    [Fact]
    public void ConsoleMenu_KhongDangKySuKien_KhongNemLoi()
    {
        var menu = new MenuTest();

        // Khong co ai dang ky Choose += ..., van khong duoc crash (nho toan tu ?.)
        var ex = Record.Exception(() => menu.KichHoatChucNang("1"));

        Assert.Null(ex);
    }

    // ---------- PTBac2Console.GiaiPTBac2: dung lai dung thuat toan da kiem chung o lab truoc ----------

    [Fact]
    public void GiaiPTBac2_DeltaLonHon0_TraVeHaiNghiem()
    {
        double x1 = 0, x2 = 0;
        int sn = PTBac2Console.GiaiPTBac2(1, -3, 2, ref x1, ref x2);

        Assert.Equal(2, sn);
        Assert.Equal(1, x1);
        Assert.Equal(2, x2);
    }

    [Fact]
    public void GiaiPTBac2_DeltaNhoHon0_TraVeVoNghiem()
    {
        double x1 = 0, x2 = 0;
        int sn = PTBac2Console.GiaiPTBac2(1, 0, 1, ref x1, ref x2);

        Assert.Equal(0, sn);
    }
}
