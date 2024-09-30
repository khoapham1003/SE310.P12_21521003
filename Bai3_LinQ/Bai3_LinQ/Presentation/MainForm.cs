using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bai3_LinQ.Business;

namespace Bai3_LinQ
{
    public partial class MainForm : Form
    {
        private static SanPhamService _sanPhamService = new SanPhamService();
        private List<SanPham> products = _sanPhamService.LayDanhSachSP();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_caonhat_Click(object sender, EventArgs e)
        {
            SanPham sanpham = _sanPhamService.LaySPGiaCaoNhat();
            List<SanPham> ds = new List<SanPham> { sanpham };
            dgv_timkiem.DataSource = ds;

        }

        private void btn_NhatBan_Click(object sender, EventArgs e)
        {
            SanPham sanpham = _sanPhamService.LayDanhSachSPTheoXuatXu("Nhat Ban").FirstOrDefault();
            List<SanPham> ds = new List<SanPham> { sanpham };
            dgv_timkiem.DataSource = ds;
        }

        private void btn_quahan_Click(object sender, EventArgs e)
        {
            dgv_timkiem.DataSource = _sanPhamService.LayDanhSachSPHetHan();
        }

        private void btn_trongkhoang_Click(object sender, EventArgs e)
        {
            try
            {
                double fromPrice = Int32.Parse(tb_khoangthap.Text);
                double toPrice = Int32.Parse(tb_khoangcao.Text);
                dgv_timkiem.DataSource = _sanPhamService.LayDanhSachSPTrongKhoang(fromPrice, toPrice);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập khoảng");
            }
        }

        private void btn_xoaXXbatki_Click(object sender, EventArgs e)
        {
            string xuatxu = tb_xuatxudexoa.Text;
            _sanPhamService.XoaTatCaTheoXuatXu(xuatxu);
            LamMoi();
        }

        private void btn_kiemtraquahan_Click(object sender, EventArgs e)
        {
            if (_sanPhamService.KiemTraSPHetHan())
            {
                lb_sphethan.Text = "Có sản phẩm hết hạn";
            }
            else
                lb_sphethan.Text = "Không có sản phẩm hết hạn";
        }

        private void btn_xoatoanbo_Click(object sender, EventArgs e)
        {
            _sanPhamService.XoaTatCaSP();
            LamMoi();
        }

        private void btn_xoatoanboquahan_Click(object sender, EventArgs e)
        {
            _sanPhamService.XoaTatCaSPHetHan();
            LamMoi();
        }
        private void btn_luuSP_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham()
            {
                MaSP = tb_masp.Text,
                TenSP = tb_tensp.Text,
                SoLuong = double.Parse(tb_soluong.Text),
                DonGia = double.Parse(tb_dongia.Text),
                XuatXu = tb_xuatxu.Text,
                NgayHetHan = dtp_ngayhethan.Value.Date
            };
            _sanPhamService.ThemSanPham(sanpham);
            LamMoi();
        }

        private void btn_xoaSP_Click(object sender, EventArgs e)
        {
            string maSP = tb_masp.Text;
            _sanPhamService.XoaSanPham(maSP);
            LamMoi();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham()
            {
                MaSP = tb_masp.Text,
                TenSP = tb_tensp.Text,
                SoLuong = double.Parse(tb_soluong.Text),
                DonGia = double.Parse(tb_dongia.Text),
                XuatXu = tb_xuatxu.Text,
                NgayHetHan = dtp_ngayhethan.Value.Date
            };
            _sanPhamService.SuaSanPham(sanpham);
            LamMoi();
        }
        private void LamTrong()
        {
            tb_masp.Clear();
            tb_tensp.Clear();
            tb_soluong.Clear();
            tb_dongia.Clear();
            tb_xuatxu.Clear();
            dtp_ngayhethan.Value = DateTime.Now;
            LamMoi();
        }
        private void LamMoi()
        {
            products = _sanPhamService.LayDanhSachSP();
            dgv_tatca.DataSource = products;
            dgv_timkiem.DataSource = products;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgv_tatca.DataSource = products;
            dgv_timkiem.DataSource = products;
        }

        private void dgv_tatca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgv_tatca.Rows[e.RowIndex];
                SanPham sanpham = new SanPham
                {
                    MaSP = row.Cells["MaSP"].Value.ToString(),
                    TenSP = row.Cells["TenSP"].Value.ToString(),
                    SoLuong = Convert.ToDouble(row.Cells["SoLuong"].Value),
                    DonGia = Convert.ToDouble(row.Cells["DonGia"].Value),
                    XuatXu = row.Cells["XuatXu"].Value.ToString(),
                    NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                };
                tb_masp.Text = sanpham.MaSP;
                tb_tensp.Text = sanpham.TenSP;
                tb_soluong.Text = sanpham.SoLuong.ToString();
                tb_dongia.Text = sanpham.DonGia.ToString();
                tb_xuatxu.Text = sanpham.XuatXu;
                dtp_ngayhethan.Value = sanpham.NgayHetHan;
            }
        }
    }
}
