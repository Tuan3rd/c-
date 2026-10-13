namespace WinFormLogic.Tests;

public class BTVNBai1Tests
{
    [Fact]
    public void ManHinh_KhiMoiKhoiTao_Bang0()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        Assert.Equal("0", mayTinh.ManHinh);
    }

    [Fact]
    public void NhapChuSo_NhieuChuSoLienTiep_NoiThanhDungChuoi()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('6');
        mayTinh.NhapChuSo('5');

        Assert.Equal("65", mayTinh.ManHinh);
    }

    [Fact]
    public void Cong_5Va3_KetQuaBang8()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('5');
        mayTinh.ChonPhepToan('+');
        mayTinh.NhapChuSo('3');
        mayTinh.TinhKetQua();

        Assert.Equal("8", mayTinh.ManHinh);
    }

    [Fact]
    public void Tru_10Va4_KetQuaBang6()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('1');
        mayTinh.NhapChuSo('0');
        mayTinh.ChonPhepToan('-');
        mayTinh.NhapChuSo('4');
        mayTinh.TinhKetQua();

        Assert.Equal("6", mayTinh.ManHinh);
    }

    [Fact]
    public void Nhan_6Va7_KetQuaBang42()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('6');
        mayTinh.ChonPhepToan('*');
        mayTinh.NhapChuSo('7');
        mayTinh.TinhKetQua();

        Assert.Equal("42", mayTinh.ManHinh);
    }

    [Fact]
    public void Chia_9Va2_KetQuaBang4Phay5()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('9');
        mayTinh.ChonPhepToan('/');
        mayTinh.NhapChuSo('2');
        mayTinh.TinhKetQua();

        Assert.Equal("4.5", mayTinh.ManHinh);
    }

    [Fact]
    public void Chia_ChoKhong_NemDivideByZeroException()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('5');
        mayTinh.ChonPhepToan('/');
        mayTinh.NhapChuSo('0');

        Assert.Throws<DivideByZeroException>(() => mayTinh.TinhKetQua());
    }

    [Fact]
    public void Xoa_SauKhiNhapVaTinh_TraVeTrangThaiBanDau()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        mayTinh.NhapChuSo('5');
        mayTinh.ChonPhepToan('+');
        mayTinh.NhapChuSo('3');
        mayTinh.TinhKetQua();
        mayTinh.Xoa();

        Assert.Equal("0", mayTinh.ManHinh);
    }

    [Fact]
    public void TinhLienTiep_SuDungKetQuaTruocLamSoThuNhat_RaKetQuaDung()
    {
        var mayTinh = new MayTinhBoTuiLogic();

        // 5 + 3 = 8, roi 8 * 2 = 16
        mayTinh.NhapChuSo('5');
        mayTinh.ChonPhepToan('+');
        mayTinh.NhapChuSo('3');
        mayTinh.TinhKetQua();
        mayTinh.ChonPhepToan('*');
        mayTinh.NhapChuSo('2');
        mayTinh.TinhKetQua();

        Assert.Equal("16", mayTinh.ManHinh);
    }
}
