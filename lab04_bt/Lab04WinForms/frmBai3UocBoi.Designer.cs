namespace Lab04WinForms
{
    partial class frmBai3UocBoi
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
        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label lblUCLN;
        private TextBox txtUCLN;
        private Label lblBCNN;
        private TextBox txtBCNN;
        private Button btnThucHien;
        private Button btnTiepTuc;
        private Button btnThoat;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblA = new Label();
            this.txtA = new TextBox();
            this.lblB = new Label();
            this.txtB = new TextBox();
            this.lblUCLN = new Label();
            this.txtUCLN = new TextBox();
            this.lblBCNN = new Label();
            this.txtBCNN = new TextBox();
            this.btnThucHien = new Button();
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
            this.lblTieuDe.Size = new Size(380, 28);
            this.lblTieuDe.Text = "Ước Số Chung - Bội Số Chung";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblA
            //
            this.lblA.Location = new Point(30, 60);
            this.lblA.Name = "lblA";
            this.lblA.Size = new Size(110, 23);
            this.lblA.Text = "Nhập số a :";
            this.lblA.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtA
            //
            this.txtA.Location = new Point(150, 57);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(150, 23);
            this.txtA.TabIndex = 0;
            //
            // lblB
            //
            this.lblB.Location = new Point(30, 95);
            this.lblB.Name = "lblB";
            this.lblB.Size = new Size(110, 23);
            this.lblB.Text = "Nhập số b :";
            this.lblB.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtB
            //
            this.txtB.Location = new Point(150, 92);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(150, 23);
            this.txtB.TabIndex = 1;
            //
            // lblUCLN
            //
            this.lblUCLN.Location = new Point(30, 130);
            this.lblUCLN.Name = "lblUCLN";
            this.lblUCLN.Size = new Size(150, 23);
            this.lblUCLN.Text = "Ước số chung lớn nhất :";
            this.lblUCLN.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtUCLN
            //
            this.txtUCLN.Location = new Point(190, 127);
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.ReadOnly = true;
            this.txtUCLN.Size = new Size(110, 23);
            this.txtUCLN.TabIndex = 2;
            this.txtUCLN.TabStop = false;
            //
            // lblBCNN
            //
            this.lblBCNN.Location = new Point(30, 165);
            this.lblBCNN.Name = "lblBCNN";
            this.lblBCNN.Size = new Size(150, 23);
            this.lblBCNN.Text = "Bội số chung nhỏ nhất :";
            this.lblBCNN.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtBCNN
            //
            this.txtBCNN.Location = new Point(190, 162);
            this.txtBCNN.Name = "txtBCNN";
            this.txtBCNN.ReadOnly = true;
            this.txtBCNN.Size = new Size(110, 23);
            this.txtBCNN.TabIndex = 3;
            this.txtBCNN.TabStop = false;
            //
            // btnThucHien
            //
            this.btnThucHien.Location = new Point(30, 205);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new Size(110, 32);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new EventHandler(this.btnThucHien_Click);
            //
            // btnTiepTuc
            //
            this.btnTiepTuc.Location = new Point(150, 205);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new Size(110, 32);
            this.btnTiepTuc.TabIndex = 5;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new EventHandler(this.btnTiepTuc_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(270, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(110, 32);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmBai3UocBoi
            //
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(420, 260);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblUCLN);
            this.Controls.Add(this.txtUCLN);
            this.Controls.Add(this.lblBCNN);
            this.Controls.Add(this.txtBCNN);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai3UocBoi";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bài 3 - Ước Số - Bội Số";
            this.FormClosing += new FormClosingEventHandler(this.frmBai3UocBoi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
