using Bai3_LinQ.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_LinQ.Business
{
    public class SanPhamService
    {
        private static SanPhamRepository _sanphamRepository;
        public SanPhamService()
        {
            _sanphamRepository = new SanPhamRepository();
        }
        public void ThemSanPham(SanPham sanpham)
        {

            if (sanpham != null)
            {
                _sanphamRepository.ThemSanPham(sanpham);
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm lỗi!");
            }
        }
        public void SuaSanPham(SanPham sanpham)
        {
            _sanphamRepository.SuaSanPham(sanpham);
        }
        public void XoaSanPham(string maSP)
        {
            _sanphamRepository.XoaSanPham(maSP);
        }
        public List<SanPham> LayDanhSachSP()
        {
            return _sanphamRepository.LayDanhSach();
        }
        public SanPham LaySPGiaCaoNhat()
        {
            SanPham mostExpensiveProduct = new SanPham();
            mostExpensiveProduct = LayDanhSachSP().OrderByDescending(p => p.DonGia).FirstOrDefault();
            return mostExpensiveProduct;
        }
        public List<SanPham> LayDanhSachSPTheoXuatXu(string xuatxu)
        {
            List<SanPham> sameOriginProduct = new List<SanPham>();
            sameOriginProduct = LayDanhSachSP().Where(p => p.XuatXu == xuatxu).ToList();
            return sameOriginProduct;
        }
        public List<SanPham> LayDanhSachSPHetHan()
        {
            List<SanPham> expiredProduct = new List<SanPham>();
            expiredProduct = LayDanhSachSP().Where(p => p.NgayHetHan < DateTime.Now).ToList();
            return expiredProduct;
        }
        public List<SanPham> LayDanhSachSPTrongKhoang(double fromPrice, double toPrice)
        {
            List<SanPham> priceFilteredProduct = new List<SanPham>();
            priceFilteredProduct = LayDanhSachSP().Where(p => (p.DonGia <= toPrice && p.DonGia >= fromPrice)).ToList();
            return priceFilteredProduct;
        }
        public void XoaTatCaTheoXuatXu(string xuatxu)
        {
            List<SanPham> sameOriginProduct = LayDanhSachSPTheoXuatXu(xuatxu);
            foreach (var product in sameOriginProduct)
            {
                _sanphamRepository.XoaSanPham(product.MaSP);
            }
        }
        public bool KiemTraSPHetHan()
        {
            List<SanPham> expiredProduct = LayDanhSachSPHetHan();
            if (expiredProduct.Count == 0)
                return false;
            else return true;
        }

        public void XoaTatCaSP()
        {
            List<SanPham> products = LayDanhSachSP();
            foreach (var product in products)
            {
                _sanphamRepository.XoaSanPham(product.MaSP);
            }
        }
        public void XoaTatCaSPHetHan()
        {
            if (!KiemTraSPHetHan())
            {
            }
            else
            {
                List<SanPham> expiredProduct = LayDanhSachSPHetHan();
                foreach (var product in expiredProduct)
                {
                    _sanphamRepository.XoaSanPham(product.MaSP);
                }
            }
        }
    }
}
