namespace Lab04WinForms
{
    partial class frmBai2DangKy
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
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblBatBuoc1;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblBatBuoc2;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblBatBuoc3;
        private Label lblXacNhanMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Button btnDangKy;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblTenDangNhap = new Label();
            this.txtTenDangNhap = new TextBox();
            this.lblBatBuoc1 = new Label();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblBatBuoc2 = new Label();
            this.lblMatKhau = new Label();
            this.txtMatKhau = new TextBox();
            this.lblBatBuoc3 = new Label();
            this.lblXacNhanMatKhau = new Label();
            this.txtXacNhanMatKhau = new TextBox();
            this.btnDangKy = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.SteelBlue;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(360, 28);
            this.lblTieuDe.Text = "Đăng ký tài khoản";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblTenDangNhap
            //
            this.lblTenDangNhap.Location = new Point(25, 60);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new Size(110, 23);
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            this.lblTenDangNhap.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtTenDangNhap
            //
            this.txtTenDangNhap.Location = new Point(145, 57);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new Size(200, 23);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.Leave += new EventHandler(this.txtTenDangNhap_Leave);
            //
            // lblBatBuoc1
            //
            this.lblBatBuoc1.ForeColor = Color.Red;
            this.lblBatBuoc1.Location = new Point(350, 60);
            this.lblBatBuoc1.Name = "lblBatBuoc1";
            this.lblBatBuoc1.Size = new Size(20, 23);
            this.lblBatBuoc1.Text = "(*)";
            //
            // lblEmail
            //
            this.lblEmail.Location = new Point(25, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(110, 23);
            this.lblEmail.Text = "Địa chỉ email";
            this.lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtEmail
            //
            this.txtEmail.Location = new Point(145, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Leave += new EventHandler(this.txtEmail_Leave);
            //
            // lblBatBuoc2
            //
            this.lblBatBuoc2.ForeColor = Color.Red;
            this.lblBatBuoc2.Location = new Point(350, 95);
            this.lblBatBuoc2.Name = "lblBatBuoc2";
            this.lblBatBuoc2.Size = new Size(20, 23);
            this.lblBatBuoc2.Text = "(*)";
            //
            // lblMatKhau
            //
            this.lblMatKhau.Location = new Point(25, 130);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new Size(110, 23);
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtMatKhau
            //
            this.txtMatKhau.Location = new Point(145, 127);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new Size(200, 23);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.Leave += new EventHandler(this.txtMatKhau_Leave);
            //
            // lblBatBuoc3
            //
            this.lblBatBuoc3.ForeColor = Color.Red;
            this.lblBatBuoc3.Location = new Point(350, 130);
            this.lblBatBuoc3.Name = "lblBatBuoc3";
            this.lblBatBuoc3.Size = new Size(20, 23);
            this.lblBatBuoc3.Text = "(*)";
            //
            // lblXacNhanMatKhau
            //
            this.lblXacNhanMatKhau.Location = new Point(25, 165);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new Size(110, 23);
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu";
            this.lblXacNhanMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtXacNhanMatKhau
            //
            this.txtXacNhanMatKhau.Location = new Point(145, 162);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new Size(200, 23);
            this.txtXacNhanMatKhau.TabIndex = 3;
            //
            // btnDangKy
            //
            this.btnDangKy.Location = new Point(145, 205);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new Size(150, 35);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new EventHandler(this.btnDangKy_Click);
            //
            // frmBai2DangKy
            //
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 265);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblBatBuoc1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblBatBuoc2);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblBatBuoc3);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.btnDangKy);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai2DangKy";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bài 2 - Đăng ký tài khoản";
            this.FormClosing += new FormClosingEventHandler(this.frmBai2DangKy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
