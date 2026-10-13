namespace Lab04ContinueWinForms
{
    partial class frmBtvnKhachSan
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
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSoNgayO;
        private TextBox txtSoNgayO;

        private GroupBox grpLoaiPhong;
        private RadioButton rdoPhongDon;
        private RadioButton rdoPhongDoi;
        private RadioButton rdoPhongBa;

        private GroupBox grpTienNghi;
        private CheckBox chkTivi;
        private CheckBox chkInternet;
        private CheckBox chkMayNuocNong;

        private GroupBox grpDichVu;
        private CheckBox chkKaraoke;
        private CheckBox chkAnSang;

        private Button btnThanhToan;
        private Button btnNhapMoi;
        private Label lblThanhTien;
        private TextBox txtThanhTien;
        private Button btnTongKet;

        private GroupBox grpTongKet;
        private Label lblSoLuotNguoi;
        private TextBox txtSoLuotNguoi;
        private Label lblTongSoTien;
        private TextBox txtTongSoTien;

        private Button btnThoat;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblHoTen = new Label();
            this.txtHoTen = new TextBox();
            this.lblDiaChi = new Label();
            this.txtDiaChi = new TextBox();
            this.lblSoNgayO = new Label();
            this.txtSoNgayO = new TextBox();

            this.grpLoaiPhong = new GroupBox();
            this.rdoPhongDon = new RadioButton();
            this.rdoPhongDoi = new RadioButton();
            this.rdoPhongBa = new RadioButton();

            this.grpTienNghi = new GroupBox();
            this.chkTivi = new CheckBox();
            this.chkInternet = new CheckBox();
            this.chkMayNuocNong = new CheckBox();

            this.grpDichVu = new GroupBox();
            this.chkKaraoke = new CheckBox();
            this.chkAnSang = new CheckBox();

            this.btnThanhToan = new Button();
            this.btnNhapMoi = new Button();
            this.lblThanhTien = new Label();
            this.txtThanhTien = new TextBox();
            this.btnTongKet = new Button();

            this.grpTongKet = new GroupBox();
            this.lblSoLuotNguoi = new Label();
            this.txtSoLuotNguoi = new TextBox();
            this.lblTongSoTien = new Label();
            this.txtTongSoTien = new TextBox();

            this.btnThoat = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpLoaiPhong.SuspendLayout();
            this.grpTienNghi.SuspendLayout();
            this.grpDichVu.SuspendLayout();
            this.grpTongKet.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.OrangeRed;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(580, 30);
            this.lblTieuDe.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new Point(20, 60);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(90, 23);
            this.lblHoTen.Text = "Họ và tên:";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new Point(115, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new Size(280, 23);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.TextChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // lblDiaChi
            //
            this.lblDiaChi.Location = new Point(20, 90);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new Size(90, 23);
            this.lblDiaChi.Text = "Địa chỉ:";
            //
            // txtDiaChi
            //
            this.txtDiaChi.Location = new Point(115, 87);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new Size(280, 23);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.TextChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // lblSoNgayO
            //
            this.lblSoNgayO.Location = new Point(20, 120);
            this.lblSoNgayO.Name = "lblSoNgayO";
            this.lblSoNgayO.Size = new Size(90, 23);
            this.lblSoNgayO.Text = "Số ngày ở:";
            //
            // txtSoNgayO
            //
            this.txtSoNgayO.Location = new Point(115, 117);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new Size(80, 23);
            this.txtSoNgayO.TabIndex = 2;
            this.txtSoNgayO.KeyPress += new KeyPressEventHandler(this.txtSoNgayO_KeyPress);
            this.txtSoNgayO.TextChanged += new EventHandler(this.DuLieuThayDoi);
            //
            // grpLoaiPhong
            //
            this.grpLoaiPhong.Controls.Add(this.rdoPhongDon);
            this.grpLoaiPhong.Controls.Add(this.rdoPhongDoi);
            this.grpLoaiPhong.Controls.Add(this.rdoPhongBa);
            this.grpLoaiPhong.Location = new Point(20, 150);
            this.grpLoaiPhong.Name = "grpLoaiPhong";
            this.grpLoaiPhong.Size = new Size(215, 110);
            this.grpLoaiPhong.TabStop = false;
            this.grpLoaiPhong.Text = "Loại phòng";
            //
            // rdoPhongDon
            //
            this.rdoPhongDon.Checked = true;
            this.rdoPhongDon.Location = new Point(10, 22);
            this.rdoPhongDon.Name = "rdoPhongDon";
            this.rdoPhongDon.Size = new Size(150, 24);
            this.rdoPhongDon.TabIndex = 0;
            this.rdoPhongDon.Text = "Phòng đơn";
            this.rdoPhongDon.UseVisualStyleBackColor = true;
            //
            // rdoPhongDoi
            //
            this.rdoPhongDoi.Location = new Point(10, 50);
            this.rdoPhongDoi.Name = "rdoPhongDoi";
            this.rdoPhongDoi.Size = new Size(150, 24);
            this.rdoPhongDoi.TabIndex = 1;
            this.rdoPhongDoi.Text = "Phòng đôi";
            this.rdoPhongDoi.UseVisualStyleBackColor = true;
            //
            // rdoPhongBa
            //
            this.rdoPhongBa.Location = new Point(10, 78);
            this.rdoPhongBa.Name = "rdoPhongBa";
            this.rdoPhongBa.Size = new Size(150, 24);
            this.rdoPhongBa.TabIndex = 2;
            this.rdoPhongBa.Text = "Phòng ba";
            this.rdoPhongBa.UseVisualStyleBackColor = true;
            //
            // grpTienNghi
            //
            this.grpTienNghi.Controls.Add(this.chkTivi);
            this.grpTienNghi.Controls.Add(this.chkInternet);
            this.grpTienNghi.Controls.Add(this.chkMayNuocNong);
            this.grpTienNghi.Location = new Point(245, 150);
            this.grpTienNghi.Name = "grpTienNghi";
            this.grpTienNghi.Size = new Size(150, 110);
            this.grpTienNghi.TabStop = false;
            this.grpTienNghi.Text = "Tiện nghi";
            //
            // chkTivi
            //
            this.chkTivi.Location = new Point(10, 22);
            this.chkTivi.Name = "chkTivi";
            this.chkTivi.Size = new Size(120, 24);
            this.chkTivi.TabIndex = 0;
            this.chkTivi.Text = "Tivi";
            this.chkTivi.UseVisualStyleBackColor = true;
            //
            // chkInternet
            //
            this.chkInternet.Location = new Point(10, 50);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new Size(120, 24);
            this.chkInternet.TabIndex = 1;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = true;
            //
            // chkMayNuocNong
            //
            this.chkMayNuocNong.Location = new Point(10, 78);
            this.chkMayNuocNong.Name = "chkMayNuocNong";
            this.chkMayNuocNong.Size = new Size(135, 24);
            this.chkMayNuocNong.TabIndex = 2;
            this.chkMayNuocNong.Text = "Máy nước nóng";
            this.chkMayNuocNong.UseVisualStyleBackColor = true;
            //
            // grpDichVu
            //
            this.grpDichVu.Controls.Add(this.chkKaraoke);
            this.grpDichVu.Controls.Add(this.chkAnSang);
            this.grpDichVu.Location = new Point(20, 270);
            this.grpDichVu.Name = "grpDichVu";
            this.grpDichVu.Size = new Size(215, 80);
            this.grpDichVu.TabStop = false;
            this.grpDichVu.Text = "Dịch vụ";
            //
            // chkKaraoke
            //
            this.chkKaraoke.Location = new Point(10, 22);
            this.chkKaraoke.Name = "chkKaraoke";
            this.chkKaraoke.Size = new Size(150, 24);
            this.chkKaraoke.TabIndex = 0;
            this.chkKaraoke.Text = "Karaoke";
            this.chkKaraoke.UseVisualStyleBackColor = true;
            //
            // chkAnSang
            //
            this.chkAnSang.Location = new Point(10, 50);
            this.chkAnSang.Name = "chkAnSang";
            this.chkAnSang.Size = new Size(150, 24);
            this.chkAnSang.TabIndex = 1;
            this.chkAnSang.Text = "Ăn sáng";
            this.chkAnSang.UseVisualStyleBackColor = true;
            //
            // btnThanhToan
            //
            this.btnThanhToan.Enabled = false;
            this.btnThanhToan.Location = new Point(410, 60);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new Size(90, 30);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new EventHandler(this.btnThanhToan_Click);
            //
            // btnNhapMoi
            //
            this.btnNhapMoi.Enabled = false;
            this.btnNhapMoi.Location = new Point(505, 60);
            this.btnNhapMoi.Name = "btnNhapMoi";
            this.btnNhapMoi.Size = new Size(90, 30);
            this.btnNhapMoi.TabIndex = 4;
            this.btnNhapMoi.Text = "Nhập mới";
            this.btnNhapMoi.UseVisualStyleBackColor = true;
            this.btnNhapMoi.Click += new EventHandler(this.btnNhapMoi_Click);
            //
            // lblThanhTien
            //
            this.lblThanhTien.Location = new Point(410, 100);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new Size(80, 23);
            this.lblThanhTien.Text = "Thành tiền:";
            //
            // txtThanhTien
            //
            this.txtThanhTien.Location = new Point(410, 123);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new Size(185, 23);
            this.txtThanhTien.TabStop = false;
            //
            // btnTongKet
            //
            this.btnTongKet.Enabled = false;
            this.btnTongKet.Location = new Point(410, 160);
            this.btnTongKet.Name = "btnTongKet";
            this.btnTongKet.Size = new Size(185, 30);
            this.btnTongKet.TabIndex = 5;
            this.btnTongKet.Text = "Tổng Kết";
            this.btnTongKet.UseVisualStyleBackColor = true;
            this.btnTongKet.Click += new EventHandler(this.btnTongKet_Click);
            //
            // grpTongKet
            //
            this.grpTongKet.Controls.Add(this.lblSoLuotNguoi);
            this.grpTongKet.Controls.Add(this.txtSoLuotNguoi);
            this.grpTongKet.Controls.Add(this.lblTongSoTien);
            this.grpTongKet.Controls.Add(this.txtTongSoTien);
            this.grpTongKet.Location = new Point(410, 200);
            this.grpTongKet.Name = "grpTongKet";
            this.grpTongKet.Size = new Size(185, 120);
            this.grpTongKet.TabStop = false;
            this.grpTongKet.Text = "Thông tin tổng kết";
            //
            // lblSoLuotNguoi
            //
            this.lblSoLuotNguoi.Location = new Point(10, 20);
            this.lblSoLuotNguoi.Name = "lblSoLuotNguoi";
            this.lblSoLuotNguoi.Size = new Size(160, 20);
            this.lblSoLuotNguoi.Text = "Số lượt người:";
            //
            // txtSoLuotNguoi
            //
            this.txtSoLuotNguoi.Location = new Point(10, 42);
            this.txtSoLuotNguoi.Name = "txtSoLuotNguoi";
            this.txtSoLuotNguoi.ReadOnly = true;
            this.txtSoLuotNguoi.Size = new Size(160, 23);
            this.txtSoLuotNguoi.TabStop = false;
            //
            // lblTongSoTien
            //
            this.lblTongSoTien.Location = new Point(10, 70);
            this.lblTongSoTien.Name = "lblTongSoTien";
            this.lblTongSoTien.Size = new Size(160, 20);
            this.lblTongSoTien.Text = "Tổng số tiền:";
            //
            // txtTongSoTien
            //
            this.txtTongSoTien.Location = new Point(10, 92);
            this.txtTongSoTien.Name = "txtTongSoTien";
            this.txtTongSoTien.ReadOnly = true;
            this.txtTongSoTien.Size = new Size(160, 23);
            this.txtTongSoTien.TabStop = false;
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(410, 330);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(185, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmBtvnKhachSan
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(620, 385);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblSoNgayO);
            this.Controls.Add(this.txtSoNgayO);
            this.Controls.Add(this.grpLoaiPhong);
            this.Controls.Add(this.grpTienNghi);
            this.Controls.Add(this.grpDichVu);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnNhapMoi);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnTongKet);
            this.Controls.Add(this.grpTongKet);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBtvnKhachSan";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmDangkyKS";
            this.Load += new EventHandler(this.frmBtvnKhachSan_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmBtvnKhachSan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpLoaiPhong.ResumeLayout(false);
            this.grpTienNghi.ResumeLayout(false);
            this.grpDichVu.ResumeLayout(false);
            this.grpTongKet.ResumeLayout(false);
            this.grpTongKet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
