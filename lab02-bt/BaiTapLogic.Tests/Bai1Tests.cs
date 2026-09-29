using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 1: xuat lai ho ten da nhap
    public class Bai1Tests
    {
        [Fact]
        public void TaoLoiChaoHoTen_HoTenBinhThuong_TraVeDungDinhDang()
        {
            string ketQua = BaiTapService.TaoLoiChaoHoTen("Tran Anh Minh");

            Assert.Equal("Ho ten ban vua nhap la: Tran Anh Minh", ketQua);
        }

        [Fact]
        public void TaoLoiChaoHoTen_ChuoiRong_VanTraVeDungTienTo()
        {
            string ketQua = BaiTapService.TaoLoiChaoHoTen("");

            Assert.Equal("Ho ten ban vua nhap la: ", ketQua);
        }

        [Fact]
        public void TaoLoiChaoHoTen_Null_NemNgoaiLe()
        {
            Assert.Throws<ArgumentNullException>(() => BaiTapService.TaoLoiChaoHoTen(null!));
        }
    }
}
