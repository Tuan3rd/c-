namespace Lab06ContinueWinForms
{
    partial class frmBanHang
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

        private Label lblSanPham;
        private ComboBox cboSanPham;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Button btnThemChiTiet;
        private ListView lvChiTiet;
        private ColumnHeader colMaSP;
        private ColumnHeader colTenSP;
        private ColumnHeader colSoLuong;
        private Button btnThanhToan;
        private Button btnHuy;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSanPham = new Label();
            this.cboSanPham = new ComboBox();
            this.lblSoLuong = new Label();
            this.txtSoLuong = new TextBox();
            this.btnThemChiTiet = new Button();
            this.lvChiTiet = new ListView();
            this.colMaSP = new ColumnHeader();
            this.colTenSP = new ColumnHeader();
            this.colSoLuong = new ColumnHeader();
            this.btnThanhToan = new Button();
            this.btnHuy = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblSanPham
            //
            this.lblSanPham.Location = new Point(20, 20);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new Size(80, 23);
            this.lblSanPham.Text = "Sản phẩm";
            //
            // cboSanPham
            //
            this.cboSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboSanPham.Location = new Point(105, 17);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new Size(200, 23);
            this.cboSanPham.TabIndex = 0;
            //
            // lblSoLuong
            //
            this.lblSoLuong.Location = new Point(315, 20);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new Size(70, 23);
            this.lblSoLuong.Text = "Số lượng";
            //
            // txtSoLuong
            //
            this.txtSoLuong.Location = new Point(390, 17);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new Size(80, 23);
            this.txtSoLuong.TabIndex = 1;
            //
            // btnThemChiTiet
            //
            this.btnThemChiTiet.Location = new Point(480, 16);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new Size(110, 26);
            this.btnThemChiTiet.TabIndex = 2;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new EventHandler(this.btnThemChiTiet_Click);
            //
            // lvChiTiet
            //
            this.lvChiTiet.View = View.Details;
            this.lvChiTiet.FullRowSelect = true;
            this.lvChiTiet.GridLines = true;
            this.lvChiTiet.Location = new Point(20, 55);
            this.lvChiTiet.Name = "lvChiTiet";
            this.lvChiTiet.Size = new Size(570, 200);
            this.lvChiTiet.Columns.AddRange(new ColumnHeader[] {
                this.colMaSP, this.colTenSP, this.colSoLuong });
            //
            // colMaSP
            //
            this.colMaSP.Text = "Mã SP";
            this.colMaSP.Width = 70;
            //
            // colTenSP
            //
            this.colTenSP.Text = "Tên SP";
            this.colTenSP.Width = 260;
            //
            // colSoLuong
            //
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 100;
            //
            // btnThanhToan
            //
            this.btnThanhToan.Location = new Point(300, 265);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new Size(140, 32);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new EventHandler(this.btnThanhToan_Click);
            //
            // btnHuy
            //
            this.btnHuy.Location = new Point(450, 265);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new Size(140, 32);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new EventHandler(this.btnHuy_Click);
            //
            // frmBanHang
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(610, 315);
            this.Controls.Add(this.lblSanPham);
            this.Controls.Add(this.cboSanPham);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnThemChiTiet);
            this.Controls.Add(this.lvChiTiet);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnHuy);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBanHang";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bán hàng - Tạo hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
