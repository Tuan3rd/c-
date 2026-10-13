namespace Lab06WinForms
{
    partial class frmQLKhoa
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

        private Label lblMaKhoa;
        private TextBox txtMaKhoa;
        private Label lblTenKhoa;
        private TextBox txtTenKhoa;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaKhoa = new Label();
            this.txtMaKhoa = new TextBox();
            this.lblTenKhoa = new Label();
            this.txtTenKhoa = new TextBox();
            this.btnThem = new Button();
            this.btnXoa = new Button();
            this.btnSua = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblMaKhoa
            //
            this.lblMaKhoa.Location = new Point(20, 20);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new Size(70, 23);
            this.lblMaKhoa.Text = "Mã khoa";
            //
            // txtMaKhoa
            //
            this.txtMaKhoa.Location = new Point(100, 17);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new Size(220, 23);
            this.txtMaKhoa.TabIndex = 0;
            //
            // lblTenKhoa
            //
            this.lblTenKhoa.Location = new Point(20, 55);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new Size(70, 23);
            this.lblTenKhoa.Text = "Tên khoa";
            //
            // txtTenKhoa
            //
            this.txtTenKhoa.Location = new Point(100, 52);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new Size(220, 23);
            this.txtTenKhoa.TabIndex = 1;
            //
            // btnThem
            //
            this.btnThem.Location = new Point(40, 95);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(85, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(145, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(85, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new Point(250, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(85, 32);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new EventHandler(this.btnSua_Click);
            //
            // frmQLKhoa
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 150);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lblTenKhoa);
            this.Controls.Add(this.txtTenKhoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQLKhoa";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
