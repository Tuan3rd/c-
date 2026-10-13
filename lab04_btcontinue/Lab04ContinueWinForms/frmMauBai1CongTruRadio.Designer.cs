namespace Lab04ContinueWinForms
{
    partial class frmMauBai1CongTruRadio
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

        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label lblKetQua;
        private TextBox txtKetQua;
        private RadioButton rdoCong;
        private RadioButton rdoTru;
        private RadioButton rdoNhan;
        private RadioButton rdoChia;
        private Button btnTinh;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblA = new Label();
            this.txtA = new TextBox();
            this.lblB = new Label();
            this.txtB = new TextBox();
            this.lblKetQua = new Label();
            this.txtKetQua = new TextBox();
            this.rdoCong = new RadioButton();
            this.rdoTru = new RadioButton();
            this.rdoNhan = new RadioButton();
            this.rdoChia = new RadioButton();
            this.btnTinh = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblA
            //
            this.lblA.Location = new Point(25, 20);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(40, 23);
            this.lblA.Text = "a =";
            this.lblA.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtA
            //
            this.txtA.Location = new Point(70, 17);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(110, 23);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new KeyPressEventHandler(this.txtSo_KeyPress);
            this.txtA.Leave += new EventHandler(this.txtSo_Leave);
            //
            // lblB
            //
            this.lblB.Location = new Point(200, 20);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(40, 23);
            this.lblB.Text = "b =";
            this.lblB.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtB
            //
            this.txtB.Location = new Point(245, 17);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(110, 23);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new KeyPressEventHandler(this.txtSo_KeyPress);
            this.txtB.Leave += new EventHandler(this.txtSo_Leave);
            //
            // lblKetQua
            //
            this.lblKetQua.Location = new Point(25, 60);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(70, 23);
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtKetQua
            //
            this.txtKetQua.Location = new Point(100, 57);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new Size(255, 23);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.TabStop = false;
            //
            // rdoCong
            //
            this.rdoCong.Location = new Point(60, 95);
            this.rdoCong.Name = "rdoCong";
            this.rdoCong.Size = new Size(45, 24);
            this.rdoCong.TabIndex = 3;
            this.rdoCong.Text = "+";
            this.rdoCong.Checked = true;
            this.rdoCong.UseVisualStyleBackColor = true;
            //
            // rdoTru
            //
            this.rdoTru.Location = new Point(135, 95);
            this.rdoTru.Name = "rdoTru";
            this.rdoTru.Size = new Size(45, 24);
            this.rdoTru.TabIndex = 4;
            this.rdoTru.Text = "-";
            this.rdoTru.UseVisualStyleBackColor = true;
            //
            // rdoNhan
            //
            this.rdoNhan.Location = new Point(210, 95);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new Size(45, 24);
            this.rdoNhan.TabIndex = 5;
            this.rdoNhan.Text = "x";
            this.rdoNhan.UseVisualStyleBackColor = true;
            //
            // rdoChia
            //
            this.rdoChia.Location = new Point(285, 95);
            this.rdoChia.Name = "rdoChia";
            this.rdoChia.Size = new Size(45, 24);
            this.rdoChia.TabIndex = 6;
            this.rdoChia.Text = "/";
            this.rdoChia.UseVisualStyleBackColor = true;
            //
            // btnTinh
            //
            this.btnTinh.Location = new Point(135, 135);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new Size(110, 32);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new EventHandler(this.btnTinh_Click);
            //
            // frmMauBai1CongTruRadio
            //
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(385, 190);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.rdoCong);
            this.Controls.Add(this.rdoTru);
            this.Controls.Add(this.rdoNhan);
            this.Controls.Add(this.rdoChia);
            this.Controls.Add(this.btnTinh);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai1CongTruRadio";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Cộng trừ nhân chia Radio";
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai1CongTruRadio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
