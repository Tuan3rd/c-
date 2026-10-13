namespace Lab06ContinueWinForms
{
    partial class frmMain
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
        private Label lblThongTin;
        private Button btnMauKhoa;
        private Button btnTaiLopLop;
        private Button btnDanhSachLop;
        private Button btnNangCaoSinhVien;
        private Button btnNangCaoDiem;
        private Button btnDanhSachDiem;
        private Button btnVeNhaCuaHang;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.btnMauKhoa = new Button();
            this.btnTaiLopLop = new Button();
            this.btnDanhSachLop = new Button();
            this.btnNangCaoSinhVien = new Button();
            this.btnNangCaoDiem = new Button();
            this.btnDanhSachDiem = new Button();
            this.btnVeNhaCuaHang = new Button();
            this.btnThoat = new Button();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkGreen;
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(420, 30);
            this.lblTieuDe.Text = "LAB 06 CONTINUE - TƯƠNG TÁC CSDL {2}";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblThongTin
            //
            this.lblThongTin.Font = new Font("Tahoma", 9F);
            this.lblThongTin.Location = new Point(20, 54);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new Size(420, 22);
            this.lblThongTin.Text = "Họ tên: Thái Tuấn - MSSV: 3123411327";
            this.lblThongTin.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnMauKhoa
            //
            this.btnMauKhoa.Location = new Point(40, 95);
            this.btnMauKhoa.Name = "btnMauKhoa";
            this.btnMauKhoa.Size = new Size(380, 32);
            this.btnMauKhoa.TabIndex = 0;
            this.btnMauKhoa.Text = "Mẫu - Quản lý Khoa";
            this.btnMauKhoa.UseVisualStyleBackColor = true;
            this.btnMauKhoa.Click += new EventHandler(this.btnMauKhoa_Click);
            //
            // btnTaiLopLop
            //
            this.btnTaiLopLop.Location = new Point(40, 130);
            this.btnTaiLopLop.Name = "btnTaiLopLop";
            this.btnTaiLopLop.Size = new Size(380, 32);
            this.btnTaiLopLop.TabIndex = 1;
            this.btnTaiLopLop.Text = "Tại lớp - Quản lý Lớp";
            this.btnTaiLopLop.UseVisualStyleBackColor = true;
            this.btnTaiLopLop.Click += new EventHandler(this.btnTaiLopLop_Click);
            //
            // btnDanhSachLop
            //
            this.btnDanhSachLop.Location = new Point(40, 165);
            this.btnDanhSachLop.Name = "btnDanhSachLop";
            this.btnDanhSachLop.Size = new Size(380, 32);
            this.btnDanhSachLop.TabIndex = 2;
            this.btnDanhSachLop.Text = "Tại lớp - Danh sách Lớp (ListView)";
            this.btnDanhSachLop.UseVisualStyleBackColor = true;
            this.btnDanhSachLop.Click += new EventHandler(this.btnDanhSachLop_Click);
            //
            // btnNangCaoSinhVien
            //
            this.btnNangCaoSinhVien.Location = new Point(40, 200);
            this.btnNangCaoSinhVien.Name = "btnNangCaoSinhVien";
            this.btnNangCaoSinhVien.Size = new Size(380, 32);
            this.btnNangCaoSinhVien.TabIndex = 3;
            this.btnNangCaoSinhVien.Text = "Nâng cao 1 - Quản lý Sinh viên";
            this.btnNangCaoSinhVien.UseVisualStyleBackColor = true;
            this.btnNangCaoSinhVien.Click += new EventHandler(this.btnNangCaoSinhVien_Click);
            //
            // btnNangCaoDiem
            //
            this.btnNangCaoDiem.Location = new Point(40, 235);
            this.btnNangCaoDiem.Name = "btnNangCaoDiem";
            this.btnNangCaoDiem.Size = new Size(380, 32);
            this.btnNangCaoDiem.TabIndex = 4;
            this.btnNangCaoDiem.Text = "Nâng cao 2 - Quản lý Điểm";
            this.btnNangCaoDiem.UseVisualStyleBackColor = true;
            this.btnNangCaoDiem.Click += new EventHandler(this.btnNangCaoDiem_Click);
            //
            // btnDanhSachDiem
            //
            this.btnDanhSachDiem.Location = new Point(40, 270);
            this.btnDanhSachDiem.Name = "btnDanhSachDiem";
            this.btnDanhSachDiem.Size = new Size(380, 32);
            this.btnDanhSachDiem.TabIndex = 5;
            this.btnDanhSachDiem.Text = "Nâng cao 2 - Danh sách Điểm (ListView)";
            this.btnDanhSachDiem.UseVisualStyleBackColor = true;
            this.btnDanhSachDiem.Click += new EventHandler(this.btnDanhSachDiem_Click);
            //
            // btnVeNhaCuaHang
            //
            this.btnVeNhaCuaHang.Location = new Point(40, 305);
            this.btnVeNhaCuaHang.Name = "btnVeNhaCuaHang";
            this.btnVeNhaCuaHang.Size = new Size(380, 32);
            this.btnVeNhaCuaHang.TabIndex = 6;
            this.btnVeNhaCuaHang.Text = "Về nhà - Quản lý Cửa hàng (Tồn kho / Bán hàng)";
            this.btnVeNhaCuaHang.UseVisualStyleBackColor = true;
            this.btnVeNhaCuaHang.Click += new EventHandler(this.btnVeNhaCuaHang_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(40, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(380, 32);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(460, 405);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnMauKhoa);
            this.Controls.Add(this.btnTaiLopLop);
            this.Controls.Add(this.btnDanhSachLop);
            this.Controls.Add(this.btnNangCaoSinhVien);
            this.Controls.Add(this.btnNangCaoDiem);
            this.Controls.Add(this.btnDanhSachDiem);
            this.Controls.Add(this.btnVeNhaCuaHang);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lab 06 Continue - Menu Quản Lý Sinh Viên & Cửa Hàng";
            this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
