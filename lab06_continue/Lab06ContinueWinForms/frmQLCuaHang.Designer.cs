namespace Lab06ContinueWinForms
{
    partial class frmQLCuaHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private ListView lvTonKho;
        private ColumnHeader colMaSP;
        private ColumnHeader colTenSP;
        private ColumnHeader colNgayTon;
        private ColumnHeader colSLDau;
        private ColumnHeader colSLNhap;
        private ColumnHeader colSLBan;
        private ColumnHeader colTonHienTai;
        private Label lblNgayMoi;
        private DateTimePicker dtpNgayMoi;
        private Button btnTaoTonKhoMoi;
        private Button btnThemSanPham;
        private Button btnBanHang;
        private Button btnLamMoi;
        private Button btnDong;

        private void InitializeComponent()
        {
            this.lvTonKho = new ListView();
            this.colMaSP = new ColumnHeader();
            this.colTenSP = new ColumnHeader();
            this.colNgayTon = new ColumnHeader();
            this.colSLDau = new ColumnHeader();
            this.colSLNhap = new ColumnHeader();
            this.colSLBan = new ColumnHeader();
            this.colTonHienTai = new ColumnHeader();
            this.lblNgayMoi = new Label();
            this.dtpNgayMoi = new DateTimePicker();
            this.btnTaoTonKhoMoi = new Button();
            this.btnThemSanPham = new Button();
            this.btnBanHang = new Button();
            this.btnLamMoi = new Button();
            this.btnDong = new Button();
            this.SuspendLayout();
            //
            // lvTonKho
            //
            this.lvTonKho.View = View.Details;
            this.lvTonKho.FullRowSelect = true;
            this.lvTonKho.GridLines = true;
            this.lvTonKho.Location = new Point(20, 20);
            this.lvTonKho.Name = "lvTonKho";
            this.lvTonKho.Size = new Size(620, 240);
            this.lvTonKho.Columns.AddRange(new ColumnHeader[] {
                this.colMaSP, this.colTenSP, this.colNgayTon, this.colSLDau, this.colSLNhap, this.colSLBan, this.colTonHienTai });
            //
            // colMaSP
            //
            this.colMaSP.Text = "Mã SP";
            this.colMaSP.Width = 55;
            //
            // colTenSP
            //
            this.colTenSP.Text = "Tên SP";
            this.colTenSP.Width = 140;
            //
            // colNgayTon
            //
            this.colNgayTon.Text = "Ngày tồn";
            this.colNgayTon.Width = 90;
            //
            // colSLDau
            //
            this.colSLDau.Text = "SL đầu";
            this.colSLDau.Width = 70;
            //
            // colSLNhap
            //
            this.colSLNhap.Text = "SL nhập";
            this.colSLNhap.Width = 70;
            //
            // colSLBan
            //
            this.colSLBan.Text = "SL bán";
            this.colSLBan.Width = 70;
            //
            // colTonHienTai
            //
            this.colTonHienTai.Text = "Tồn hiện tại";
            this.colTonHienTai.Width = 90;
            //
            // lblNgayMoi
            //
            this.lblNgayMoi.Location = new Point(20, 270);
            this.lblNgayMoi.Name = "lblNgayMoi";
            this.lblNgayMoi.Size = new Size(110, 26);
            this.lblNgayMoi.Text = "Ngày tạo mới";
            this.lblNgayMoi.TextAlign = ContentAlignment.MiddleLeft;
            //
            // dtpNgayMoi
            //
            this.dtpNgayMoi.Format = DateTimePickerFormat.Short;
            this.dtpNgayMoi.Location = new Point(130, 270);
            this.dtpNgayMoi.Name = "dtpNgayMoi";
            this.dtpNgayMoi.Size = new Size(120, 23);
            this.dtpNgayMoi.TabIndex = 0;
            //
            // btnTaoTonKhoMoi
            //
            this.btnTaoTonKhoMoi.Location = new Point(265, 268);
            this.btnTaoTonKhoMoi.Name = "btnTaoTonKhoMoi";
            this.btnTaoTonKhoMoi.Size = new Size(165, 28);
            this.btnTaoTonKhoMoi.TabIndex = 1;
            this.btnTaoTonKhoMoi.Text = "Tạo tồn kho ngày mới";
            this.btnTaoTonKhoMoi.UseVisualStyleBackColor = true;
            this.btnTaoTonKhoMoi.Click += new EventHandler(this.btnTaoTonKhoMoi_Click);
            //
            // btnThemSanPham
            //
            this.btnThemSanPham.Location = new Point(20, 310);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new Size(145, 32);
            this.btnThemSanPham.TabIndex = 2;
            this.btnThemSanPham.Text = "Thêm sản phẩm mới";
            this.btnThemSanPham.UseVisualStyleBackColor = true;
            this.btnThemSanPham.Click += new EventHandler(this.btnThemSanPham_Click);
            //
            // btnBanHang
            //
            this.btnBanHang.Location = new Point(175, 310);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new Size(145, 32);
            this.btnBanHang.TabIndex = 3;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new EventHandler(this.btnBanHang_Click);
            //
            // btnLamMoi
            //
            this.btnLamMoi.Location = new Point(330, 310);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new Size(145, 32);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new EventHandler(this.btnLamMoi_Click);
            //
            // btnDong
            //
            this.btnDong.Location = new Point(495, 310);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new Size(145, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new EventHandler(this.btnDong_Click);
            //
            // frmQLCuaHang
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(660, 365);
            this.Controls.Add(this.lvTonKho);
            this.Controls.Add(this.lblNgayMoi);
            this.Controls.Add(this.dtpNgayMoi);
            this.Controls.Add(this.btnTaoTonKhoMoi);
            this.Controls.Add(this.btnThemSanPham);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDong);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQLCuaHang";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý Cửa hàng - Tồn kho & Bán hàng";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
