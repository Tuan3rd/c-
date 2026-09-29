using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 11: dao nguoc chuoi
    public class Bai11Tests
    {
        [Theory]
        [InlineData("hello", "olleh")]
        [InlineData("C#", "#C")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData("12345", "54321")]
        public void DaoNguoc_CacTruongHop_TraVeDungKetQua(string s, string mongDoi)
        {
            string ketQua = Bai10_11_12_ChuoiService.DaoNguoc(s);

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void DaoNguoc_GoiHaiLan_TraVeChuoiGocBanDau()
        {
            string goc = "Tran Anh Minh";

            string daoLanMot = Bai10_11_12_ChuoiService.DaoNguoc(goc);
            string daoLanHai = Bai10_11_12_ChuoiService.DaoNguoc(daoLanMot);

            Assert.Equal(goc, daoLanHai);
        }

        [Fact]
        public void DaoNguoc_Null_NemNgoaiLe()
        {
            Assert.Throws<ArgumentNullException>(() => Bai10_11_12_ChuoiService.DaoNguoc(null!));
        }
    }
}
