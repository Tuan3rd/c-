namespace Lab05ContinueWinForms
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

        private MenuStrip menuChinh;
        private ToolStripMenuItem mnuNangCao2;
        private ToolStripMenuItem mnuMau1DongHo;
        private ToolStripMenuItem mnuMau2ListView;
        private ToolStripMenuItem mnuMau3FileDialog;
        private ToolStripMenuItem mnuTaiLop1SinhVien;
        private ToolStripMenuItem mnuTaiLop2TaiKhoan;
        private ToolStripMenuItem mnuNangCaoHocVien;
        private ToolStripMenuItem mnuVeNha1DemNguoc;

        private ToolStripMenuItem mnuAdoNet;
        private ToolStripMenuItem mnuMauKhoa;
        private ToolStripMenuItem mnuTaiLopMonHoc;
        private ToolStripMenuItem mnuNangCaoSinhVien;
        private ToolStripMenuItem mnuNangCaoDiem;
        private ToolStripMenuItem mnuVeNhaLop;

        private ToolStripMenuItem mnuThoat;
        private Label lblTieuDe;
        private Label lblThongTin;

        private void InitializeComponent()
        {
            this.menuChinh = new MenuStrip();
            this.mnuNangCao2 = new ToolStripMenuItem();
            this.mnuMau1DongHo = new ToolStripMenuItem();
            this.mnuMau2ListView = new ToolStripMenuItem();
            this.mnuMau3FileDialog = new ToolStripMenuItem();
            this.mnuTaiLop1SinhVien = new ToolStripMenuItem();
            this.mnuTaiLop2TaiKhoan = new ToolStripMenuItem();
            this.mnuNangCaoHocVien = new ToolStripMenuItem();
            this.mnuVeNha1DemNguoc = new ToolStripMenuItem();

            this.mnuAdoNet = new ToolStripMenuItem();
            this.mnuMauKhoa = new ToolStripMenuItem();
            this.mnuTaiLopMonHoc = new ToolStripMenuItem();
            this.mnuNangCaoSinhVien = new ToolStripMenuItem();
            this.mnuNangCaoDiem = new ToolStripMenuItem();
            this.mnuVeNhaLop = new ToolStripMenuItem();

            this.mnuThoat = new ToolStripMenuItem();
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.menuChinh.SuspendLayout();
            this.SuspendLayout();
            //
            // menuChinh
            //
            this.menuChinh.Items.AddRange(new ToolStripItem[] {
                this.mnuNangCao2, this.mnuAdoNet, this.mnuThoat });
            this.menuChinh.Location = new Point(0, 0);
            this.menuChinh.Name = "menuChinh";
            this.menuChinh.Size = new Size(560, 28);
            this.menuChinh.TabIndex = 0;
            //
            // mnuNangCao2
            //
            this.mnuNangCao2.DropDownItems.AddRange(new ToolStripItem[] {
                this.mnuMau1DongHo, this.mnuMau2ListView, this.mnuMau3FileDialog,
                this.mnuTaiLop1SinhVien, this.mnuTaiLop2TaiKhoan, this.mnuNangCaoHocVien,
                this.mnuVeNha1DemNguoc });
            this.mnuNangCao2.Name = "mnuNangCao2";
            this.mnuNangCao2.Text = "WinForm Nâng Cao {2}";
            //
            // mnuMau1DongHo
            //
            this.mnuMau1DongHo.Name = "mnuMau1DongHo";
            this.mnuMau1DongHo.Text = "Mẫu Bài 1 - Đồng hồ (Timer)";
            this.mnuMau1DongHo.Click += new EventHandler(this.mnuMau1DongHo_Click);
            //
            // mnuMau2ListView
            //
            this.mnuMau2ListView.Name = "mnuMau2ListView";
            this.mnuMau2ListView.Text = "Mẫu Bài 2 - ListView CRUD";
            this.mnuMau2ListView.Click += new EventHandler(this.mnuMau2ListView_Click);
            //
            // mnuMau3FileDialog
            //
            this.mnuMau3FileDialog.Name = "mnuMau3FileDialog";
            this.mnuMau3FileDialog.Text = "Mẫu Bài 3 - Save/Open File Dialog";
            this.mnuMau3FileDialog.Click += new EventHandler(this.mnuMau3FileDialog_Click);
            //
            // mnuTaiLop1SinhVien
            //
            this.mnuTaiLop1SinhVien.Name = "mnuTaiLop1SinhVien";
            this.mnuTaiLop1SinhVien.Text = "Tại lớp 1 - ListView Sinh viên";
            this.mnuTaiLop1SinhVien.Click += new EventHandler(this.mnuTaiLop1SinhVien_Click);
            //
            // mnuTaiLop2TaiKhoan
            //
            this.mnuTaiLop2TaiKhoan.Name = "mnuTaiLop2TaiKhoan";
            this.mnuTaiLop2TaiKhoan.Text = "Tại lớp 2 - Tài khoản ngân hàng";
            this.mnuTaiLop2TaiKhoan.Click += new EventHandler(this.mnuTaiLop2TaiKhoan_Click);
            //
            // mnuNangCaoHocVien
            //
            this.mnuNangCaoHocVien.Name = "mnuNangCaoHocVien";
            this.mnuNangCaoHocVien.Text = "Nâng cao - Quản lý học viên";
            this.mnuNangCaoHocVien.Click += new EventHandler(this.mnuNangCaoHocVien_Click);
            //
            // mnuVeNha1DemNguoc
            //
            this.mnuVeNha1DemNguoc.Name = "mnuVeNha1DemNguoc";
            this.mnuVeNha1DemNguoc.Text = "Về nhà - Đếm ngược thời gian";
            this.mnuVeNha1DemNguoc.Click += new EventHandler(this.mnuVeNha1DemNguoc_Click);
            //
            // mnuAdoNet
            //
            this.mnuAdoNet.DropDownItems.AddRange(new ToolStripItem[] {
                this.mnuMauKhoa, this.mnuTaiLopMonHoc, this.mnuNangCaoSinhVien,
                this.mnuNangCaoDiem, this.mnuVeNhaLop });
            this.mnuAdoNet.Name = "mnuAdoNet";
            this.mnuAdoNet.Text = "Bài 7 - ADO.NET";
            //
            // mnuMauKhoa
            //
            this.mnuMauKhoa.Name = "mnuMauKhoa";
            this.mnuMauKhoa.Text = "Mẫu - Quản lý Khoa";
            this.mnuMauKhoa.Click += new EventHandler(this.mnuMauKhoa_Click);
            //
            // mnuTaiLopMonHoc
            //
            this.mnuTaiLopMonHoc.Name = "mnuTaiLopMonHoc";
            this.mnuTaiLopMonHoc.Text = "Tại lớp - Quản lý Môn học";
            this.mnuTaiLopMonHoc.Click += new EventHandler(this.mnuTaiLopMonHoc_Click);
            //
            // mnuNangCaoSinhVien
            //
            this.mnuNangCaoSinhVien.Name = "mnuNangCaoSinhVien";
            this.mnuNangCaoSinhVien.Text = "Nâng cao 1 - Quản lý Sinh viên";
            this.mnuNangCaoSinhVien.Click += new EventHandler(this.mnuNangCaoSinhVien_Click);
            //
            // mnuNangCaoDiem
            //
            this.mnuNangCaoDiem.Name = "mnuNangCaoDiem";
            this.mnuNangCaoDiem.Text = "Nâng cao 2 - Quản lý Điểm";
            this.mnuNangCaoDiem.Click += new EventHandler(this.mnuNangCaoDiem_Click);
            //
            // mnuVeNhaLop
            //
            this.mnuVeNhaLop.Name = "mnuVeNhaLop";
            this.mnuVeNhaLop.Text = "Về nhà - Quản lý Lớp";
            this.mnuVeNhaLop.Click += new EventHandler(this.mnuVeNhaLop_Click);
            //
            // mnuThoat
            //
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new EventHandler(this.mnuThoat_Click);
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(20, 45);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(520, 30);
            this.lblTieuDe.Text = "LAB 05 CONTINUE - WINFORM NÂNG CAO {2} + ADO.NET";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblThongTin
            //
            this.lblThongTin.Font = new Font("Tahoma", 9F);
            this.lblThongTin.Location = new Point(20, 80);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new Size(520, 50);
            this.lblThongTin.Text = "Họ tên: Thái Tuấn - MSSV: 3123411327\r\nChọn menu phía trên để mở từng bài tập.";
            this.lblThongTin.TextAlign = ContentAlignment.MiddleCenter;
            //
            // frmMain
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(560, 160);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.menuChinh);
            this.MainMenuStrip = this.menuChinh;
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BTVN_Tuan - Lab 05 Continue";
            this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuChinh.ResumeLayout(false);
            this.menuChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
