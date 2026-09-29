using System;
using BaiTapLogic;
using Xunit;

namespace BaiTapLogic.Tests
{
    // Unit test cho Bai 16: sap xep mang ho ten tang dan
    public class Bai16Tests
    {
        [Fact]
        public void SapXepTangDan_DanhSachKhongDau_SapXepDungThuTu()
        {
            string[] hoTen = { "Chi", "An", "Binh" };

            string[] ketQua = Bai16_MangHoTenService.SapXepTangDan(hoTen);

            Assert.Equal(new[] { "An", "Binh", "Chi" }, ketQua);
        }

        [Fact]
        public void SapXepTangDan_TenTiengVietCoDau_SapXepDungBangChuCai()
        {
            string[] hoTen = { "Tran Van Cuong", "An Nguyen", "Le Thi Binh" };

            string[] ketQua = Bai16_MangHoTenService.SapXepTangDan(hoTen);

            Assert.Equal(new[] { "An Nguyen", "Le Thi Binh", "Tran Van Cuong" }, ketQua);
        }

        [Fact]
        public void SapXepTangDan_KhongLamThayDoiMangGoc()
        {
            string[] hoTen = { "Chi", "An", "Binh" };

            Bai16_MangHoTenService.SapXepTangDan(hoTen);

            // Mang truyen vao phai giu nguyen thu tu ban dau (ham tra ve mang moi)
            Assert.Equal(new[] { "Chi", "An", "Binh" }, hoTen);
        }

        [Fact]
        public void SapXepTangDan_Null_NemNgoaiLe()
        {
            Assert.Throws<ArgumentNullException>(() => Bai16_MangHoTenService.SapXepTangDan(null!));
        }
    }
}
