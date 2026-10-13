namespace Lab06ContinueWinForms
{
    partial class frmThemSanPham
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

        private Label lblTenSP;
        private TextBox txtTenSP;
        private Button btnThem;
        private Button btnHuy;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTenSP = new Label();
            this.txtTenSP = new TextBox();
            this.btnThem = new Button();
            this.btnHuy = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTenSP
            //
            this.lblTenSP.Location = new Point(20, 20);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new Size(80, 23);
            this.lblTenSP.Text = "Tên sản phẩm";
            //
            // txtTenSP
            //
            this.txtTenSP.Location = new Point(110, 17);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new Size(220, 23);
            this.txtTenSP.TabIndex = 0;
            //
            // btnThem
            //
            this.btnThem.Location = new Point(70, 60);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(100, 32);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnHuy
            //
            this.btnHuy.Location = new Point(190, 60);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new Size(100, 32);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new EventHandler(this.btnHuy_Click);
            //
            // frmThemSanPham
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 115);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmThemSanPham";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Thêm sản phẩm mới";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
