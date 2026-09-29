using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 10: kiem tra chuoi doi xung
    public class Bai10Tests
    {
        [Theory]
        [InlineData("level", true)]
        [InlineData("abcba", true)]
        [InlineData("a", true)]     // mot ky tu luon doi xung
        [InlineData("", true)]      // chuoi rong luon doi xung
        [InlineData("aa", true)]
        [InlineData("abc", false)]
        [InlineData("abcd", false)]
        public void KiemTraDoiXung_CacTruongHop_TraVeDungKetQua(string s, bool mongDoi)
        {
            bool ketQua = Bai10_11_12_ChuoiService.KiemTraDoiXung(s);

            Assert.Equal(mongDoi, ketQua);
        }

        [Fact]
        public void KiemTraDoiXung_PhanBietHoaThuong()
        {
            // "Aba" dao nguoc la "abA", khac "Aba" (phan biet hoa/thuong)
            // nen KHONG duoc coi la doi xung
            Assert.False(Bai10_11_12_ChuoiService.KiemTraDoiXung("Aba"));
        }

        [Fact]
        public void KiemTraDoiXung_Null_NemNgoaiLe()
        {
            Assert.Throws<ArgumentNullException>(() => Bai10_11_12_ChuoiService.KiemTraDoiXung(null!));
        }
    }
}
