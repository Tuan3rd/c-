namespace Lab04ContinueWinForms
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
        private Button btnBai1;
        private Button btnBai2;
        private Button btnNangCaoBai1;
        private Button btnBtvnBai1;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblThongTin = new Label();
            this.btnMauBai1 = new Button();
            this.btnMauBai2 = new Button();
            this.btnBai1 = new Button();
            this.btnBai2 = new Button();
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
            this.lblTieuDe.Size = new Size(420, 30);
            this.lblTieuDe.Text = "LAB 04 CONTINUE - WINFORM CƠ BẢN {2}";
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
            // btnMauBai1
            //
            this.btnMauBai1.Location = new Point(40, 95);
            this.btnMauBai1.Name = "btnMauBai1";
            this.btnMauBai1.Size = new Size(380, 32);
            this.btnMauBai1.TabIndex = 0;
            this.btnMauBai1.Text = "Mẫu Bài 1 - Cộng trừ nhân chia (RadioButton)";
            this.btnMauBai1.UseVisualStyleBackColor = true;
            this.btnMauBai1.Click += new EventHandler(this.btnMauBai1_Click);
            //
            // btnMauBai2
            //
            this.btnMauBai2.Location = new Point(40, 133);
            this.btnMauBai2.Name = "btnMauBai2";
            this.btnMauBai2.Size = new Size(380, 32);
            this.btnMauBai2.TabIndex = 1;
            this.btnMauBai2.Text = "Mẫu Bài 2 - Định dạng Font/Color";
            this.btnMauBai2.UseVisualStyleBackColor = true;
            this.btnMauBai2.Click += new EventHandler(this.btnMauBai2_Click);
            //
            // btnBai1
            //
            this.btnBai1.Location = new Point(40, 171);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new Size(380, 32);
            this.btnBai1.TabIndex = 2;
            this.btnBai1.Text = "Bài 1 - Giải phương trình bậc 1, bậc 2";
            this.btnBai1.UseVisualStyleBackColor = true;
            this.btnBai1.Click += new EventHandler(this.btnBai1_Click);
            //
            // btnBai2
            //
            this.btnBai2.Location = new Point(40, 209);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new Size(380, 32);
            this.btnBai2.TabIndex = 3;
            this.btnBai2.Text = "Bài 2 - Mảng số nguyên";
            this.btnBai2.UseVisualStyleBackColor = true;
            this.btnBai2.Click += new EventHandler(this.btnBai2_Click);
            //
            // btnNangCaoBai1
            //
            this.btnNangCaoBai1.Location = new Point(40, 247);
            this.btnNangCaoBai1.Name = "btnNangCaoBai1";
            this.btnNangCaoBai1.Size = new Size(380, 32);
            this.btnNangCaoBai1.TabIndex = 4;
            this.btnNangCaoBai1.Text = "Nâng cao - Thu tiền Cafe Sinh Viên";
            this.btnNangCaoBai1.UseVisualStyleBackColor = true;
            this.btnNangCaoBai1.Click += new EventHandler(this.btnNangCaoBai1_Click);
            //
            // btnBtvnBai1
            //
            this.btnBtvnBai1.Location = new Point(40, 285);
            this.btnBtvnBai1.Name = "btnBtvnBai1";
            this.btnBtvnBai1.Size = new Size(380, 32);
            this.btnBtvnBai1.TabIndex = 5;
            this.btnBtvnBai1.Text = "Về nhà - Thanh toán Khách sạn Thanh Thanh";
            this.btnBtvnBai1.UseVisualStyleBackColor = true;
            this.btnBtvnBai1.Click += new EventHandler(this.btnBtvnBai1_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(40, 333);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(380, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmMain
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(460, 390);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblThongTin);
            this.Controls.Add(this.btnMauBai1);
            this.Controls.Add(this.btnMauBai2);
            this.Controls.Add(this.btnBai1);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnNangCaoBai1);
            this.Controls.Add(this.btnBtvnBai1);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lab 04 Continue - Menu Bài Tập WinForm";
            this.FormClosing += new FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
