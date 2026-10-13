namespace QLSinhVienLogic.Tests;

public class SanPhamRepositoryTests
{
    [Fact]
    public void Them_SanPhamMoi_TuDongTangMaSP()
    {
        var repo = new InMemorySanPhamRepository(QLCuaHangDuLieuMau.SanPhamMau());

        var sanPhamMoi = repo.Them("Bánh quy");

        Assert.Equal(6, sanPhamMoi.MaSP);
        Assert.True(repo.TonTai(6));
    }

    [Fact]
    public void Them_KhoKhoiTao_MaSPBatDauTu1()
    {
        var repo = new InMemorySanPhamRepository();

        var sanPhamMoi = repo.Them("Trà xanh");

        Assert.Equal(1, sanPhamMoi.MaSP);
    }

    [Fact]
    public void TonTai_MaSPKhongTonTai_TraVeFalse()
    {
        var repo = new InMemorySanPhamRepository(QLCuaHangDuLieuMau.SanPhamMau());

        Assert.False(repo.TonTai(999));
    }
}

public class TonKhoRepositoryTests
{
    [Fact]
    public void LayTheoSanPhamVaNgay_DongTonTai_TraVeDungDong()
    {
        var repo = new InMemoryTonKhoRepository(QLCuaHangDuLieuMau.TonKhoMau());

        var dong = repo.LayTheoSanPhamVaNgay(1, QLCuaHangDuLieuMau.NgayMauBanDau);

        Assert.NotNull(dong);
        Assert.Equal(50, dong!.SLDau);
    }

    [Fact]
    public void LayTheoSanPhamVaNgay_KhongTonTai_TraVeNull()
    {
        var repo = new InMemoryTonKhoRepository(QLCuaHangDuLieuMau.TonKhoMau());

        Assert.Null(repo.LayTheoSanPhamVaNgay(1, QLCuaHangDuLieuMau.NgayMauBanDau.AddDays(99)));
    }

    [Fact]
    public void Them_DaCoDongChoCungSanPhamVaNgay_NemInvalidOperationException()
    {
        var repo = new InMemoryTonKhoRepository(QLCuaHangDuLieuMau.TonKhoMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.Them(new TonKho { MaSP = 1, NgayTon = QLCuaHangDuLieuMau.NgayMauBanDau, SLDau = 10, SLNhap = 0, SLBan = 0 }));
    }

    [Fact]
    public void CongSoLuongBan_DongTonTai_CongDungVaoSLBan()
    {
        var repo = new InMemoryTonKhoRepository(QLCuaHangDuLieuMau.TonKhoMau());

        repo.CongSoLuongBan(1, QLCuaHangDuLieuMau.NgayMauBanDau, 5);
        repo.CongSoLuongBan(1, QLCuaHangDuLieuMau.NgayMauBanDau, 3);

        var dong = repo.LayTheoSanPhamVaNgay(1, QLCuaHangDuLieuMau.NgayMauBanDau);
        Assert.Equal(8, dong!.SLBan);
    }

    [Fact]
    public void CongSoLuongBan_KhongTimThayDong_NemInvalidOperationException()
    {
        var repo = new InMemoryTonKhoRepository(QLCuaHangDuLieuMau.TonKhoMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.CongSoLuongBan(999, QLCuaHangDuLieuMau.NgayMauBanDau, 1));
    }
}

public class HoaDonRepositoryTests
{
    [Fact]
    public void TaoHoaDonMoi_TuDongTangMaHD_ChuaThanhToan()
    {
        var repo = new InMemoryHoaDonRepository(QLCuaHangDuLieuMau.HoaDonMau());

        var hoaDonMoi = repo.TaoHoaDonMoi(new DateTime(2026, 10, 13));

        Assert.Equal(2, hoaDonMoi.MaHD);
        Assert.Equal(0, hoaDonMoi.TinhTrangThanhToan);
    }

    [Fact]
    public void DanhDauDaThanhToan_HoaDonTonTai_CapNhatTrangThai()
    {
        var repo = new InMemoryHoaDonRepository();
        var hoaDon = repo.TaoHoaDonMoi(DateTime.Today);

        repo.DanhDauDaThanhToan(hoaDon.MaHD);

        Assert.Equal(1, repo.LayTatCa().First(hd => hd.MaHD == hoaDon.MaHD).TinhTrangThanhToan);
    }

    [Fact]
    public void DanhDauDaThanhToan_MaHDKhongTonTai_NemInvalidOperationException()
    {
        var repo = new InMemoryHoaDonRepository();

        Assert.Throws<InvalidOperationException>(() => repo.DanhDauDaThanhToan(999));
    }
}

public class ChiTietHoaDonRepositoryTests
{
    [Fact]
    public void Them_ChiTietMoi_XuatHienTrongLayTatCa()
    {
        var repo = new InMemoryChiTietHoaDonRepository();

        repo.Them(new ChiTietHoaDon { MaHD = 1, MaSP = 2, SoLuong = 3 });

        Assert.True(repo.TonTai(1, 2));
    }

    [Fact]
    public void Them_SanPhamDaCoTrongHoaDon_NemInvalidOperationException()
    {
        var repo = new InMemoryChiTietHoaDonRepository(QLCuaHangDuLieuMau.ChiTietHoaDonMau());

        Assert.Throws<InvalidOperationException>(() =>
            repo.Them(new ChiTietHoaDon { MaHD = 1, MaSP = 1, SoLuong = 1 }));
    }
}

public class TonKhoLogicTests
{
    [Fact]
    public void TonHienTai_TinhDungTheoCongThuc()
    {
        var tonKho = new TonKho { MaSP = 1, NgayTon = DateTime.Today, SLDau = 50, SLNhap = 10, SLBan = 15 };

        Assert.Equal(45, TonKhoLogic.TonHienTai(tonKho));
    }

    // Bai 1 (BT ve nha): SLDau(ngay moi) = SLDau(ngay truoc) + SLNhap(ngay truoc) - SLBan(ngay truoc),
    // SLNhap/SLBan cua ngay moi luon la 0.
    [Fact]
    public void TaoDongNgayMoi_CoDuLieuNgayTruoc_ChuyenDungSLDau()
    {
        var ngayTruoc = new TonKho { MaSP = 1, NgayTon = new DateTime(2026, 10, 12), SLDau = 50, SLNhap = 20, SLBan = 30 };

        var dongMoi = TonKhoLogic.TaoDongNgayMoi(ngayTruoc, maSP: 1, ngayMoi: new DateTime(2026, 10, 13));

        Assert.Equal(40, dongMoi.SLDau); // 50 + 20 - 30
        Assert.Equal(0, dongMoi.SLNhap);
        Assert.Equal(0, dongMoi.SLBan);
    }

    [Fact]
    public void TaoDongNgayMoi_KhongCoDuLieuNgayTruoc_SLDauBangKhong()
    {
        var dongMoi = TonKhoLogic.TaoDongNgayMoi(null, maSP: 1, ngayMoi: DateTime.Today);

        Assert.Equal(0, dongMoi.SLDau);
    }

    [Fact]
    public void DongGanNhatTruocNgay_CoNhieuDong_LayDongMoiNhatTruocNgayChiDinh()
    {
        var tonKhoSanPham1 = new List<TonKho>
        {
            new() { MaSP = 1, NgayTon = new DateTime(2026, 10, 10), SLDau = 10, SLNhap = 0, SLBan = 0 },
            new() { MaSP = 1, NgayTon = new DateTime(2026, 10, 12), SLDau = 20, SLNhap = 0, SLBan = 0 },
            new() { MaSP = 1, NgayTon = new DateTime(2026, 10, 13), SLDau = 30, SLNhap = 0, SLBan = 0 },
        };

        var donGanNhat = TonKhoLogic.DongGanNhatTruocNgay(tonKhoSanPham1, new DateTime(2026, 10, 13));

        Assert.NotNull(donGanNhat);
        Assert.Equal(new DateTime(2026, 10, 12), donGanNhat!.NgayTon);
    }

    [Fact]
    public void DongGanNhatTruocNgay_KhongCoDongNaoTruocNgay_TraVeNull()
    {
        var tonKhoSanPham1 = new List<TonKho>
        {
            new() { MaSP = 1, NgayTon = new DateTime(2026, 10, 13), SLDau = 30, SLNhap = 0, SLBan = 0 },
        };

        Assert.Null(TonKhoLogic.DongGanNhatTruocNgay(tonKhoSanPham1, new DateTime(2026, 10, 13)));
    }
}

public class BanHangValidationTests
{
    [Theory]
    [InlineData("5", 50, true, 5)]
    [InlineData("50", 50, true, 50)]   // ban het so luong con ton - van hop le
    [InlineData("51", 50, false, 51)]  // vuot qua so luong con ton
    [InlineData("0", 50, false, 0)]
    [InlineData("-3", 50, false, -3)]
    [InlineData("abc", 50, false, 0)]
    public void SoLuongHopLe_CacTruongHop_TraVeDungSaiVaGiaTri(string text, int tonHienTai, bool ketQuaMongDoi, int giaTriMongDoi)
    {
        bool ketQua = BanHangValidation.SoLuongHopLe(text, tonHienTai, out int soLuong);

        Assert.Equal(ketQuaMongDoi, ketQua);
        Assert.Equal(giaTriMongDoi, soLuong);
    }
}
