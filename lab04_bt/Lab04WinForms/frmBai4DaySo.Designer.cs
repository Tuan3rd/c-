namespace Lab04WinForms
{
    partial class frmBai4DaySo
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
        private Label lblNhapSo;
        private TextBox txtNhapSo;
        private Button btnNhap;
        private Label lblDayVuaNhap;
        private TextBox txtDayVuaNhap;
        private Label lblTongCacPhanTu;
        private TextBox txtTongCacPhanTu;
        private Label lblTongChan;
        private TextBox txtTongChan;
        private Label lblTongLe;
        private TextBox txtTongLe;
        private Button btnTinhTong;
        private Button btnTiepTuc;
        private Button btnThoat;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblNhapSo = new Label();
            this.txtNhapSo = new TextBox();
            this.btnNhap = new Button();
            this.lblDayVuaNhap = new Label();
            this.txtDayVuaNhap = new TextBox();
            this.lblTongCacPhanTu = new Label();
            this.txtTongCacPhanTu = new TextBox();
            this.lblTongChan = new Label();
            this.txtTongChan = new TextBox();
            this.lblTongLe = new Label();
            this.txtTongLe = new TextBox();
            this.btnTinhTong = new Button();
            this.btnTiepTuc = new Button();
            this.btnThoat = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(430, 28);
            this.lblTieuDe.Text = "Nhập Dãy Số Và Tính Tổng";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblNhapSo
            //
            this.lblNhapSo.Location = new Point(25, 60);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new Size(80, 23);
            this.lblNhapSo.Text = "Nhập số :";
            this.lblNhapSo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtNhapSo
            //
            this.txtNhapSo.Location = new Point(110, 57);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new Size(120, 23);
            this.txtNhapSo.TabIndex = 0;
            //
            // btnNhap
            //
            this.btnNhap.Location = new Point(245, 55);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new Size(90, 28);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new EventHandler(this.btnNhap_Click);
            //
            // lblDayVuaNhap
            //
            this.lblDayVuaNhap.Location = new Point(25, 95);
            this.lblDayVuaNhap.Name = "lblDayVuaNhap";
            this.lblDayVuaNhap.Size = new Size(110, 23);
            this.lblDayVuaNhap.Text = "Dãy vừa nhập :";
            this.lblDayVuaNhap.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtDayVuaNhap
            //
            this.txtDayVuaNhap.Location = new Point(145, 92);
            this.txtDayVuaNhap.Name = "txtDayVuaNhap";
            this.txtDayVuaNhap.ReadOnly = true;
            this.txtDayVuaNhap.Size = new Size(290, 23);
            this.txtDayVuaNhap.TabIndex = 2;
            this.txtDayVuaNhap.TabStop = false;
            //
            // lblTongCacPhanTu
            //
            this.lblTongCacPhanTu.Location = new Point(25, 130);
            this.lblTongCacPhanTu.Name = "lblTongCacPhanTu";
            this.lblTongCacPhanTu.Size = new Size(190, 23);
            this.lblTongCacPhanTu.Text = "Tổng các phần tử trong dãy :";
            this.lblTongCacPhanTu.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtTongCacPhanTu
            //
            this.txtTongCacPhanTu.Location = new Point(225, 127);
            this.txtTongCacPhanTu.Name = "txtTongCacPhanTu";
            this.txtTongCacPhanTu.ReadOnly = true;
            this.txtTongCacPhanTu.Size = new Size(100, 23);
            this.txtTongCacPhanTu.TabIndex = 3;
            this.txtTongCacPhanTu.TabStop = false;
            //
            // lblTongChan
            //
            this.lblTongChan.Location = new Point(25, 165);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new Size(80, 23);
            this.lblTongChan.Text = "Tổng Chẵn :";
            this.lblTongChan.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtTongChan
            //
            this.txtTongChan.Location = new Point(105, 162);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new Size(90, 23);
            this.txtTongChan.TabIndex = 4;
            this.txtTongChan.TabStop = false;
            //
            // lblTongLe
            //
            this.lblTongLe.Location = new Point(220, 165);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new Size(70, 23);
            this.lblTongLe.Text = "Tổng Lẻ :";
            this.lblTongLe.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtTongLe
            //
            this.txtTongLe.Location = new Point(290, 162);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new Size(90, 23);
            this.txtTongLe.TabIndex = 5;
            this.txtTongLe.TabStop = false;
            //
            // btnTinhTong
            //
            this.btnTinhTong.Location = new Point(25, 205);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new Size(130, 32);
            this.btnTinhTong.TabIndex = 6;
            this.btnTinhTong.Text = "Tính Tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new EventHandler(this.btnTinhTong_Click);
            //
            // btnTiepTuc
            //
            this.btnTiepTuc.Location = new Point(165, 205);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new Size(130, 32);
            this.btnTiepTuc.TabIndex = 7;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new EventHandler(this.btnTiepTuc_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(305, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(130, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmBai4DaySo
            //
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(470, 260);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lblDayVuaNhap);
            this.Controls.Add(this.txtDayVuaNhap);
            this.Controls.Add(this.lblTongCacPhanTu);
            this.Controls.Add(this.txtTongCacPhanTu);
            this.Controls.Add(this.lblTongChan);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.lblTongLe);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai4DaySo";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bài 4 - Dãy Số Và Tính Tổng";
            this.FormClosing += new FormClosingEventHandler(this.frmBai4DaySo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
