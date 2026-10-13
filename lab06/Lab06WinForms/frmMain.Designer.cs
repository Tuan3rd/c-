namespace Lab06WinForms
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
        private Button btnTaiLopMonHoc;
        private Button btnNangCaoSinhVien;
        private Button btnNangCaoDiem;
        private Button btnVeNhaLop;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.btnMauKhoa = new Button();
            this.btnTaiLopMonHoc = new Button();
            this.btnNangCaoSinhVien = new Button();
            this.btnNangCaoDiem = new Button();
            this.btnVeNhaLop = new Button();
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
            this.lblTieuDe.Text = "LAB 06 - TƯƠNG TÁC CSDL {1}";
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
            // btnTaiLopMonHoc
            //
            this.btnTaiLopMonHoc.Location = new Point(40, 130);
            this.btnTaiLopMonHoc.Name = "btnTaiLopMonHoc";
            this.btnTaiLopMonHoc.Size = new Size(380, 32);
            this.btnTaiLopMonHoc.TabIndex = 1;
            this.btnTaiLopMonHoc.Text = "Tại lớp - Quản lý Môn học";
            this.btnTaiLopMonHoc.UseVisualStyleBackColor = true;
            this.btnTaiLopMonHoc.Click += new EventHandler(this.btnTaiLopMonHoc_Click);
            //
            // btnNangCaoSinhVien
            //
            this.btnNangCaoSinhVien.Location = new Point(40, 165);
            this.btnNangCaoSinhVien.Name = "btnNangCaoSinhVien";
            this.btnNangCaoSinhVien.Size = new Size(380, 32);
            this.btnNangCaoSinhVien.TabIndex = 2;
            this.btnNangCaoSinhVien.Text = "Nâng cao 1 - Quản lý Sinh viên";
            this.btnNangCaoSinhVien.UseVisualStyleBackColor = true;
            this.btnNangCaoSinhVien.Click += new EventHandler(this.btnNangCaoSinhVien_Click);
            //
            // btnNangCaoDiem
            //
            this.btnNangCaoDiem.Location = new Point(40, 200);
            this.btnNangCaoDiem.Name = "btnNangCaoDiem";
            this.btnNangCaoDiem.Size = new Size(380, 32);
            this.btnNangCaoDiem.TabIndex = 3;
            this.btnNangCaoDiem.Text = "Nâng cao 2 - Quản lý Điểm";
            this.btnNangCaoDiem.UseVisualStyleBackColor = true;
            this.btnNangCaoDiem.Click += new EventHandler(this.btnNangCaoDiem_Click);
            //
            // btnVeNhaLop
            //
            this.btnVeNhaLop.Location = new Point(40, 235);
            this.btnVeNhaLop.Name = "btnVeNhaLop";
            this.btnVeNhaLop.Size = new Size(380, 32);
            this.btnVeNhaLop.TabIndex = 4;
            this.btnVeNhaLop.Text = "Về nhà - Quản lý Lớp";
            this.btnVeNhaLop.UseVisualStyleBackColor = true;
            this.btnVeNhaLop.Click += new EventHandler(this.btnVeNhaLop_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(40, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(380, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(460, 335);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnMauKhoa);
            this.Controls.Add(this.btnTaiLopMonHoc);
            this.Controls.Add(this.btnNangCaoSinhVien);
            this.Controls.Add(this.btnNangCaoDiem);
            this.Controls.Add(this.btnVeNhaLop);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lab 06 - Menu Quản Lý Sinh Viên";
            this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
