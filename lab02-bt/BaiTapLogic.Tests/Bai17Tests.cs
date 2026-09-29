using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 17: mang 2 chieu ngau nhien va tach chan/le
    public class Bai17Tests
    {
        [Fact]
        public void SinhNgauNhien_TraVeDungKichThuoc()
        {
            var rng = new Random(42); // seed co dinh de ket qua lap lai duoc

            int[,] mang = Bai17_Mang2DService.SinhNgauNhien(3, 4, 10, 100, rng);

            Assert.Equal(3, mang.GetLength(0));
            Assert.Equal(4, mang.GetLength(1));
        }

        [Fact]
        public void SinhNgauNhien_TatCaGiaTriNamTrongDoan()
        {
            var rng = new Random(123);

            int[,] mang = Bai17_Mang2DService.SinhNgauNhien(5, 5, 10, 100, rng);

            foreach (int x in mang)
            {
                Assert.InRange(x, 10, 100);
            }
        }

        [Fact]
        public void SinhNgauNhien_KichThuocKhongHopLe_NemNgoaiLe()
        {
            var rng = new Random();

            Assert.Throws<ArgumentOutOfRangeException>(() => Bai17_Mang2DService.SinhNgauNhien(0, 3, 10, 100, rng));
            Assert.Throws<ArgumentOutOfRangeException>(() => Bai17_Mang2DService.SinhNgauNhien(3, -1, 10, 100, rng));
        }

        [Fact]
        public void TachChanLe_MangBinhThuong_TachDungChanLe()
        {
            int[,] mang = { { 10, 11 }, { 12, 13 } };

            var (chan, le) = Bai17_Mang2DService.TachChanLe(mang);

            Assert.Equal(new[] { 10, 12 }, chan);
            Assert.Equal(new[] { 11, 13 }, le);
        }

        [Fact]
        public void TachChanLe_ToanSoChan_MangLeRong()
        {
            int[,] mang = { { 2, 4 }, { 6, 8 } };

            var (chan, le) = Bai17_Mang2DService.TachChanLe(mang);

            Assert.Equal(new[] { 2, 4, 6, 8 }, chan);
            Assert.Empty(le);
        }
    }
}
