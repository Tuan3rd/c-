using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 4: giong Bai 3 nhung phai kiem tra du lieu nhap co phai so nguyen khong
    public class Bai4Tests
    {
        [Fact]
        public void ThuTinhLuyThua_HaiSoNguyenHopLe_TraVeTrueVaDungKetQua()
        {
            bool thanhCong = BaiTapService.ThuTinhLuyThua("7", "3", out long ketQua, out string? loi);

            Assert.True(thanhCong);
            Assert.Equal(343, ketQua);
            Assert.Null(loi);
        }

        [Theory]
        [InlineData("abc", "3")]   // x khong phai so
        [InlineData("7", "xyz")]   // y khong phai so
        [InlineData("abc", "xyz")] // ca hai deu sai
        [InlineData("7.5", "3")]   // so thap phan khong phai so nguyen
        [InlineData("", "3")]      // chuoi rong
        [InlineData(null, "3")]    // khong nhap gi (Console.ReadLine co the tra ve null)
        public void ThuTinhLuyThua_DuLieuKhongPhaiSoNguyen_TraVeFalseVaThongBaoLoi(string? inputX, string inputY)
        {
            bool thanhCong = BaiTapService.ThuTinhLuyThua(inputX, inputY, out long ketQua, out string? loi);

            Assert.False(thanhCong);
            Assert.Equal(0, ketQua);
            Assert.Equal("Loi: x hoac y ban nhap khong phai la so nguyen. Vui long thu lai!", loi);
        }

        [Fact]
        public void ThuTinhLuyThua_SoNguyenAm_VanHopLeVaTinhDung()
        {
            // so nguyen am van la so nguyen hop le, khac voi truong hop khong phai so
            bool thanhCong = BaiTapService.ThuTinhLuyThua("-2", "3", out long ketQua, out string? loi);

            Assert.True(thanhCong);
            Assert.Equal(-8, ketQua);
            Assert.Null(loi);
        }
    }
}
