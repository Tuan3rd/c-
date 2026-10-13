namespace Lab04WinForms
{
    partial class frmBtvnMayTinh
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
        private TextBox txtManHinh;
        private Panel pnlPhim;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.txtManHinh = new TextBox();
            this.pnlPhim = new Panel();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(320, 34);
            this.lblTieuDe.Text = "Máy Tính Bỏ Túi";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // txtManHinh
            //
            this.txtManHinh.Font = new Font("Consolas", 14F);
            this.txtManHinh.Location = new Point(20, 60);
            this.txtManHinh.Name = "txtManHinh";
            this.txtManHinh.ReadOnly = true;
            this.txtManHinh.Size = new Size(320, 30);
            this.txtManHinh.TabStop = false;
            this.txtManHinh.Text = "0";
            this.txtManHinh.TextAlign = HorizontalAlignment.Right;
            //
            // pnlPhim
            //
            this.pnlPhim.Location = new Point(20, 100);
            this.pnlPhim.Name = "pnlPhim";
            this.pnlPhim.Size = new Size(320, 220);
            //
            // frmBtvnMayTinh
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 340);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.txtManHinh);
            this.Controls.Add(this.pnlPhim);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBtvnMayTinh";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Máy Tính Bỏ Túi";
            this.FormClosing += new FormClosingEventHandler(this.frmBtvnMayTinh_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
