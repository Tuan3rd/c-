namespace QLSinhVienLogic.Tests;

public class DiemChiTietLogicTests
{
    private readonly List<Diem> _dsDiem = QLSinhVienDuLieuMau.DiemMau();
    private readonly List<SinhVien> _dsSinhVien = QLSinhVienDuLieuMau.SinhVienMau();
    private readonly List<MonHoc> _dsMonHoc = QLSinhVienDuLieuMau.MonHocMau();

    [Fact]
    public void LayDanhSach_KhongLoc_TraVeDuTatCaDongDaJoin()
    {
        var ketQua = DiemChiTietLogic.LayDanhSach(_dsDiem, _dsSinhVien, _dsMonHoc, maMonHocLoc: null);

        Assert.Equal(_dsDiem.Count, ketQua.Count);
        Assert.Contains(ketQua, d => d.TenSV == "Nguyễn Văn A" && d.TenMonHoc == "Lập trình C#" && d.DiemSo == 8.5);
    }

    [Fact]
    public void LayDanhSach_LocTheoMaMonHoc_ChiTraVeDungMonDo()
    {
        var ketQua = DiemChiTietLogic.LayDanhSach(_dsDiem, _dsSinhVien, _dsMonHoc, maMonHocLoc: "LTC001");

        Assert.Equal(2, ketQua.Count);
        Assert.All(ketQua, d => Assert.Equal("Lập trình C#", d.TenMonHoc));
    }

    [Fact]
    public void LayDanhSach_LocRong_CoiNhuLayTatCa()
    {
        var ketQua = DiemChiTietLogic.LayDanhSach(_dsDiem, _dsSinhVien, _dsMonHoc, maMonHocLoc: "");

        Assert.Equal(_dsDiem.Count, ketQua.Count);
    }

    [Fact]
    public void TinhTongDiem_DanhSachLocTheoLTC001_BangTongDungCuaHaiDiem()
    {
        var danhSach = DiemChiTietLogic.LayDanhSach(_dsDiem, _dsSinhVien, _dsMonHoc, "LTC001");

        double tong = DiemChiTietLogic.TinhTongDiem(danhSach);

        Assert.Equal(17.5, tong);
    }

    [Fact]
    public void TinhTongDiem_DanhSachRong_BangKhong()
    {
        Assert.Equal(0, DiemChiTietLogic.TinhTongDiem([]));
    }
}
