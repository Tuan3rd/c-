namespace Lab04WinForms
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
        private Button btnBai1;
        private Button btnBai2;
        private Button btnBai3;
        private Button btnBai4;
        private Button btnBai5;
        private Button btnNangCaoBai1;
        private Button btnBtvnBai1;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.btnBai1 = new Button();
            this.btnBai2 = new Button();
            this.btnBai3 = new Button();
            this.btnBai4 = new Button();
            this.btnBai5 = new Button();
            this.btnNangCaoBai1 = new Button();
            this.btnBtvnBai1 = new Button();
            this.btnThoat = new Button();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(20, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(400, 30);
            this.lblTieuDe.Text = "LAB 04 - LẬP TRÌNH WINFORM CƠ BẢN";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblThongTin
            //
            this.lblThongTin.Font = new Font("Tahoma", 9F);
            this.lblThongTin.Location = new Point(20, 54);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new Size(400, 22);
            this.lblThongTin.Text = "Họ tên: Thái Tuấn - MSSV: 3123411327";
            this.lblThongTin.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnBai1
            //
            this.btnBai1.Location = new Point(40, 95);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new Size(360, 32);
            this.btnBai1.TabIndex = 0;
            this.btnBai1.Text = "Bài 1 - Cộng trừ nhân chia";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new EventHandler(this.btnBai1_Click);
            //
            // btnBai2
            //
            this.btnBai2.Location = new Point(40, 133);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new Size(360, 32);
            this.btnBai2.TabIndex = 1;
            this.btnBai2.Text = "Bài 2 - Đăng ký tài khoản";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new EventHandler(this.btnBai2_Click);
            //
            // btnBai3
            //
            this.btnBai3.Location = new Point(40, 171);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new Size(360, 32);
            this.btnBai3.TabIndex = 2;
            this.btnBai3.Text = "Bài 3 - Ước số chung - Bội số chung";
            this.btnBai3.UseVisualStyleBackColor = true;
            this.btnBai3.Click += new EventHandler(this.btnBai3_Click);
            //
            // btnBai4
            //
            this.btnBai4.Location = new Point(40, 209);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new Size(360, 32);
            this.btnBai4.TabIndex = 3;
            this.btnBai4.Text = "Bài 4 - Dãy số và tính tổng";
            this.btnBai4.UseVisualStyleBackColor = true;
            this.btnBai4.Click += new EventHandler(this.btnBai4_Click);
            //
            // btnBai5
            //
            this.btnBai5.Location = new Point(40, 247);
            this.btnBai5.Name = "btnBai5";
            this.btnBai5.Size = new Size(360, 32);
            this.btnBai5.TabIndex = 4;
            this.btnBai5.Text = "Bài 5 - Đọc số thành chữ";
            this.btnBai5.UseVisualStyleBackColor = true;
            this.btnBai5.Click += new EventHandler(this.btnBai5_Click);
            //
            // btnNangCaoBai1
            //
            this.btnNangCaoBai1.Location = new Point(40, 285);
            this.btnNangCaoBai1.Name = "btnNangCaoBai1";
            this.btnNangCaoBai1.Size = new Size(360, 32);
            this.btnNangCaoBai1.TabIndex = 5;
            this.btnNangCaoBai1.Text = "Nâng cao - Bán vé rạp chiếu bóng";
            this.btnNangCaoBai1.UseVisualStyleBackColor = true;
            this.btnNangCaoBai1.Click += new EventHandler(this.btnNangCaoBai1_Click);
            //
            // btnBtvnBai1
            //
            this.btnBtvnBai1.Location = new Point(40, 323);
            this.btnBtvnBai1.Name = "btnBtvnBai1";
            this.btnBtvnBai1.Size = new Size(360, 32);
            this.btnBtvnBai1.TabIndex = 6;
            this.btnBtvnBai1.Text = "Về nhà - Máy tính bỏ túi";
            this.btnBtvnBai1.UseVisualStyleBackColor = true;
            this.btnBtvnBai1.Click += new EventHandler(this.btnBtvnBai1_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(40, 371);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(360, 32);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmMain
            //
            this.AcceptButton = null;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(440, 430);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnBai1);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai5);
            this.Controls.Add(this.btnNangCaoBai1);
            this.Controls.Add(this.btnBtvnBai1);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lab 04 - Menu Bài Tập WinForm";
            this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
