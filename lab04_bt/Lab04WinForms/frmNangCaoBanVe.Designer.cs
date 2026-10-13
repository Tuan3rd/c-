namespace Lab04WinForms
{
    partial class frmNangCaoBanVe
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

        private Label lblManAnh;
        private Panel pnlSoDoGhe;
        private Label lblThanhTienCaption;
        private TextBox txtThanhTien;
        private Button btnChon;
        private Button btnHuyBo;
        private Button btnKetThuc;

        private void InitializeComponent()
        {
            this.lblManAnh = new Label();
            this.pnlSoDoGhe = new Panel();
            this.lblThanhTienCaption = new Label();
            this.txtThanhTien = new TextBox();
            this.btnChon = new Button();
            this.btnHuyBo = new Button();
            this.btnKetThuc = new Button();
            this.SuspendLayout();
            //
            // lblManAnh
            //
            this.lblManAnh.BackColor = Color.Orange;
            this.lblManAnh.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            this.lblManAnh.ForeColor = Color.White;
            this.lblManAnh.Location = new Point(25, 15);
            this.lblManAnh.Name = "lblManAnh";
            this.lblManAnh.Size = new Size(400, 32);
            this.lblManAnh.Text = "MÀN ẢNH";
            this.lblManAnh.TextAlign = ContentAlignment.MiddleCenter;
            //
            // pnlSoDoGhe
            //
            this.pnlSoDoGhe.Location = new Point(25, 60);
            this.pnlSoDoGhe.Name = "pnlSoDoGhe";
            this.pnlSoDoGhe.Size = new Size(400, 150);
            //
            // lblThanhTienCaption
            //
            this.lblThanhTienCaption.Location = new Point(25, 225);
            this.lblThanhTienCaption.Name = "lblThanhTienCaption";
            this.lblThanhTienCaption.Size = new Size(90, 23);
            this.lblThanhTienCaption.Text = "Thành Tiền:";
            this.lblThanhTienCaption.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtThanhTien
            //
            this.txtThanhTien.Location = new Point(120, 222);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new Size(200, 23);
            this.txtThanhTien.TabStop = false;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextAlign = HorizontalAlignment.Right;
            //
            // btnChon
            //
            this.btnChon.Location = new Point(25, 265);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new Size(125, 32);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new EventHandler(this.btnChon_Click);
            //
            // btnHuyBo
            //
            this.btnHuyBo.Location = new Point(160, 265);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new Size(125, 32);
            this.btnHuyBo.TabIndex = 1;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new EventHandler(this.btnHuyBo_Click);
            //
            // btnKetThuc
            //
            this.btnKetThuc.Location = new Point(295, 265);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new Size(130, 32);
            this.btnKetThuc.TabIndex = 2;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new EventHandler(this.btnKetThuc_Click);
            //
            // frmNangCaoBanVe
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 320);
            this.Controls.Add(this.lblManAnh);
            this.Controls.Add(this.pnlSoDoGhe);
            this.Controls.Add(this.lblThanhTienCaption);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnKetThuc);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNangCaoBanVe";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Bán Vé Rạp Chiếu Bóng";
            this.FormClosing += new FormClosingEventHandler(this.frmNangCaoBanVe_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
