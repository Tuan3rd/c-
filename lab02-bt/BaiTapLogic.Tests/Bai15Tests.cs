using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 15: cac phuong thuc tren mang so nguyen
    public class Bai15Tests
    {
        [Fact]
        public void TimMax_MangBinhThuong_TraVeDungGiaTri()
        {
            int[] mang = { 5, 2, 9, 1, 7 };

            Assert.Equal(9, Bai15_MangSoHocService.TimMax(mang));
        }

        [Fact]
        public void TimMin_MangBinhThuong_TraVeDungGiaTri()
        {
            int[] mang = { 5, 2, 9, 1, 7 };

            Assert.Equal(1, Bai15_MangSoHocService.TimMin(mang));
        }

        [Fact]
        public void TimMax_MangCoSoAm_TraVeDungGiaTri()
        {
            int[] mang = { -5, -2, -9, -1 };

            Assert.Equal(-1, Bai15_MangSoHocService.TimMax(mang));
        }

        [Fact]
        public void TimMax_MangRong_NemNgoaiLe()
        {
            Assert.Throws<ArgumentException>(() => Bai15_MangSoHocService.TimMax(Array.Empty<int>()));
        }

        [Fact]
        public void LayMangSoNguyenTo_MangCoLanCoSoNguyenTo_LocDungCacSo()
        {
            int[] mang = { 4, 7, 9, 11, 15, 2 };

            int[] ketQua = Bai15_MangSoHocService.LayMangSoNguyenTo(mang);

            Assert.Equal(new[] { 7, 11, 2 }, ketQua);
        }

        [Fact]
        public void LayMangSoNguyenTo_KhongCoSoNguyenToNao_TraVeMangRong()
        {
            int[] mang = { 4, 6, 8, 9, 10 };

            int[] ketQua = Bai15_MangSoHocService.LayMangSoNguyenTo(mang);

            Assert.Empty(ketQua);
        }
    }
}
