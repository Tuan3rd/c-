using OOPLib;
using Xunit;

namespace OOPLib.Tests;

public class Bai2_2Tests
{
    [Fact]
    public void Add_VaSoLuong_HoatDongDung()
    {
        var ds = new PersonList();
        ds.Add(new Person(1, "A", 2000, 0));
        ds.Add(new Person(2, "B", 1990, 2020));

        Assert.Equal(2, ds.SoLuong);
    }

    [Fact]
    public void LivingPeople_LocDungNguoiConSong()
    {
        var ds = new PersonList();
        ds.Add(new Person(1, "A", 2000, 0));    // con song
        ds.Add(new Person(2, "B", 1990, 2020)); // da mat
        ds.Add(new Person(3, "C", 1985, 0));    // con song

        PersonList conSong = ds.LivingPeople();

        Assert.Equal(2, conSong.SoLuong);
        Assert.Equal("A", conSong[0].Name);
        Assert.Equal("C", conSong[1].Name);
    }

    [Fact]
    public void CopyConstructor_TaoBanSaoDocLapVoiCacPhanTuBenTrong()
    {
        var goc = new PersonList();
        goc.Add(new Person(1, "A", 2000, 0));

        var sao = new PersonList(goc);
        sao[0].Name = "Doi ten";

        // Copy constructor phai deep-copy tung Person, khong chi copy tham chieu list
        Assert.Equal("A", goc[0].Name);
        Assert.Equal("Doi ten", sao[0].Name);
    }
}
