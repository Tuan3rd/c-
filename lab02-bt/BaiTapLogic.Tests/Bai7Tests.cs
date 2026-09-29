using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 7: kiem tra so nguyen to (phuong thuc bool)
    public class Bai7Tests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(13, true)]
        [InlineData(97, true)]
        [InlineData(4, false)]
        [InlineData(9, false)]
        [InlineData(100, false)]
        [InlineData(1, false)]   // 1 khong phai so nguyen to theo dinh nghia
        [InlineData(0, false)]
        [InlineData(-7, false)]  // so am khong phai so nguyen to
        public void KiemTraSoNguyenTo_CacTruongHop_TraVeDungKetQua(int n, bool mongDoi)
        {
            bool ketQua = Bai6_7_SoNguyenService.KiemTraSoNguyenTo(n);

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void KiemTraSoNguyenTo_SoNguyenToLon_TraVeTrue()
        {
            // 7919 la so nguyen to (chon de kiem tra vong lap chay dung voi so lon hon)
            Assert.True(Bai6_7_SoNguyenService.KiemTraSoNguyenTo(7919));
        }
    }
}
