namespace Lab05WinForms
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
        private Button btnMauBai1;
        private Button btnMauBai2;
        private Button btnMauBai3;
        private Button btnBai1;
        private Button btnBai2;
        private Button btnNangCaoBai1;
        private Button btnBtvnBai1;
        private Button btnBtvnBai2;
        private Button btnBtvnBai3;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.btnMauBai1 = new Button();
            this.btnMauBai2 = new Button();
            this.btnMauBai3 = new Button();
            this.btnBai1 = new Button();
            this.btnBai2 = new Button();
            this.btnNangCaoBai1 = new Button();
            this.btnBtvnBai1 = new Button();
            this.btnBtvnBai2 = new Button();
            this.btnBtvnBai3 = new Button();
            this.btnThoat = new Button();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(440, 30);
            this.lblTieuDe.Text = "LAB 05 - WINFORM NÂNG CAO {1}";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblThongTin
            //
            this.lblThongTin.Font = new Font("Tahoma", 9F);
            this.lblThongTin.Location = new Point(20, 54);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new Size(440, 22);
            this.lblThongTin.Text = "Họ tên: Thái Tuấn - MSSV: 3123411327";
            this.lblThongTin.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnMauBai1
            //
            this.btnMauBai1.Location = new Point(40, 95);
            this.btnMauBai1.Name = "btnMauBai1";
            this.btnMauBai1.Size = new Size(400, 30);
            this.btnMauBai1.TabIndex = 0;
            this.btnMauBai1.Text = "Mẫu Bài 1 - Chuyển ListBox qua lại";
            this.btnMauBai1.UseVisualStyleBackColor = true;
            this.btnMauBai1.Click += new EventHandler(this.btnMauBai1_Click);
            //
            // btnMauBai2
            //
            this.btnMauBai2.Location = new Point(40, 130);
            this.btnMauBai2.Name = "btnMauBai2";
            this.btnMauBai2.Size = new Size(400, 30);
            this.btnMauBai2.TabIndex = 1;
            this.btnMauBai2.Text = "Mẫu Bài 2 - ComboBox Dân tộc";
            this.btnMauBai2.UseVisualStyleBackColor = true;
            this.btnMauBai2.Click += new EventHandler(this.btnMauBai2_Click);
            //
            // btnMauBai3
            //
            this.btnMauBai3.Location = new Point(40, 165);
            this.btnMauBai3.Name = "btnMauBai3";
            this.btnMauBai3.Size = new Size(400, 30);
            this.btnMauBai3.TabIndex = 2;
            this.btnMauBai3.Text = "Mẫu Bài 3 - TreeView Phòng ban - Nhân viên";
            this.btnMauBai3.UseVisualStyleBackColor = true;
            this.btnMauBai3.Click += new EventHandler(this.btnMauBai3_Click);
            //
            // btnBai1
            //
            this.btnBai1.Location = new Point(40, 200);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new Size(400, 30);
            this.btnBai1.TabIndex = 3;
            this.btnBai1.Text = "Bài 1 - ComboBox số và Ước số";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new EventHandler(this.btnBai1_Click);
            //
            // btnBai2
            //
            this.btnBai2.Location = new Point(40, 235);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new Size(400, 30);
            this.btnBai2.TabIndex = 4;
            this.btnBai2.Text = "Bài 2 - Quản lý Lớp - Sinh viên (TreeView)";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new EventHandler(this.btnBai2_Click);
            //
            // btnNangCaoBai1
            //
            this.btnNangCaoBai1.Location = new Point(40, 270);
            this.btnNangCaoBai1.Name = "btnNangCaoBai1";
            this.btnNangCaoBai1.Size = new Size(400, 30);
            this.btnNangCaoBai1.TabIndex = 5;
            this.btnNangCaoBai1.Text = "Nâng cao - Xử lý chuỗi (ListBox tên ngẫu nhiên)";
            this.btnNangCaoBai1.UseVisualStyleBackColor = true;
            this.btnNangCaoBai1.Click += new EventHandler(this.btnNangCaoBai1_Click);
            //
            // btnBtvnBai1
            //
            this.btnBtvnBai1.Location = new Point(40, 305);
            this.btnBtvnBai1.Name = "btnBtvnBai1";
            this.btnBtvnBai1.Size = new Size(400, 30);
            this.btnBtvnBai1.TabIndex = 6;
            this.btnBtvnBai1.Text = "Về nhà 1 - Từ điển Anh - Việt / Việt - Anh";
            this.btnBtvnBai1.UseVisualStyleBackColor = true;
            this.btnBtvnBai1.Click += new EventHandler(this.btnBtvnBai1_Click);
            //
            // btnBtvnBai2
            //
            this.btnBtvnBai2.Location = new Point(40, 340);
            this.btnBtvnBai2.Name = "btnBtvnBai2";
            this.btnBtvnBai2.Size = new Size(400, 30);
            this.btnBtvnBai2.TabIndex = 7;
            this.btnBtvnBai2.Text = "Về nhà 2 - ListBox số tự nhiên";
            this.btnBtvnBai2.UseVisualStyleBackColor = true;
            this.btnBtvnBai2.Click += new EventHandler(this.btnBtvnBai2_Click);
            //
            // btnBtvnBai3
            //
            this.btnBtvnBai3.Location = new Point(40, 375);
            this.btnBtvnBai3.Name = "btnBtvnBai3";
            this.btnBtvnBai3.Size = new Size(400, 30);
            this.btnBtvnBai3.TabIndex = 8;
            this.btnBtvnBai3.Text = "Về nhà 3 - Danh bạ (TreeView A-Z)";
            this.btnBtvnBai3.UseVisualStyleBackColor = true;
            this.btnBtvnBai3.Click += new EventHandler(this.btnBtvnBai3_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(40, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(400, 32);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(480, 475);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnMauBai1);
            this.Controls.Add(this.btnMauBai2);
            this.Controls.Add(this.btnMauBai3);
            this.Controls.Add(this.btnBai1);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnNangCaoBai1);
            this.Controls.Add(this.btnBtvnBai1);
            this.Controls.Add(this.btnBtvnBai2);
            this.Controls.Add(this.btnBtvnBai3);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lab 05 - Menu Bài Tập WinForm Nâng Cao";
            this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
