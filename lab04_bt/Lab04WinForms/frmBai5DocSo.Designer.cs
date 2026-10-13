namespace Lab04WinForms
{
    partial class frmBai5DocSo
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
        private Button btnThucHien;
        private Button btnXoa;
        private Button btnThoat;
        private Label lblKetQua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblNhapSo = new Label();
            this.txtNhapSo = new TextBox();
            this.btnThucHien = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.lblKetQua = new Label();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(430, 34);
            this.lblTieuDe.Text = "Đọc Số Thành Chữ";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblNhapSo
            //
            this.lblNhapSo.Location = new Point(25, 65);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new Size(220, 23);
            this.lblNhapSo.Text = "Nhập dãy số : ( từ 1 đến 999 )";
            this.lblNhapSo.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtNhapSo
            //
            this.txtNhapSo.Location = new Point(250, 62);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new Size(120, 23);
            this.txtNhapSo.TabIndex = 0;
            //
            // btnThucHien
            //
            this.btnThucHien.Location = new Point(25, 105);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new Size(110, 32);
            this.btnThucHien.TabIndex = 1;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new EventHandler(this.btnThucHien_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(145, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(110, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(265, 105);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(110, 32);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // lblKetQua
            //
            this.lblKetQua.BackColor = Color.Cornsilk;
            this.lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            this.lblKetQua.ForeColor = Color.Blue;
            this.lblKetQua.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            this.lblKetQua.Location = new Point(25, 150);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new Size(350, 40);
            this.lblKetQua.TextAlign = ContentAlignment.MiddleLeft;
            //
            // frmBai5DocSo
            //
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 210);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKetQua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai5DocSo";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bài 5 - Đọc Chữ Số";
            this.FormClosing += new FormClosingEventHandler(this.frmBai5DocSo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
