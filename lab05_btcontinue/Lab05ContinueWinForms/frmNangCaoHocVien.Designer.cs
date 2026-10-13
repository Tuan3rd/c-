namespace Lab05ContinueWinForms
{
    partial class frmNangCaoHocVien
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

        private MenuStrip menuChinh;
        private ToolStripMenuItem mnuCapNhat;
        private ToolStripMenuItem mnuNhapHocVienMoi;
        private ToolStripMenuItem mnuChuyenSangLopB;
        private ToolStripMenuItem mnuChuyenSangLopA;
        private ToolStripMenuItem mnuXoaHocVien;
        private ToolStripMenuItem mnuKetThuc;

        private Label lblLopA;
        private ListBox lstLopA;
        private Label lblLopB;
        private ListBox lstLopB;

        private void InitializeComponent()
        {
            this.menuChinh = new MenuStrip();
            this.mnuCapNhat = new ToolStripMenuItem();
            this.mnuNhapHocVienMoi = new ToolStripMenuItem();
            this.mnuChuyenSangLopB = new ToolStripMenuItem();
            this.mnuChuyenSangLopA = new ToolStripMenuItem();
            this.mnuXoaHocVien = new ToolStripMenuItem();
            this.mnuKetThuc = new ToolStripMenuItem();

            this.lblLopA = new Label();
            this.lstLopA = new ListBox();
            this.lblLopB = new Label();
            this.lstLopB = new ListBox();
            this.menuChinh.SuspendLayout();
            this.SuspendLayout();
            //
            // menuChinh
            //
            this.menuChinh.Items.AddRange(new ToolStripItem[] { this.mnuCapNhat, this.mnuKetThuc });
            this.menuChinh.Location = new Point(0, 0);
            this.menuChinh.Name = "menuChinh";
            this.menuChinh.Size = new Size(440, 28);
            this.menuChinh.TabIndex = 0;
            //
            // mnuCapNhat
            //
            this.mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] {
                this.mnuNhapHocVienMoi, this.mnuChuyenSangLopB, this.mnuChuyenSangLopA, this.mnuXoaHocVien });
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Text = "Cập nhật";
            //
            // mnuNhapHocVienMoi
            //
            this.mnuNhapHocVienMoi.Name = "mnuNhapHocVienMoi";
            this.mnuNhapHocVienMoi.Text = "Nhập học viên mới";
            this.mnuNhapHocVienMoi.Click += new EventHandler(this.mnuNhapHocVienMoi_Click);
            //
            // mnuChuyenSangLopB
            //
            this.mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
            this.mnuChuyenSangLopB.Text = "Chuyển sang lớp B";
            this.mnuChuyenSangLopB.Click += new EventHandler(this.mnuChuyenSangLopB_Click);
            //
            // mnuChuyenSangLopA
            //
            this.mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
            this.mnuChuyenSangLopA.Text = "Chuyển sang lớp A";
            this.mnuChuyenSangLopA.Click += new EventHandler(this.mnuChuyenSangLopA_Click);
            //
            // mnuXoaHocVien
            //
            this.mnuXoaHocVien.Name = "mnuXoaHocVien";
            this.mnuXoaHocVien.Text = "Xóa học viên";
            this.mnuXoaHocVien.Click += new EventHandler(this.mnuXoaHocVien_Click);
            //
            // mnuKetThuc
            //
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Text = "Kết thúc";
            this.mnuKetThuc.Click += new EventHandler(this.mnuKetThuc_Click);
            //
            // lblLopA
            //
            this.lblLopA.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            this.lblLopA.Location = new Point(20, 40);
            this.lblLopA.Name = "lblLopA";
            this.lblLopA.Size = new Size(100, 23);
            this.lblLopA.Text = "Lớp A";
            //
            // lstLopA
            //
            this.lstLopA.SelectionMode = SelectionMode.MultiExtended;
            this.lstLopA.Location = new Point(20, 65);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.Size = new Size(180, 260);
            this.lstLopA.TabIndex = 1;
            //
            // lblLopB
            //
            this.lblLopB.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            this.lblLopB.Location = new Point(230, 40);
            this.lblLopB.Name = "lblLopB";
            this.lblLopB.Size = new Size(100, 23);
            this.lblLopB.Text = "Lớp B";
            //
            // lstLopB
            //
            this.lstLopB.SelectionMode = SelectionMode.MultiExtended;
            this.lstLopB.Location = new Point(230, 65);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new Size(180, 260);
            this.lstLopB.TabIndex = 2;
            //
            // frmNangCaoHocVien
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(440, 345);
            this.Controls.Add(this.lblLopA);
            this.Controls.Add(this.lstLopA);
            this.Controls.Add(this.lblLopB);
            this.Controls.Add(this.lstLopB);
            this.Controls.Add(this.menuChinh);
            this.MainMenuStrip = this.menuChinh;
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNangCaoHocVien";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý học viên";
            this.menuChinh.ResumeLayout(false);
            this.menuChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
