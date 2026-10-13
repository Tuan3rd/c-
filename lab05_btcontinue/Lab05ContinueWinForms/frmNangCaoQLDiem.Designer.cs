namespace Lab05ContinueWinForms
{
    partial class frmNangCaoQLDiem
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

        private Label lblMaSv;
        private TextBox txtMaSv;
        private Label lblMaMh;
        private TextBox txtMaMh;
        private Label lblDiem;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaSv = new Label();
            this.txtMaSv = new TextBox();
            this.lblMaMh = new Label();
            this.txtMaMh = new TextBox();
            this.lblDiem = new Label();
            this.txtDiem = new TextBox();
            this.btnThem = new Button();
            this.btnXoa = new Button();
            this.btnSua = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblMaSv
            //
            this.lblMaSv.Location = new Point(20, 20);
            this.lblMaSv.Name = "lblMaSv";
            this.lblMaSv.Size = new Size(70, 23);
            this.lblMaSv.Text = "Mã sv";
            //
            // txtMaSv
            //
            this.txtMaSv.Location = new Point(100, 17);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new Size(220, 23);
            this.txtMaSv.TabIndex = 0;
            //
            // lblMaMh
            //
            this.lblMaMh.Location = new Point(20, 55);
            this.lblMaMh.Name = "lblMaMh";
            this.lblMaMh.Size = new Size(70, 23);
            this.lblMaMh.Text = "Mã mh";
            //
            // txtMaMh
            //
            this.txtMaMh.Location = new Point(100, 52);
            this.txtMaMh.Name = "txtMaMh";
            this.txtMaMh.Size = new Size(220, 23);
            this.txtMaMh.TabIndex = 1;
            //
            // lblDiem
            //
            this.lblDiem.Location = new Point(20, 90);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new Size(70, 23);
            this.lblDiem.Text = "Điểm";
            //
            // txtDiem
            //
            this.txtDiem.Location = new Point(100, 87);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new Size(220, 23);
            this.txtDiem.TabIndex = 2;
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
            // frmNangCaoQLDiem
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 185);
            this.Controls.Add(this.lblMaSv);
            this.Controls.Add(this.txtMaSv);
            this.Controls.Add(this.lblMaMh);
            this.Controls.Add(this.txtMaMh);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNangCaoQLDiem";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
