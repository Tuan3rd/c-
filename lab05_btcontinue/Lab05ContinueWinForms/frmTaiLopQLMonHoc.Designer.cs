namespace Lab05ContinueWinForms
{
    partial class frmTaiLopQLMonHoc
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

        private Label lblMaMh;
        private TextBox txtMaMh;
        private Label lblTenMh;
        private TextBox txtTenMh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaMh = new Label();
            this.txtMaMh = new TextBox();
            this.lblTenMh = new Label();
            this.txtTenMh = new TextBox();
            this.btnThem = new Button();
            this.btnXoa = new Button();
            this.btnSua = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblMaMh
            //
            this.lblMaMh.Location = new Point(20, 20);
            this.lblMaMh.Name = "lblMaMh";
            this.lblMaMh.Size = new Size(70, 23);
            this.lblMaMh.Text = "Mã mh";
            //
            // txtMaMh
            //
            this.txtMaMh.Location = new Point(100, 17);
            this.txtMaMh.Name = "txtMaMh";
            this.txtMaMh.Size = new Size(220, 23);
            this.txtMaMh.TabIndex = 0;
            //
            // lblTenMh
            //
            this.lblTenMh.Location = new Point(20, 55);
            this.lblTenMh.Name = "lblTenMh";
            this.lblTenMh.Size = new Size(70, 23);
            this.lblTenMh.Text = "Tên mh";
            //
            // txtTenMh
            //
            this.txtTenMh.Location = new Point(100, 52);
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.Size = new Size(220, 23);
            this.txtTenMh.TabIndex = 1;
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
            // frmTaiLopQLMonHoc
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 150);
            this.Controls.Add(this.lblMaMh);
            this.Controls.Add(this.txtMaMh);
            this.Controls.Add(this.lblTenMh);
            this.Controls.Add(this.txtTenMh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTaiLopQLMonHoc";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý môn học";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
