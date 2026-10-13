namespace Lab06ContinueWinForms
{
    partial class frmDanhSachLop
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

        private ListView lvDanhSach;
        private ColumnHeader colMaLop;
        private ColumnHeader colTenLop;
        private ColumnHeader colMaKhoa;
        private ColumnHeader colTenKhoa;
        private Button btnHienThi;
        private Button btnThoat;

        private void InitializeComponent()
        {
            this.lvDanhSach = new ListView();
            this.colMaLop = new ColumnHeader();
            this.colTenLop = new ColumnHeader();
            this.colMaKhoa = new ColumnHeader();
            this.colTenKhoa = new ColumnHeader();
            this.btnHienThi = new Button();
            this.btnThoat = new Button();
            this.SuspendLayout();
            //
            // lvDanhSach
            //
            this.lvDanhSach.View = View.Details;
            this.lvDanhSach.FullRowSelect = true;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.Location = new Point(20, 20);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new Size(500, 250);
            this.lvDanhSach.Columns.AddRange(new ColumnHeader[] {
                this.colMaLop, this.colTenLop, this.colMaKhoa, this.colTenKhoa });
            //
            // colMaLop
            //
            this.colMaLop.Text = "Mã lớp";
            this.colMaLop.Width = 100;
            //
            // colTenLop
            //
            this.colTenLop.Text = "Tên lớp";
            this.colTenLop.Width = 150;
            //
            // colMaKhoa
            //
            this.colMaKhoa.Text = "Mã khoa";
            this.colMaKhoa.Width = 80;
            //
            // colTenKhoa
            //
            this.colTenKhoa.Text = "Tên khoa";
            this.colTenKhoa.Width = 160;
            //
            // btnHienThi
            //
            this.btnHienThi.Location = new Point(20, 285);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new Size(150, 32);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hiển thị dữ liệu";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new EventHandler(this.btnHienThi_Click);
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(370, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(150, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmDanhSachLop
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(540, 335);
            this.Controls.Add(this.lvDanhSach);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachLop";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Danh sách Lớp";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
