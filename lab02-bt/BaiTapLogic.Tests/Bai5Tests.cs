using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 5: tinh x^y (so thuc) va can bac 2 cua x, y
    public class Bai5Tests
    {
        [Theory]
        [InlineData(4, 2, 16)]
        [InlineData(2, 0.5, 1.4142135623730951)] // can bac 2 cua 2, viet duoi dang luy thua
        [InlineData(9, 0, 1)]
        public void TinhLuyThuaThuc_CacTruongHop_TraVeDungKetQua(double x, double y, double mongDoi)
        {
            double ketQua = BaiTapService.TinhLuyThuaThuc(x, y);

            Assert.Equal(mongDoi, ketQua, 10); // so sanh voi sai so 10 chu so thap phan
        }

        [Fact]
        public void ThuTinhCanBac2_HaiSoKhongAm_TraVeTrueVaDungKetQua()
        {
            bool thanhCong = BaiTapService.ThuTinhCanBac2(4, 2, out double canX, out double canY, out string? loi);

            Assert.True(thanhCong);
            Assert.Equal(2, canX, 10);
            Assert.Equal(1.4142135623730951, canY, 10);
            Assert.Null(loi);
        }

        [Fact]
        public void ThuTinhCanBac2_XLaSoAm_TraVeFalseVaThongBaoLoi()
        {
            bool thanhCong = BaiTapService.ThuTinhCanBac2(-4, 2, out double canX, out double canY, out string? loi);

            Assert.False(thanhCong);
            Assert.Equal("Khong tinh duoc can bac 2 cua so am.", loi);
        }

        [Fact]
        public void ThuTinhCanBac2_YLaSoAm_TraVeFalseVaThongBaoLoi()
        {
            bool thanhCong = BaiTapService.ThuTinhCanBac2(4, -2, out double canX, out double canY, out string? loi);

            Assert.False(thanhCong);
            Assert.Equal("Khong tinh duoc can bac 2 cua so am.", loi);
        }

        [Fact]
        public void ThuTinhCanBac2_CaHaiDeuAm_TraVeFalse()
        {
            bool thanhCong = BaiTapService.ThuTinhCanBac2(-4, -9, out double canX, out double canY, out string? loi);

            Assert.False(thanhCong);
            Assert.Equal("Khong tinh duoc can bac 2 cua so am.", loi);
        }

        [Fact]
        public void ThuTinhCanBac2_BangKhong_TraVeTrueVaKetQuaBangKhong()
        {
            bool thanhCong = BaiTapService.ThuTinhCanBac2(0, 0, out double canX, out double canY, out string? loi);

            Assert.True(thanhCong);
            Assert.Equal(0, canX);
            Assert.Equal(0, canY);
        }
    }
}
