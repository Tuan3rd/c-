using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 3: tinh x^y voi x, y la so nguyen
    public class Bai3Tests
    {
        [Theory]
        [InlineData(7, 3, 343)]        // dung y mau trong de bai
        [InlineData(2, 10, 1024)]
        [InlineData(5, 0, 1)]          // bat ky so nao mu 0 deu bang 1
        [InlineData(0, 5, 0)]          // 0 mu so duong bang 0
        [InlineData(-2, 3, -8)]        // so am mu le van ra so am
        [InlineData(-2, 2, 4)]         // so am mu chan ra so duong
        public void TinhLuyThua_CacTruongHop_TraVeDungKetQua(int x, int y, long mongDoi)
        {
            long ketQua = BaiTapService.TinhLuyThua(x, y);

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void TinhLuyThua_SoLon_KhongTranVaDungKetQua()
        {
            // 2^40 = 1,099,511,627,776 -> vuot gioi han int (~2.1 ty) nen phai dung long
            long ketQua = BaiTapService.TinhLuyThua(2, 40);

            Assert.Equal(1_099_511_627_776L, ketQua);
        }
    }
}
