namespace Lab06WinForms
{
    partial class frmQLLop
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
        private Label lblMaLop;
        private TextBox txtMaLop;
        private Label lblTenLop;
        private TextBox txtTenLop;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaKhoa = new Label();
            this.txtMaKhoa = new TextBox();
            this.lblMaLop = new Label();
            this.txtMaLop = new TextBox();
            this.lblTenLop = new Label();
            this.txtTenLop = new TextBox();
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
            this.lblMaKhoa.Size = new Size(75, 23);
            this.lblMaKhoa.Text = "Mã khoa";
            //
            // txtMaKhoa
            //
            this.txtMaKhoa.Location = new Point(105, 17);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new Size(220, 23);
            this.txtMaKhoa.TabIndex = 0;
            //
            // lblMaLop
            //
            this.lblMaLop.Location = new Point(20, 55);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new Size(75, 23);
            this.lblMaLop.Text = "Mã lớp";
            //
            // txtMaLop
            //
            this.txtMaLop.Location = new Point(105, 52);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new Size(220, 23);
            this.txtMaLop.TabIndex = 1;
            //
            // lblTenLop
            //
            this.lblTenLop.Location = new Point(20, 90);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new Size(75, 23);
            this.lblTenLop.Text = "Tên lớp";
            //
            // txtTenLop
            //
            this.txtTenLop.Location = new Point(105, 87);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new Size(220, 23);
            this.txtTenLop.TabIndex = 2;
            //
            // btnThem
            //
            this.btnThem.Location = new Point(40, 130);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(85, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(145, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(85, 32);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new Point(250, 130);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(85, 32);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new EventHandler(this.btnSua_Click);
            //
            // frmQLLop
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 185);
            this.Controls.Add(this.lblMaKhoa);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblTenLop);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQLLop";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmLop";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
