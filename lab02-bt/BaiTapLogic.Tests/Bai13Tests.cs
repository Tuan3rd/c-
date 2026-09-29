using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 13: lop SinhVien
    public class Bai13Tests
    {
        [Fact]
        public void KhoiTao_GanDungCacThuocTinh()
        {
            var sv = new SinhVien("SV001", "Thai Tuan", "TP.HCM", 3);

            Assert.Equal("SV001", sv.MaSV);
            Assert.Equal("Thai Tuan", sv.HoTen);
            Assert.Equal("TP.HCM", sv.DiaChi);
            Assert.Equal(3, sv.NamThu);
        }

        [Fact]
        public void XuatThongTin_TraVeDungDinhDang()
        {
            var sv = new SinhVien("3123411327", "Thai Tuan", "TP.HCM", 3);

            string ketQua = sv.XuatThongTin();

            Assert.Equal("Ma SV: 3123411327 - Ho ten: Thai Tuan - Dia chi: TP.HCM - Nam thu: 3", ketQua);
        }

        [Fact]
        public void KhoiTao_MaSVNull_NemNgoaiLe()
        {
            Assert.Throws<ArgumentNullException>(() => new SinhVien(null!, "Thai Tuan", "TP.HCM", 3));
        }
    }
}
