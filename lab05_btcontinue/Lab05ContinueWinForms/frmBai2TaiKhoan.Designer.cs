namespace Lab05ContinueWinForms
{
    partial class frmBai2TaiKhoan
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

        private Label lblTieuDe;
        private Label lblSoTaiKhoan;
        private TextBox txtSoTaiKhoan;
        private Label lblTenKhachHang;
        private TextBox txtTenKhachHang;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSoTien;
        private TextBox txtSoTien;
        private Button btnThem;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnThoat;

        private ListView lstv1;
        private ColumnHeader colStt;
        private ColumnHeader colSoTaiKhoan;
        private ColumnHeader colTenKhachHang;
        private ColumnHeader colDiaChi;
        private ColumnHeader colSoTien;

        private Label lblTongTienCaption;
        private TextBox txtTongTien;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblSoTaiKhoan = new Label();
            this.txtSoTaiKhoan = new TextBox();
            this.lblTenKhachHang = new Label();
            this.txtTenKhachHang = new TextBox();
            this.lblDiaChi = new Label();
            this.txtDiaChi = new TextBox();
            this.lblSoTien = new Label();
            this.txtSoTien = new TextBox();
            this.btnThem = new Button();
            this.btnLuu = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();

            this.lstv1 = new ListView();
            this.colStt = new ColumnHeader();
            this.colSoTaiKhoan = new ColumnHeader();
            this.colTenKhachHang = new ColumnHeader();
            this.colDiaChi = new ColumnHeader();
            this.colSoTien = new ColumnHeader();

            this.lblTongTienCaption = new Label();
            this.txtTongTien = new TextBox();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.Blue;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(610, 34);
            this.lblTieuDe.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblSoTaiKhoan
            //
            this.lblSoTaiKhoan.Location = new Point(140, 62);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new Size(160, 23);
            this.lblSoTaiKhoan.Text = "Số tài khoản";
            this.lblSoTaiKhoan.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtSoTaiKhoan
            //
            this.txtSoTaiKhoan.Location = new Point(310, 59);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new Size(260, 23);
            this.txtSoTaiKhoan.TabIndex = 0;
            //
            // lblTenKhachHang
            //
            this.lblTenKhachHang.Location = new Point(140, 92);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new Size(160, 23);
            this.lblTenKhachHang.Text = "Tên khách hàng";
            this.lblTenKhachHang.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtTenKhachHang
            //
            this.txtTenKhachHang.Location = new Point(310, 89);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new Size(260, 23);
            this.txtTenKhachHang.TabIndex = 1;
            //
            // lblDiaChi
            //
            this.lblDiaChi.Location = new Point(140, 122);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new Size(160, 23);
            this.lblDiaChi.Text = "Địa chỉ khách hàng";
            this.lblDiaChi.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtDiaChi
            //
            this.txtDiaChi.Location = new Point(310, 119);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new Size(260, 23);
            this.txtDiaChi.TabIndex = 2;
            //
            // lblSoTien
            //
            this.lblSoTien.Location = new Point(110, 152);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new Size(190, 23);
            this.lblSoTien.Text = "Số tiền trong tài khoản";
            this.lblSoTien.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtSoTien
            //
            this.txtSoTien.Location = new Point(310, 149);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new Size(260, 23);
            this.txtSoTien.TabIndex = 3;
            //
            // btnThem
            //
            this.btnThem.Location = new Point(230, 188);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(75, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnLuu
            //
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new Point(315, 188);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new Size(75, 30);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new EventHandler(this.btnLuu_Click);
            //
            // btnXoa
            //
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new Point(400, 188);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(75, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(485, 188);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(75, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // lstv1
            //
            this.lstv1.Columns.AddRange(new ColumnHeader[] {
                this.colStt, this.colSoTaiKhoan, this.colTenKhachHang, this.colDiaChi, this.colSoTien });
            this.lstv1.FullRowSelect = true;
            this.lstv1.GridLines = true;
            this.lstv1.Location = new Point(20, 230);
            this.lstv1.MultiSelect = false;
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new Size(610, 195);
            this.lstv1.TabIndex = 8;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = View.Details;
            this.lstv1.SelectedIndexChanged += new EventHandler(this.lstv1_SelectedIndexChanged);
            //
            // colStt
            //
            this.colStt.Text = "STT";
            this.colStt.Width = 45;
            //
            // colSoTaiKhoan
            //
            this.colSoTaiKhoan.Text = "Số tài khoản";
            this.colSoTaiKhoan.Width = 110;
            //
            // colTenKhachHang
            //
            this.colTenKhachHang.Text = "Tên khách hàng";
            this.colTenKhachHang.Width = 150;
            //
            // colDiaChi
            //
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 110;
            //
            // colSoTien
            //
            this.colSoTien.Text = "Số tiền";
            this.colSoTien.Width = 110;
            this.colSoTien.TextAlign = HorizontalAlignment.Right;
            //
            // lblTongTienCaption
            //
            this.lblTongTienCaption.Location = new Point(390, 435);
            this.lblTongTienCaption.Name = "lblTongTienCaption";
            this.lblTongTienCaption.Size = new Size(100, 23);
            this.lblTongTienCaption.Text = "Tổng tiền";
            this.lblTongTienCaption.TextAlign = ContentAlignment.MiddleRight;
            //
            // txtTongTien
            //
            this.txtTongTien.Location = new Point(495, 432);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new Size(135, 23);
            this.txtTongTien.TabStop = false;
            this.txtTongTien.TextAlign = HorizontalAlignment.Right;
            //
            // frmBai2TaiKhoan
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(650, 475);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblSoTaiKhoan);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lstv1);
            this.Controls.Add(this.lblTongTienCaption);
            this.Controls.Add(this.txtTongTien);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai2TaiKhoan";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmBaiTap2";
            this.FormClosing += new FormClosingEventHandler(this.frmBai2TaiKhoan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
