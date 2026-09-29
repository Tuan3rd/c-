using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 8: hoan vi 2 so thuc bang tham chieu ref
    public class Bai8Tests
    {
        [Fact]
        public void HoanVi_HaiSoKhacNhau_DoiGiaTriChoNhau()
        {
            double a = 1.5;
            double b = 2.5;

            Bai8_9_SoThucService.HoanVi(ref a, ref b);

            Assert.Equal(2.5, a);
            Assert.Equal(1.5, b);
        }

        [Fact]
        public void HoanVi_HaiSoBangNhau_KetQuaKhongDoi()
        {
            double a = 3.0;
            double b = 3.0;

            Bai8_9_SoThucService.HoanVi(ref a, ref b);

            Assert.Equal(3.0, a);
            Assert.Equal(3.0, b);
        }

        [Fact]
        public void HoanVi_MotSoAmMotSoDuong_DoiDungGiaTri()
        {
            double a = -4.2;
            double b = 8.1;

            Bai8_9_SoThucService.HoanVi(ref a, ref b);

            Assert.Equal(8.1, a);
            Assert.Equal(-4.2, b);
        }
    }
}
