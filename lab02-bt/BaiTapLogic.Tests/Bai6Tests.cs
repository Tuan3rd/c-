using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 6: tim gia tri lon nhat cua 3 so nguyen (return gia tri)
    public class Bai6Tests
    {
        [Theory]
        [InlineData(1, 2, 3, 3)]
        [InlineData(3, 2, 1, 3)]
        [InlineData(2, 3, 1, 3)]
        [InlineData(5, 5, 5, 5)]      // ba so bang nhau
        [InlineData(-1, -5, -2, -1)]  // toan so am
        [InlineData(0, -1, 1, 1)]
        public void TimGiaTriLonNhat_CacTruongHop_TraVeDungGiaTri(int a, int b, int c, int mongDoi)
        {
            int ketQua = Bai6_7_SoNguyenService.TimGiaTriLonNhat(a, b, c);

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
