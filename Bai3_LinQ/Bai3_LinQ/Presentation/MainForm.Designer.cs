namespace Bai3_LinQ
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_sua = new Button();
            dtp_ngayhethan = new DateTimePicker();
            tb_xuatxu = new TextBox();
            tb_dongia = new TextBox();
            tb_soluong = new TextBox();
            tb_tensp = new TextBox();
            btn_xoaSP = new Button();
            btn_luuSP = new Button();
            tb_masp = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tb_khoangcao = new TextBox();
            tb_khoangthap = new TextBox();
            btn_trongkhoang = new Button();
            btn_quahan = new Button();
            btn_NhatBan = new Button();
            btn_caonhat = new Button();
            dgv_timkiem = new DataGridView();
            groupBox3 = new GroupBox();
            dgv_tatca = new DataGridView();
            groupBox4 = new GroupBox();
            lb_sphethan = new Label();
            tb_xuatxudexoa = new TextBox();
            btn_kiemtraquahan = new Button();
            btn_xoatoanboquahan = new Button();
            btn_xoatoanbo = new Button();
            btn_xoaXXbatki = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_timkiem).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_tatca).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_sua);
            groupBox1.Controls.Add(dtp_ngayhethan);
            groupBox1.Controls.Add(tb_xuatxu);
            groupBox1.Controls.Add(tb_dongia);
            groupBox1.Controls.Add(tb_soluong);
            groupBox1.Controls.Add(tb_tensp);
            groupBox1.Controls.Add(btn_xoaSP);
            groupBox1.Controls.Add(btn_luuSP);
            groupBox1.Controls.Add(tb_masp);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(6, 237);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(96, 31);
            btn_sua.TabIndex = 6;
            btn_sua.Text = "Sửa SP";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // dtp_ngayhethan
            // 
            dtp_ngayhethan.Location = new Point(109, 181);
            dtp_ngayhethan.Name = "dtp_ngayhethan";
            dtp_ngayhethan.Size = new Size(254, 23);
            dtp_ngayhethan.TabIndex = 3;
            // 
            // tb_xuatxu
            // 
            tb_xuatxu.Location = new Point(109, 152);
            tb_xuatxu.Name = "tb_xuatxu";
            tb_xuatxu.Size = new Size(254, 23);
            tb_xuatxu.TabIndex = 2;
            // 
            // tb_dongia
            // 
            tb_dongia.Location = new Point(109, 118);
            tb_dongia.Name = "tb_dongia";
            tb_dongia.Size = new Size(254, 23);
            tb_dongia.TabIndex = 2;
            // 
            // tb_soluong
            // 
            tb_soluong.Location = new Point(109, 84);
            tb_soluong.Name = "tb_soluong";
            tb_soluong.Size = new Size(254, 23);
            tb_soluong.TabIndex = 2;
            // 
            // tb_tensp
            // 
            tb_tensp.Location = new Point(109, 55);
            tb_tensp.Name = "tb_tensp";
            tb_tensp.Size = new Size(254, 23);
            tb_tensp.TabIndex = 2;
            // 
            // btn_xoaSP
            // 
            btn_xoaSP.Location = new Point(253, 237);
            btn_xoaSP.Name = "btn_xoaSP";
            btn_xoaSP.Size = new Size(110, 31);
            btn_xoaSP.TabIndex = 5;
            btn_xoaSP.Text = "Xóa SP";
            btn_xoaSP.UseVisualStyleBackColor = true;
            btn_xoaSP.Click += btn_xoaSP_Click;
            // 
            // btn_luuSP
            // 
            btn_luuSP.Location = new Point(120, 237);
            btn_luuSP.Name = "btn_luuSP";
            btn_luuSP.Size = new Size(110, 31);
            btn_luuSP.TabIndex = 5;
            btn_luuSP.Text = "Lưu SP";
            btn_luuSP.UseVisualStyleBackColor = true;
            btn_luuSP.Click += btn_luuSP_Click;
            // 
            // tb_masp
            // 
            tb_masp.Location = new Point(109, 27);
            tb_masp.Name = "tb_masp";
            tb_masp.Size = new Size(254, 23);
            tb_masp.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 189);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 1;
            label6.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 152);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 1;
            label5.Text = "Xuất xứ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 118);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 1;
            label4.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_khoangcao);
            groupBox2.Controls.Add(tb_khoangthap);
            groupBox2.Controls.Add(btn_trongkhoang);
            groupBox2.Controls.Add(btn_quahan);
            groupBox2.Controls.Add(btn_NhatBan);
            groupBox2.Controls.Add(btn_caonhat);
            groupBox2.Controls.Add(dgv_timkiem);
            groupBox2.Location = new Point(384, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 273);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chọn chức năng tìm kiếm";
            // 
            // tb_khoangcao
            // 
            tb_khoangcao.Location = new Point(539, 35);
            tb_khoangcao.Name = "tb_khoangcao";
            tb_khoangcao.Size = new Size(60, 23);
            tb_khoangcao.TabIndex = 6;
            // 
            // tb_khoangthap
            // 
            tb_khoangthap.Location = new Point(473, 35);
            tb_khoangthap.Name = "tb_khoangthap";
            tb_khoangthap.Size = new Size(60, 23);
            tb_khoangthap.TabIndex = 6;
            // 
            // btn_trongkhoang
            // 
            btn_trongkhoang.Location = new Point(337, 15);
            btn_trongkhoang.Name = "btn_trongkhoang";
            btn_trongkhoang.Size = new Size(116, 51);
            btn_trongkhoang.TabIndex = 5;
            btn_trongkhoang.Text = "Xuất các SP có đơn giá từ [a,..,b]";
            btn_trongkhoang.UseVisualStyleBackColor = true;
            btn_trongkhoang.Click += btn_trongkhoang_Click;
            // 
            // btn_quahan
            // 
            btn_quahan.Location = new Point(203, 16);
            btn_quahan.Name = "btn_quahan";
            btn_quahan.Size = new Size(92, 50);
            btn_quahan.TabIndex = 5;
            btn_quahan.Text = "Xuất toàn bộ SP quá hạn";
            btn_quahan.UseVisualStyleBackColor = true;
            btn_quahan.Click += btn_quahan_Click;
            // 
            // btn_NhatBan
            // 
            btn_NhatBan.Location = new Point(122, 16);
            btn_NhatBan.Name = "btn_NhatBan";
            btn_NhatBan.Size = new Size(75, 50);
            btn_NhatBan.TabIndex = 5;
            btn_NhatBan.Text = "1 SP từ Nhật Bản";
            btn_NhatBan.UseVisualStyleBackColor = true;
            btn_NhatBan.Click += btn_NhatBan_Click;
            // 
            // btn_caonhat
            // 
            btn_caonhat.Location = new Point(6, 16);
            btn_caonhat.Name = "btn_caonhat";
            btn_caonhat.Size = new Size(110, 50);
            btn_caonhat.TabIndex = 5;
            btn_caonhat.Text = "1 SP có Đơn giá cao nhất";
            btn_caonhat.UseVisualStyleBackColor = true;
            btn_caonhat.Click += btn_caonhat_Click;
            // 
            // dgv_timkiem
            // 
            dgv_timkiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_timkiem.Location = new Point(6, 72);
            dgv_timkiem.Name = "dgv_timkiem";
            dgv_timkiem.Size = new Size(612, 184);
            dgv_timkiem.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_tatca);
            groupBox3.Location = new Point(12, 281);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(696, 256);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // dgv_tatca
            // 
            dgv_tatca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_tatca.Location = new Point(6, 22);
            dgv_tatca.Name = "dgv_tatca";
            dgv_tatca.Size = new Size(684, 228);
            dgv_tatca.TabIndex = 4;
            dgv_tatca.CellClick += dgv_tatca_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lb_sphethan);
            groupBox4.Controls.Add(tb_xuatxudexoa);
            groupBox4.Controls.Add(btn_kiemtraquahan);
            groupBox4.Controls.Add(btn_xoatoanboquahan);
            groupBox4.Controls.Add(btn_xoatoanbo);
            groupBox4.Controls.Add(btn_xoaXXbatki);
            groupBox4.Location = new Point(714, 281);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(303, 256);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chọn thao tác";
            // 
            // lb_sphethan
            // 
            lb_sphethan.AutoSize = true;
            lb_sphethan.Location = new Point(123, 154);
            lb_sphethan.Name = "lb_sphethan";
            lb_sphethan.Size = new Size(0, 15);
            lb_sphethan.TabIndex = 7;
            // 
            // tb_xuatxudexoa
            // 
            tb_xuatxudexoa.Location = new Point(145, 37);
            tb_xuatxudexoa.Name = "tb_xuatxudexoa";
            tb_xuatxudexoa.Size = new Size(100, 23);
            tb_xuatxudexoa.TabIndex = 6;
            // 
            // btn_kiemtraquahan
            // 
            btn_kiemtraquahan.Location = new Point(6, 101);
            btn_kiemtraquahan.Name = "btn_kiemtraquahan";
            btn_kiemtraquahan.Size = new Size(282, 50);
            btn_kiemtraquahan.TabIndex = 5;
            btn_kiemtraquahan.Text = "Kiểm tra kho có sản phẩm nào quá hạn không";
            btn_kiemtraquahan.UseVisualStyleBackColor = true;
            btn_kiemtraquahan.Click += btn_kiemtraquahan_Click;
            // 
            // btn_xoatoanboquahan
            // 
            btn_xoatoanboquahan.Location = new Point(171, 179);
            btn_xoatoanboquahan.Name = "btn_xoatoanboquahan";
            btn_xoatoanboquahan.Size = new Size(110, 50);
            btn_xoatoanboquahan.TabIndex = 5;
            btn_xoatoanboquahan.Text = "Xóa toàn bộ SP quá hạn";
            btn_xoatoanboquahan.UseVisualStyleBackColor = true;
            btn_xoatoanboquahan.Click += btn_xoatoanboquahan_Click;
            // 
            // btn_xoatoanbo
            // 
            btn_xoatoanbo.Location = new Point(17, 179);
            btn_xoatoanbo.Name = "btn_xoatoanbo";
            btn_xoatoanbo.Size = new Size(110, 50);
            btn_xoatoanbo.TabIndex = 5;
            btn_xoatoanbo.Text = "Xóa toàn bộ SP trong kho";
            btn_xoatoanbo.UseVisualStyleBackColor = true;
            btn_xoatoanbo.Click += btn_xoatoanbo_Click;
            // 
            // btn_xoaXXbatki
            // 
            btn_xoaXXbatki.Location = new Point(6, 22);
            btn_xoaXXbatki.Name = "btn_xoaXXbatki";
            btn_xoaXXbatki.Size = new Size(110, 50);
            btn_xoaXXbatki.TabIndex = 5;
            btn_xoaXXbatki.Text = "Xóa SP Theo Xuất xứ bất kì";
            btn_xoaXXbatki.UseVisualStyleBackColor = true;
            btn_xoaXXbatki.Click += btn_xoaXXbatki_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 549);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Trang chủ";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_timkiem).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_tatca).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DateTimePicker dtp_ngayhethan;
        private TextBox tb_xuatxu;
        private TextBox tb_dongia;
        private TextBox tb_soluong;
        private TextBox tb_tensp;
        private TextBox tb_masp;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tb_khoangcao;
        private TextBox tb_khoangthap;
        private Button btn_trongkhoang;
        private Button btn_quahan;
        private Button btn_NhatBan;
        private Button btn_caonhat;
        private DataGridView dgv_timkiem;
        private DataGridView dgv_tatca;
        private TextBox tb_xuatxudexoa;
        private Button btn_kiemtraquahan;
        private Button btn_xoatoanboquahan;
        private Button btn_xoatoanbo;
        private Button btn_xoaXXbatki;
        private Button btn_xoaSP;
        private Button btn_luuSP;
        private Button btn_sua;
        private Label lb_sphethan;
    }
}
