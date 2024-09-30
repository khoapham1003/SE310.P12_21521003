using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai3_LinQ.Business;

namespace Bai3_LinQ.Data
{
    public class SanPhamRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=LinQSE310;Integrated Security=True;";

        public SanPhamRepository() { }

        private DataTable LayDataTable()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();

                    string query = "SELECT * FROM SanPham";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                    sqlDataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }

            return dataTable;
        }
        public List<SanPham> LayDanhSach()
        {
            List<SanPham> products = new List<SanPham>();
            DataTable dataTable = this.LayDataTable();
            products = dataTable.AsEnumerable()
     .Select(row => new SanPham
     {
         MaSP = row.Field<string>("MaSP"),
         TenSP = row.Field<string>("TenSP"),
         SoLuong = row.Field<double>("SoLuong"),
         DonGia = row.Field<double>("DonGia"),
         XuatXu = row.Field<string>("XuatXu"),
         NgayHetHan = row.Field<DateTime>("NgayHetHan")
     }).ToList();
            return products;
        }
        public void ThemSanPham(SanPham sanpham)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO SanPham (MaSP, TenSP, SoLuong, DonGia, XuatXu, NgayHetHan) 
                                     VALUES (@MaSP, @TenSP, @SoLuong, @DonGia, @XuatXu, @NgayHetHan)";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaSP", sanpham.MaSP);
                        command.Parameters.AddWithValue("@TenSP", sanpham.TenSP);
                        command.Parameters.AddWithValue("@SoLuong", sanpham.SoLuong);
                        command.Parameters.AddWithValue("@DonGia", sanpham.DonGia);
                        command.Parameters.AddWithValue("@XuatXu", sanpham.XuatXu);
                        command.Parameters.AddWithValue("@NgayHetHan", sanpham.NgayHetHan);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sản phẩm đã được thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi thêm sản phẩm.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
        public void SuaSanPham(SanPham sanpham)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"UPDATE SanPham SET 
                                TenSP = @TenSP,
                                SoLuong = @SoLuong,
                                DonGia = @DonGia,
                                XuatXu = @XuatXu,
                                NgayHetHan = @NgayHetHan
                             WHERE MaSP = @MaSP";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaSP", sanpham.MaSP);
                        command.Parameters.AddWithValue("@TenSP", sanpham.TenSP);
                        command.Parameters.AddWithValue("@SoLuong", sanpham.SoLuong);
                        command.Parameters.AddWithValue("@DonGia", sanpham.DonGia);
                        command.Parameters.AddWithValue("@XuatXu", sanpham.XuatXu);
                        command.Parameters.AddWithValue("@NgayHetHan", sanpham.NgayHetHan);

                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
        public void XoaSanPham(string maSP)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string query = @"DELETE FROM SanPham WHERE MaSP = @MaSP";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@MaSP", maSP);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm cần xóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
