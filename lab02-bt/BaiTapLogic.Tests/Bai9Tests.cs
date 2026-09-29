using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 9: tim min/max cua 3 so thuc bang tham chieu out
    public class Bai9Tests
    {
        [Fact]
        public void TimMinMax_BaSoKhacNhau_TraVeDungMinMax()
        {
            Bai8_9_SoThucService.TimMinMax(3.5, 1.2, 9.8, out double min, out double max);

            Assert.Equal(1.2, min);
            Assert.Equal(9.8, max);
        }

        [Fact]
        public void TimMinMax_BaSoBangNhau_MinBangMax()
        {
            Bai8_9_SoThucService.TimMinMax(5.0, 5.0, 5.0, out double min, out double max);

            Assert.Equal(5.0, min);
            Assert.Equal(5.0, max);
        }

        [Fact]
        public void TimMinMax_CoSoAm_TraVeDungMinMax()
        {
            Bai8_9_SoThucService.TimMinMax(-3.0, -10.0, 2.5, out double min, out double max);

            Assert.Equal(-10.0, min);
            Assert.Equal(2.5, max);
        }

        [Theory]
        [InlineData(1.0, 2.0, 3.0)] // max o vi tri thu 3
        [InlineData(3.0, 2.0, 1.0)] // max o vi tri thu 1
        [InlineData(2.0, 3.0, 1.0)] // max o vi tri thu 2
        public void TimMinMax_MaxONhieuViTriKhacNhau_VanTraVeDung(double a, double b, double c)
        {
            Bai8_9_SoThucService.TimMinMax(a, b, c, out double min, out double max);

            Assert.Equal(1.0, min);
            Assert.Equal(3.0, max);
        }
    }
}
