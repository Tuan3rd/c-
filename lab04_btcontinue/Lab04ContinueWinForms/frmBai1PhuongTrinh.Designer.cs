namespace Lab04ContinueWinForms
{
    partial class frmBai1PhuongTrinh
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
        private GroupBox grpLuaChon;
        private RadioButton rdoBacNhat;
        private RadioButton rdoBacHai;
        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label lblC;
        private TextBox txtC;
        private Button btnGiai;
        private Button btnThoat;
        private Label lblKetQua;
        private TextBox txtKetQua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.grpLuaChon = new GroupBox();
            this.rdoBacNhat = new RadioButton();
            this.rdoBacHai = new RadioButton();
            this.lblA = new Label();
            this.txtA = new TextBox();
            this.lblB = new Label();
            this.txtB = new TextBox();
            this.lblC = new Label();
            this.txtC = new TextBox();
            this.btnGiai = new Button();
            this.btnThoat = new Button();
            this.lblKetQua = new Label();
            this.txtKetQua = new TextBox();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpLuaChon.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.Red;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(400, 34);
            this.lblTieuDe.Text = "GIẢI PHƯƠNG TRÌNH";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // grpLuaChon
            //
            this.grpLuaChon.Controls.Add(this.rdoBacNhat);
            this.grpLuaChon.Controls.Add(this.rdoBacHai);
            this.grpLuaChon.Location = new Point(20, 60);
            this.grpLuaChon.Name = "grpLuaChon";
            this.grpLuaChon.Size = new Size(400, 85);
            this.grpLuaChon.TabStop = false;
            this.grpLuaChon.Text = "Bạn vui lòng chọn";
            //
            // rdoBacNhat
            //
            this.rdoBacNhat.Checked = true;
            this.rdoBacNhat.Location = new Point(20, 25);
            this.rdoBacNhat.Name = "rdoBacNhat";
            this.rdoBacNhat.Size = new Size(250, 24);
            this.rdoBacNhat.TabIndex = 0;
            this.rdoBacNhat.Text = "Phương trình bậc nhất";
            this.rdoBacNhat.UseVisualStyleBackColor = true;
            this.rdoBacNhat.CheckedChanged += new EventHandler(this.rdoLoaiPhuongTrinh_CheckedChanged);
            //
            // rdoBacHai
            //
            this.rdoBacHai.Location = new Point(20, 50);
            this.rdoBacHai.Name = "rdoBacHai";
            this.rdoBacHai.Size = new Size(250, 24);
            this.rdoBacHai.TabIndex = 1;
            this.rdoBacHai.Text = "Phương trình bậc hai";
            this.rdoBacHai.UseVisualStyleBackColor = true;
            this.rdoBacHai.CheckedChanged += new EventHandler(this.rdoLoaiPhuongTrinh_CheckedChanged);
            //
            // lblA
            //
            this.lblA.Location = new Point(20, 160);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(80, 23);
            this.lblA.Text = "Nhập a";
            this.lblA.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtA
            //
            this.txtA.Location = new Point(105, 157);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(150, 23);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new EventHandler(this.txtHeSo_TextChanged);
            //
            // lblB
            //
            this.lblB.Location = new Point(20, 195);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(80, 23);
            this.lblB.Text = "Nhập b";
            this.lblB.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtB
            //
            this.txtB.Location = new Point(105, 192);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(150, 23);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new EventHandler(this.txtHeSo_TextChanged);
            //
            // lblC
            //
            this.lblC.Location = new Point(20, 230);
            this.lblC.Name = "lblC";
            this.lblC.Size = new Size(80, 23);
            this.lblC.Text = "Nhập c";
            this.lblC.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtC
            //
            this.txtC.Enabled = false;
            this.txtC.Location = new Point(105, 227);
            this.txtC.Name = "txtC";
            this.txtC.Size = new Size(150, 23);
            this.txtC.TabIndex = 4;
            this.txtC.TextChanged += new EventHandler(this.txtHeSo_TextChanged);
            //
            // btnGiai
            //
            this.btnGiai.Enabled = false;
            this.btnGiai.Location = new Point(275, 157);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new Size(140, 30);
            this.btnGiai.TabIndex = 5;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new EventHandler(this.btnGiai_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(275, 192);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(140, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // lblKetQua
            //
            this.lblKetQua.Location = new Point(20, 270);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(80, 23);
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtKetQua
            //
            this.txtKetQua.Location = new Point(105, 270);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new Size(310, 55);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.TabStop = false;
            //
            // frmBai1PhuongTrinh
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(440, 345);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpLuaChon);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai1PhuongTrinh";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Giải phương trình bậc 1-2";
            this.Load += new EventHandler(this.frmBai1PhuongTrinh_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmBai1PhuongTrinh_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpLuaChon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
