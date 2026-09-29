using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 12: chuyen hoa/thuong va dem so tu trong chuoi
    public class Bai12Tests
    {
        [Fact]
        public void ChuyenHoa_ChuoiThuong_TraVeChuHoa()
        {
            Assert.Equal("XIN CHAO", Bai10_11_12_ChuoiService.ChuyenHoa("xin chao"));
        }

        [Fact]
        public void ChuyenThuong_ChuoiHoa_TraVeChuThuong()
        {
            Assert.Equal("xin chao", Bai10_11_12_ChuoiService.ChuyenThuong("XIN CHAO"));
        }

        [Theory]
        [InlineData("Xin chao cac ban", 4)]
        [InlineData("mot", 1)]
        [InlineData("", 0)]
        [InlineData("   ", 0)]                     // chi toan khoang trang -> 0 tu
        [InlineData("Xin   chao    cac ban", 4)]    // nhieu khoang trang lien tiep giua cac tu
        [InlineData("  Xin chao  ", 2)]             // khoang trang o dau/cuoi khong tinh la tu
        public void DemSoTu_CacTruongHop_TraVeDungSoLuong(string s, int mongDoi)
        {
            int ketQua = Bai10_11_12_ChuoiService.DemSoTu(s);

            Assert.Equal(mongDoi, ketQua);
        }
    }
}
