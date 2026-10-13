namespace WinForm05ContinueLogic.Tests;

public class Bai3FileTests
{
    [Fact]
    public void GhiNoiDungRoiDocLai_NoiDungTiengViet_KhopChinhXac()
    {
        string duongDan = Path.Combine(Path.GetTempPath(), $"lab05continue_{Guid.NewGuid():N}.txt");
        try
        {
            Bai3FileLogic.GhiNoiDung(duongDan, "Nhập đoạn text có dấu tiếng Việt");

            string noiDung = Bai3FileLogic.DocNoiDung(duongDan);

            Assert.Equal("Nhập đoạn text có dấu tiếng Việt", noiDung);
        }
        finally
        {
            File.Delete(duongDan);
        }
    }

    [Fact]
    public void GhiNoiDung_DeTrong_DocLaiRaChuoiRong()
    {
        string duongDan = Path.Combine(Path.GetTempPath(), $"lab05continue_{Guid.NewGuid():N}.txt");
        try
        {
            Bai3FileLogic.GhiNoiDung(duongDan, "");

            Assert.Equal("", Bai3FileLogic.DocNoiDung(duongDan));
        }
        finally
        {
            File.Delete(duongDan);
        }
    }
}
