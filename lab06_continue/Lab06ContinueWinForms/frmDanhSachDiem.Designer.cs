namespace Lab06ContinueWinForms
{
    partial class frmDanhSachDiem
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

        private Label lblMaMh;
        private ComboBox cboMaMh;
        private Button btnLoc;
        private ListView lvDanhSach;
        private ColumnHeader colTenSV;
        private ColumnHeader colNgaySinh;
        private ColumnHeader colTenMonHoc;
        private ColumnHeader colDiemSo;
        private Label lblTongDiem;
        private TextBox txtTongDiem;

        private void InitializeComponent()
        {
            this.lblMaMh = new Label();
            this.cboMaMh = new ComboBox();
            this.btnLoc = new Button();
            this.lvDanhSach = new ListView();
            this.colTenSV = new ColumnHeader();
            this.colNgaySinh = new ColumnHeader();
            this.colTenMonHoc = new ColumnHeader();
            this.colDiemSo = new ColumnHeader();
            this.lblTongDiem = new Label();
            this.txtTongDiem = new TextBox();
            this.SuspendLayout();
            //
            // lblMaMh
            //
            this.lblMaMh.Location = new Point(20, 20);
            this.lblMaMh.Name = "lblMaMh";
            this.lblMaMh.Size = new Size(90, 23);
            this.lblMaMh.Text = "Lọc theo môn";
            //
            // cboMaMh
            //
            this.cboMaMh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboMaMh.Location = new Point(115, 17);
            this.cboMaMh.Name = "cboMaMh";
            this.cboMaMh.Size = new Size(180, 23);
            this.cboMaMh.TabIndex = 0;
            //
            // btnLoc
            //
            this.btnLoc.Location = new Point(310, 16);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new Size(120, 26);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc dữ liệu";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new EventHandler(this.btnLoc_Click);
            //
            // lvDanhSach
            //
            this.lvDanhSach.View = View.Details;
            this.lvDanhSach.FullRowSelect = true;
            this.lvDanhSach.GridLines = true;
            this.lvDanhSach.Location = new Point(20, 55);
            this.lvDanhSach.Name = "lvDanhSach";
            this.lvDanhSach.Size = new Size(540, 260);
            this.lvDanhSach.Columns.AddRange(new ColumnHeader[] {
                this.colTenSV, this.colNgaySinh, this.colTenMonHoc, this.colDiemSo });
            //
            // colTenSV
            //
            this.colTenSV.Text = "Họ tên SV";
            this.colTenSV.Width = 160;
            //
            // colNgaySinh
            //
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 100;
            //
            // colTenMonHoc
            //
            this.colTenMonHoc.Text = "Môn học";
            this.colTenMonHoc.Width = 160;
            //
            // colDiemSo
            //
            this.colDiemSo.Text = "Điểm";
            this.colDiemSo.Width = 80;
            //
            // lblTongDiem
            //
            this.lblTongDiem.Location = new Point(20, 325);
            this.lblTongDiem.Name = "lblTongDiem";
            this.lblTongDiem.Size = new Size(90, 23);
            this.lblTongDiem.Text = "Tổng điểm";
            //
            // txtTongDiem
            //
            this.txtTongDiem.Location = new Point(115, 322);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new Size(120, 23);
            this.txtTongDiem.TabIndex = 2;
            //
            // frmDanhSachDiem
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(580, 365);
            this.Controls.Add(this.lblMaMh);
            this.Controls.Add(this.cboMaMh);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.lvDanhSach);
            this.Controls.Add(this.lblTongDiem);
            this.Controls.Add(this.txtTongDiem);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachDiem";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Danh sách Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
