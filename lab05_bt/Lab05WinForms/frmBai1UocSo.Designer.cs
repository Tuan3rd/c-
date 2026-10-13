namespace Lab05WinForms
{
    partial class frmBai1UocSo
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

        private Label lblNhapSo;
        private TextBox txtNhapSo;
        private Button btnCapNhat;
        private ComboBox cboSo;
        private Label lblDanhSachUocSo;
        private ListBox lstUocSo;
        private Button btnTongUocSo;
        private Button btnSoLuongChan;
        private Button btnSoLuongNguyenTo;
        private Button btnThoat;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNhapSo = new Label();
            this.txtNhapSo = new TextBox();
            this.btnCapNhat = new Button();
            this.cboSo = new ComboBox();
            this.lblDanhSachUocSo = new Label();
            this.lstUocSo = new ListBox();
            this.btnTongUocSo = new Button();
            this.btnSoLuongChan = new Button();
            this.btnSoLuongNguyenTo = new Button();
            this.btnThoat = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblNhapSo
            //
            this.lblNhapSo.Location = new Point(20, 15);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new Size(100, 23);
            this.lblNhapSo.Text = "Nhập Số";
            //
            // txtNhapSo
            //
            this.txtNhapSo.Location = new Point(20, 42);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new Size(110, 23);
            this.txtNhapSo.TabIndex = 0;
            //
            // btnCapNhat
            //
            this.btnCapNhat.Location = new Point(140, 40);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new Size(90, 28);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new EventHandler(this.btnCapNhat_Click);
            //
            // cboSo
            //
            this.cboSo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboSo.Location = new Point(20, 80);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new Size(210, 25);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new EventHandler(this.cboSo_SelectedIndexChanged);
            //
            // lblDanhSachUocSo
            //
            this.lblDanhSachUocSo.Location = new Point(250, 15);
            this.lblDanhSachUocSo.Name = "lblDanhSachUocSo";
            this.lblDanhSachUocSo.Size = new Size(170, 23);
            this.lblDanhSachUocSo.Text = "Danh sách các ước số";
            //
            // lstUocSo
            //
            this.lstUocSo.Location = new Point(250, 42);
            this.lstUocSo.Name = "lstUocSo";
            this.lstUocSo.Size = new Size(170, 160);
            this.lstUocSo.TabIndex = 3;
            //
            // btnTongUocSo
            //
            this.btnTongUocSo.Location = new Point(250, 215);
            this.btnTongUocSo.Name = "btnTongUocSo";
            this.btnTongUocSo.Size = new Size(230, 30);
            this.btnTongUocSo.TabIndex = 4;
            this.btnTongUocSo.Text = "&Tổng các ước số";
            this.btnTongUocSo.UseVisualStyleBackColor = true;
            this.btnTongUocSo.Click += new EventHandler(this.btnTongUocSo_Click);
            //
            // btnSoLuongChan
            //
            this.btnSoLuongChan.Location = new Point(250, 250);
            this.btnSoLuongChan.Name = "btnSoLuongChan";
            this.btnSoLuongChan.Size = new Size(230, 30);
            this.btnSoLuongChan.TabIndex = 5;
            this.btnSoLuongChan.Text = "Số lượng các ước số c&hẵn";
            this.btnSoLuongChan.UseVisualStyleBackColor = true;
            this.btnSoLuongChan.Click += new EventHandler(this.btnSoLuongChan_Click);
            //
            // btnSoLuongNguyenTo
            //
            this.btnSoLuongNguyenTo.Location = new Point(250, 285);
            this.btnSoLuongNguyenTo.Name = "btnSoLuongNguyenTo";
            this.btnSoLuongNguyenTo.Size = new Size(230, 30);
            this.btnSoLuongNguyenTo.TabIndex = 6;
            this.btnSoLuongNguyenTo.Text = "Số lượng các ước số n&guyên tố";
            this.btnSoLuongNguyenTo.UseVisualStyleBackColor = true;
            this.btnSoLuongNguyenTo.Click += new EventHandler(this.btnSoLuongNguyenTo_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(20, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(140, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmBai1UocSo
            //
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 335);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.cboSo);
            this.Controls.Add(this.lblDanhSachUocSo);
            this.Controls.Add(this.lstUocSo);
            this.Controls.Add(this.btnTongUocSo);
            this.Controls.Add(this.btnSoLuongChan);
            this.Controls.Add(this.btnSoLuongNguyenTo);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai1UocSo";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Combobox";
            this.FormClosing += new FormClosingEventHandler(this.frmBai1UocSo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
