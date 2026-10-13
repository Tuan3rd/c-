namespace Lab04ContinueWinForms
{
    partial class frmNangCaoCafeSinhVien
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
        private Label lblTenKhachHang;
        private TextBox txtTenKhachHang;
        private Label lblSoKhachHang;
        private TextBox txtSoKhachHang;
        private CheckBox chkSinhVien;

        private GroupBox grpNuocUong;
        private RadioButton rdoCafeDen;
        private RadioButton rdoCafeDa;
        private RadioButton rdoCafeSua;
        private RadioButton rdoCafeSuaDa;
        private RadioButton rdoCafeKem;

        private GroupBox grpThucAn;
        private CheckBox chkBanhMyTrung;
        private CheckBox chkMyXaoBo;
        private CheckBox chkBanhMyCa;
        private CheckBox chkMyCay;
        private CheckBox chkMyTomTrung;

        private Button btnTinhTien;
        private Button btnNhapLai;
        private Button btnThanhToan;
        private Button btnThoat;
        private Label lblTongKhachHang;
        private TextBox txtTongKhachHang;
        private Label lblTongTienThanhToan;
        private TextBox txtTongTienThanhToan;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblTenKhachHang = new Label();
            this.txtTenKhachHang = new TextBox();
            this.lblSoKhachHang = new Label();
            this.txtSoKhachHang = new TextBox();
            this.chkSinhVien = new CheckBox();

            this.grpNuocUong = new GroupBox();
            this.rdoCafeDen = new RadioButton();
            this.rdoCafeDa = new RadioButton();
            this.rdoCafeSua = new RadioButton();
            this.rdoCafeSuaDa = new RadioButton();
            this.rdoCafeKem = new RadioButton();

            this.grpThucAn = new GroupBox();
            this.chkBanhMyTrung = new CheckBox();
            this.chkMyXaoBo = new CheckBox();
            this.chkBanhMyCa = new CheckBox();
            this.chkMyCay = new CheckBox();
            this.chkMyTomTrung = new CheckBox();

            this.btnTinhTien = new Button();
            this.btnNhapLai = new Button();
            this.btnThanhToan = new Button();
            this.btnThoat = new Button();
            this.lblTongKhachHang = new Label();
            this.txtTongKhachHang = new TextBox();
            this.lblTongTienThanhToan = new Label();
            this.txtTongTienThanhToan = new TextBox();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpNuocUong.SuspendLayout();
            this.grpThucAn.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.Orange;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(460, 30);
            this.lblTieuDe.Text = "CAFE SINH VIÊN";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTenKhachHang
            //
            this.lblTenKhachHang.Location = new Point(20, 60);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new Size(110, 23);
            this.lblTenKhachHang.Text = "Tên khách hàng";
            //
            // txtTenKhachHang
            //
            this.txtTenKhachHang.Location = new Point(140, 57);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new Size(320, 23);
            this.txtTenKhachHang.TabIndex = 0;
            this.txtTenKhachHang.TextChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // lblSoKhachHang
            //
            this.lblSoKhachHang.Location = new Point(20, 90);
            this.lblSoKhachHang.Name = "lblSoKhachHang";
            this.lblSoKhachHang.Size = new Size(110, 23);
            this.lblSoKhachHang.Text = "Số khách hàng";
            //
            // txtSoKhachHang
            //
            this.txtSoKhachHang.Location = new Point(140, 87);
            this.txtSoKhachHang.Name = "txtSoKhachHang";
            this.txtSoKhachHang.Size = new Size(320, 23);
            this.txtSoKhachHang.TabIndex = 1;
            this.txtSoKhachHang.KeyPress += new KeyPressEventHandler(this.txtSoKhachHang_KeyPress);
            //
            // chkSinhVien
            //
            this.chkSinhVien.Location = new Point(190, 118);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new Size(120, 24);
            this.chkSinhVien.TabIndex = 2;
            this.chkSinhVien.Text = "Sinh viên ?";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            //
            // grpNuocUong
            //
            this.grpNuocUong.Controls.Add(this.rdoCafeDen);
            this.grpNuocUong.Controls.Add(this.rdoCafeDa);
            this.grpNuocUong.Controls.Add(this.rdoCafeSua);
            this.grpNuocUong.Controls.Add(this.rdoCafeSuaDa);
            this.grpNuocUong.Controls.Add(this.rdoCafeKem);
            this.grpNuocUong.Location = new Point(20, 150);
            this.grpNuocUong.Name = "grpNuocUong";
            this.grpNuocUong.Size = new Size(220, 130);
            this.grpNuocUong.TabStop = false;
            this.grpNuocUong.Text = "Nước uống";
            //
            // rdoCafeDen
            //
            this.rdoCafeDen.Location = new Point(10, 25);
            this.rdoCafeDen.Name = "rdoCafeDen";
            this.rdoCafeDen.Size = new Size(100, 24);
            this.rdoCafeDen.TabIndex = 0;
            this.rdoCafeDen.Text = "Cafe đen";
            this.rdoCafeDen.UseVisualStyleBackColor = true;
            this.rdoCafeDen.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // rdoCafeDa
            //
            this.rdoCafeDa.Location = new Point(115, 25);
            this.rdoCafeDa.Name = "rdoCafeDa";
            this.rdoCafeDa.Size = new Size(95, 24);
            this.rdoCafeDa.TabIndex = 1;
            this.rdoCafeDa.Text = "Cafe đá";
            this.rdoCafeDa.UseVisualStyleBackColor = true;
            this.rdoCafeDa.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // rdoCafeSua
            //
            this.rdoCafeSua.Location = new Point(10, 55);
            this.rdoCafeSua.Name = "rdoCafeSua";
            this.rdoCafeSua.Size = new Size(100, 24);
            this.rdoCafeSua.TabIndex = 2;
            this.rdoCafeSua.Text = "Cafe sữa";
            this.rdoCafeSua.UseVisualStyleBackColor = true;
            this.rdoCafeSua.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // rdoCafeSuaDa
            //
            this.rdoCafeSuaDa.Location = new Point(115, 55);
            this.rdoCafeSuaDa.Name = "rdoCafeSuaDa";
            this.rdoCafeSuaDa.Size = new Size(95, 24);
            this.rdoCafeSuaDa.TabIndex = 3;
            this.rdoCafeSuaDa.Text = "Cafe sữa đá";
            this.rdoCafeSuaDa.UseVisualStyleBackColor = true;
            this.rdoCafeSuaDa.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // rdoCafeKem
            //
            this.rdoCafeKem.Location = new Point(10, 85);
            this.rdoCafeKem.Name = "rdoCafeKem";
            this.rdoCafeKem.Size = new Size(100, 24);
            this.rdoCafeKem.TabIndex = 4;
            this.rdoCafeKem.Text = "Cafe kem";
            this.rdoCafeKem.UseVisualStyleBackColor = true;
            this.rdoCafeKem.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // grpThucAn
            //
            this.grpThucAn.Controls.Add(this.chkBanhMyTrung);
            this.grpThucAn.Controls.Add(this.chkMyXaoBo);
            this.grpThucAn.Controls.Add(this.chkBanhMyCa);
            this.grpThucAn.Controls.Add(this.chkMyCay);
            this.grpThucAn.Controls.Add(this.chkMyTomTrung);
            this.grpThucAn.Location = new Point(255, 150);
            this.grpThucAn.Name = "grpThucAn";
            this.grpThucAn.Size = new Size(225, 130);
            this.grpThucAn.TabStop = false;
            this.grpThucAn.Text = "Thức ăn";
            //
            // chkBanhMyTrung
            //
            this.chkBanhMyTrung.Location = new Point(10, 25);
            this.chkBanhMyTrung.Name = "chkBanhMyTrung";
            this.chkBanhMyTrung.Size = new Size(120, 24);
            this.chkBanhMyTrung.TabIndex = 0;
            this.chkBanhMyTrung.Text = "Bánh mỳ trứng";
            this.chkBanhMyTrung.UseVisualStyleBackColor = true;
            this.chkBanhMyTrung.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // chkMyXaoBo
            //
            this.chkMyXaoBo.Location = new Point(135, 25);
            this.chkMyXaoBo.Name = "chkMyXaoBo";
            this.chkMyXaoBo.Size = new Size(85, 24);
            this.chkMyXaoBo.TabIndex = 1;
            this.chkMyXaoBo.Text = "Mỳ xào bò";
            this.chkMyXaoBo.UseVisualStyleBackColor = true;
            this.chkMyXaoBo.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // chkBanhMyCa
            //
            this.chkBanhMyCa.Location = new Point(10, 55);
            this.chkBanhMyCa.Name = "chkBanhMyCa";
            this.chkBanhMyCa.Size = new Size(120, 24);
            this.chkBanhMyCa.TabIndex = 2;
            this.chkBanhMyCa.Text = "Bánh mỳ cá";
            this.chkBanhMyCa.UseVisualStyleBackColor = true;
            this.chkBanhMyCa.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // chkMyCay
            //
            this.chkMyCay.Location = new Point(135, 55);
            this.chkMyCay.Name = "chkMyCay";
            this.chkMyCay.Size = new Size(85, 24);
            this.chkMyCay.TabIndex = 3;
            this.chkMyCay.Text = "Mỳ cay";
            this.chkMyCay.UseVisualStyleBackColor = true;
            this.chkMyCay.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // chkMyTomTrung
            //
            this.chkMyTomTrung.Location = new Point(10, 85);
            this.chkMyTomTrung.Name = "chkMyTomTrung";
            this.chkMyTomTrung.Size = new Size(120, 24);
            this.chkMyTomTrung.TabIndex = 4;
            this.chkMyTomTrung.Text = "Mỳ tôm trứng";
            this.chkMyTomTrung.UseVisualStyleBackColor = true;
            this.chkMyTomTrung.CheckedChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // btnTinhTien
            //
            this.btnTinhTien.Enabled = false;
            this.btnTinhTien.Location = new Point(20, 295);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new Size(105, 32);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new EventHandler(this.btnTinhTien_Click);
            //
            // btnNhapLai
            //
            this.btnNhapLai.Enabled = false;
            this.btnNhapLai.Location = new Point(135, 295);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new Size(105, 32);
            this.btnNhapLai.TabIndex = 6;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new EventHandler(this.btnNhapLai_Click);
            //
            // btnThanhToan
            //
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new Point(250, 295);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new Size(105, 32);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new EventHandler(this.btnThanhToan_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(365, 295);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(105, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // lblTongKhachHang
            //
            this.lblTongKhachHang.Location = new Point(20, 340);
            this.lblTongKhachHang.Name = "lblTongKhachHang";
            this.lblTongKhachHang.Size = new Size(120, 23);
            this.lblTongKhachHang.Text = "Tổng khách hàng";
            //
            // txtTongKhachHang
            //
            this.txtTongKhachHang.Location = new Point(150, 337);
            this.txtTongKhachHang.Name = "txtTongKhachHang";
            this.txtTongKhachHang.ReadOnly = true;
            this.txtTongKhachHang.Size = new Size(310, 23);
            this.txtTongKhachHang.TabStop = false;
            //
            // lblTongTienThanhToan
            //
            this.lblTongTienThanhToan.Location = new Point(20, 370);
            this.lblTongTienThanhToan.Name = "lblTongTienThanhToan";
            this.lblTongTienThanhToan.Size = new Size(120, 23);
            this.lblTongTienThanhToan.Text = "Tổng tiền thanh toán";
            //
            // txtTongTienThanhToan
            //
            this.txtTongTienThanhToan.Location = new Point(150, 367);
            this.txtTongTienThanhToan.Name = "txtTongTienThanhToan";
            this.txtTongTienThanhToan.ReadOnly = true;
            this.txtTongTienThanhToan.Size = new Size(310, 23);
            this.txtTongTienThanhToan.TabStop = false;
            //
            // frmNangCaoCafeSinhVien
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 410);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTenKhachHang);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblSoKhachHang);
            this.Controls.Add(this.txtSoKhachHang);
            this.Controls.Add(this.chkSinhVien);
            this.Controls.Add(this.grpNuocUong);
            this.Controls.Add(this.grpThucAn);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTongKhachHang);
            this.Controls.Add(this.txtTongKhachHang);
            this.Controls.Add(this.lblTongTienThanhToan);
            this.Controls.Add(this.txtTongTienThanhToan);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNangCaoCafeSinhVien";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Thanh toán tiền";
            this.Load += new EventHandler(this.frmNangCaoCafeSinhVien_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmNangCaoCafeSinhVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpNuocUong.ResumeLayout(false);
            this.grpThucAn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
