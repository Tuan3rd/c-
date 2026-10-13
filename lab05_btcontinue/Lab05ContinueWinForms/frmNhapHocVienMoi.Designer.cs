namespace Lab05ContinueWinForms
{
    partial class frmNhapHocVienMoi
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

        private Label lblHoVaTen;
        private TextBox txtHoVaTen;
        private Label lblLop;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Button btnTroVe;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoVaTen = new Label();
            this.txtHoVaTen = new TextBox();
            this.lblLop = new Label();
            this.cboLop = new ComboBox();
            this.btnCapNhat = new Button();
            this.btnTroVe = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblHoVaTen
            //
            this.lblHoVaTen.Location = new Point(20, 20);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new Size(80, 23);
            this.lblHoVaTen.Text = "Họ và Tên";
            //
            // txtHoVaTen
            //
            this.txtHoVaTen.Location = new Point(110, 17);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new Size(220, 23);
            this.txtHoVaTen.TabIndex = 0;
            //
            // lblLop
            //
            this.lblLop.Location = new Point(20, 55);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new Size(80, 23);
            this.lblLop.Text = "Lớp";
            //
            // cboLop
            //
            this.cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
            this.cboLop.Location = new Point(110, 52);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new Size(220, 25);
            this.cboLop.SelectedIndex = 0;
            this.cboLop.TabIndex = 1;
            //
            // btnCapNhat
            //
            this.btnCapNhat.Location = new Point(110, 95);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new Size(100, 32);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new EventHandler(this.btnCapNhat_Click);
            //
            // btnTroVe
            //
            this.btnTroVe.Location = new Point(220, 95);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new Size(110, 32);
            this.btnTroVe.TabIndex = 3;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new EventHandler(this.btnTroVe_Click);
            //
            // frmNhapHocVienMoi
            //
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 150);
            this.Controls.Add(this.lblHoVaTen);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTroVe);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNhapHocVienMoi";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Nhập học viên mới";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
