namespace Lab04WinForms
{
    partial class frmBai1CongTru
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
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
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
            this.btnCong = new Button();
            this.btnTru = new Button();
            this.btnNhan = new Button();
            this.btnChia = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblA
            //
            this.lblA.Location = new Point(30, 25);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(40, 23);
            this.lblA.Text = "a =";
            this.lblA.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtA
            //
            this.txtA.Location = new Point(75, 22);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(110, 23);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new KeyPressEventHandler(this.txtSo_KeyPress);
            this.txtA.Leave += new EventHandler(this.txtSo_Leave);
            //
            // lblB
            //
            this.lblB.Location = new Point(210, 25);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(40, 23);
            this.lblB.Text = "b =";
            this.lblB.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtB
            //
            this.txtB.Location = new Point(255, 22);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(110, 23);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new KeyPressEventHandler(this.txtSo_KeyPress);
            this.txtB.Leave += new EventHandler(this.txtSo_Leave);
            //
            // lblKetQua
            //
            this.lblKetQua.Location = new Point(30, 65);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(70, 23);
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtKetQua
            //
            this.txtKetQua.Location = new Point(105, 62);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new Size(260, 23);
            this.txtKetQua.TabIndex = 2;
            this.txtKetQua.TabStop = false;
            //
            // btnCong
            //
            this.btnCong.Location = new Point(30, 105);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new Size(75, 32);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new EventHandler(this.btnCong_Click);
            //
            // btnTru
            //
            this.btnTru.Location = new Point(115, 105);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new Size(75, 32);
            this.btnTru.TabIndex = 4;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new EventHandler(this.btnTru_Click);
            //
            // btnNhan
            //
            this.btnNhan.Location = new Point(200, 105);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new Size(75, 32);
            this.btnNhan.TabIndex = 5;
            this.btnNhan.Text = "x";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new EventHandler(this.btnNhan_Click);
            //
            // btnChia
            //
            this.btnChia.Location = new Point(285, 105);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new Size(80, 32);
            this.btnChia.TabIndex = 6;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new EventHandler(this.btnChia_Click);
            //
            // frmBai1CongTru
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 165);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai1CongTru";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bài 1 - Cộng trừ nhân chia";
            this.FormClosing += new FormClosingEventHandler(this.frmBai1CongTru_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
