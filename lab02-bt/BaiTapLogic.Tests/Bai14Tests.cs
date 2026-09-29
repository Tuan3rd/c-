using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 14: lop NhanVien, tinh luong (tru 100.000 VND/ngay vang)
    public class Bai14Tests
    {
        [Fact]
        public void TinhLuong_KhongVangNgayNao_LuongBangMucLuong()
        {
            var nv = new NhanVien("Thai Tuan", 10_000_000, 0);

            Assert.Equal(10_000_000, nv.TinhLuong());
        }

        [Fact]
        public void TinhLuong_VangBaNgay_TruDungSoTien()
        {
            var nv = new NhanVien("Thai Tuan", 10_000_000, 3);

            // 10.000.000 - 3 * 100.000 = 9.700.000
            Assert.Equal(9_700_000, nv.TinhLuong());
        }

        [Fact]
        public void TinhLuong_VangQuaNhieuNgay_KhongBiAm_TraVeKhong()
        {
            // vang 200 ngay se tru vuot qua muc luong -> ket qua khong the am, phai la 0
            var nv = new NhanVien("Thai Tuan", 5_000_000, 200);

            Assert.Equal(0, nv.TinhLuong());
        }

        [Fact]
        public void TinhLuong_VangDungBangSoNgayLamHetLuong_TraVeKhong()
        {
            // 2.000.000 / 100.000 = 20 ngay vang la vua het luong
            var nv = new NhanVien("Thai Tuan", 2_000_000, 20);

            Assert.Equal(0, nv.TinhLuong());
        }
    }
}
