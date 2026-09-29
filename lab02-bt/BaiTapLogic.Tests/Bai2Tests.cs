using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 2: cau chao theo dinh dang "Chao ban {hoTen}!"
    public class Bai2Tests
    {
        [Fact]
        public void ChaoBan_HoTenBinhThuong_TraVeDungDinhDang()
        {
            string ketQua = BaiTapService.ChaoBan("Tran Anh Minh");

            Assert.Equal("Chao ban Tran Anh Minh!", ketQua);
        }

        [Theory]
        [InlineData("A", "Chao ban A!")]
        [InlineData("Nguyen Van B", "Chao ban Nguyen Van B!")]
        public void ChaoBan_NhieuGiaTri_TraVeDungKetQua(string hoTen, string mongDoi)
        {
            Assert.Equal(mongDoi, BaiTapService.ChaoBan(hoTen));
        }

        [Fact]
        public void ChaoBan_Null_NemNgoaiLe()
        {
            Assert.Throws<ArgumentNullException>(() => BaiTapService.ChaoBan(null!));
        }
    }
}
