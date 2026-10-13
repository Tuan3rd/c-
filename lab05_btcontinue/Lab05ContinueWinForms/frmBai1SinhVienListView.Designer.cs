namespace Lab05ContinueWinForms
{
    partial class frmBai1SinhVienListView
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

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label lblNgoaiNgu;
        private CheckBox chkAnh;
        private CheckBox chkPhap;
        private CheckBox chkHoa;
        private Label lblDanToc;
        private ComboBox cboDanToc;

        private ListView lstv1;
        private ColumnHeader colHoTen;
        private ColumnHeader colMaSV;
        private ColumnHeader colGioiTinh;
        private ColumnHeader colNgoaiNgu;
        private ColumnHeader colDanToc;

        private ContextMenuStrip ctxListView;
        private ToolStripMenuItem mnuXoaContext;

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;

        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new Label();
            this.txtHoTen = new TextBox();
            this.lblMaSV = new Label();
            this.txtMaSV = new TextBox();
            this.lblGioiTinh = new Label();
            this.rdoNam = new RadioButton();
            this.rdoNu = new RadioButton();
            this.lblNgoaiNgu = new Label();
            this.chkAnh = new CheckBox();
            this.chkPhap = new CheckBox();
            this.chkHoa = new CheckBox();
            this.lblDanToc = new Label();
            this.cboDanToc = new ComboBox();

            this.lstv1 = new ListView();
            this.colHoTen = new ColumnHeader();
            this.colMaSV = new ColumnHeader();
            this.colGioiTinh = new ColumnHeader();
            this.colNgoaiNgu = new ColumnHeader();
            this.colDanToc = new ColumnHeader();

            this.ctxListView = new ContextMenuStrip(this.components);
            this.mnuXoaContext = new ToolStripMenuItem();

            this.btnThem = new Button();
            this.btnXoa = new Button();
            this.btnSua = new Button();

            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ctxListView.SuspendLayout();
            this.SuspendLayout();
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new Point(20, 15);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(90, 23);
            this.lblHoTen.Text = "Họ và Tên";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new Point(120, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new Size(250, 23);
            this.txtHoTen.TabIndex = 0;
            //
            // lblMaSV
            //
            this.lblMaSV.Location = new Point(20, 45);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new Size(90, 23);
            this.lblMaSV.Text = "Mã sinh viên";
            //
            // txtMaSV
            //
            this.txtMaSV.Location = new Point(120, 42);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new Size(250, 23);
            this.txtMaSV.TabIndex = 1;
            //
            // lblGioiTinh
            //
            this.lblGioiTinh.Location = new Point(20, 75);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new Size(90, 23);
            this.lblGioiTinh.Text = "Giới tính";
            //
            // rdoNam
            //
            this.rdoNam.Checked = true;
            this.rdoNam.Location = new Point(120, 73);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new Size(70, 24);
            this.rdoNam.TabIndex = 2;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            //
            // rdoNu
            //
            this.rdoNu.Location = new Point(195, 73);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new Size(70, 24);
            this.rdoNu.TabIndex = 3;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            //
            // lblNgoaiNgu
            //
            this.lblNgoaiNgu.Location = new Point(20, 105);
            this.lblNgoaiNgu.Name = "lblNgoaiNgu";
            this.lblNgoaiNgu.Size = new Size(90, 23);
            this.lblNgoaiNgu.Text = "Ngoại ngữ";
            //
            // chkAnh
            //
            this.chkAnh.Checked = true;
            this.chkAnh.Location = new Point(120, 103);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new Size(70, 24);
            this.chkAnh.TabIndex = 4;
            this.chkAnh.Text = "Anh";
            this.chkAnh.UseVisualStyleBackColor = true;
            //
            // chkPhap
            //
            this.chkPhap.Location = new Point(195, 103);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new Size(70, 24);
            this.chkPhap.TabIndex = 5;
            this.chkPhap.Text = "Pháp";
            this.chkPhap.UseVisualStyleBackColor = true;
            //
            // chkHoa
            //
            this.chkHoa.Location = new Point(270, 103);
            this.chkHoa.Name = "chkHoa";
            this.chkHoa.Size = new Size(70, 24);
            this.chkHoa.TabIndex = 6;
            this.chkHoa.Text = "Hoa";
            this.chkHoa.UseVisualStyleBackColor = true;
            //
            // lblDanToc
            //
            this.lblDanToc.Location = new Point(20, 135);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new Size(90, 23);
            this.lblDanToc.Text = "Dân tộc";
            //
            // cboDanToc
            //
            this.cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDanToc.Location = new Point(120, 132);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new Size(250, 25);
            this.cboDanToc.TabIndex = 7;
            //
            // lstv1
            //
            this.lstv1.Columns.AddRange(new ColumnHeader[] {
                this.colHoTen, this.colMaSV, this.colGioiTinh, this.colNgoaiNgu, this.colDanToc });
            this.lstv1.ContextMenuStrip = this.ctxListView;
            this.lstv1.FullRowSelect = true;
            this.lstv1.GridLines = true;
            this.lstv1.Location = new Point(20, 200);
            this.lstv1.MultiSelect = true;
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new Size(540, 200);
            this.lstv1.TabIndex = 9;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = View.Details;
            //
            // colHoTen
            //
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 130;
            //
            // colMaSV
            //
            this.colMaSV.Text = "Mã sinh viên";
            this.colMaSV.Width = 90;
            //
            // colGioiTinh
            //
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 70;
            //
            // colNgoaiNgu
            //
            this.colNgoaiNgu.Text = "Ngoại ngữ";
            this.colNgoaiNgu.Width = 120;
            //
            // colDanToc
            //
            this.colDanToc.Text = "Dân tộc";
            this.colDanToc.Width = 90;
            //
            // ctxListView
            //
            this.ctxListView.Items.AddRange(new ToolStripItem[] { this.mnuXoaContext });
            this.ctxListView.Name = "ctxListView";
            this.ctxListView.Size = new Size(100, 26);
            //
            // mnuXoaContext
            //
            this.mnuXoaContext.Name = "mnuXoaContext";
            this.mnuXoaContext.Text = "Xóa";
            this.mnuXoaContext.Click += new EventHandler(this.mnuXoaContext_Click);
            //
            // btnThem
            //
            this.btnThem.Location = new Point(140, 410);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(100, 32);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(250, 410);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(100, 32);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new Point(360, 410);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(100, 32);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new EventHandler(this.btnSua_Click);
            //
            // frmBai1SinhVienListView
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(580, 460);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.lblNgoaiNgu);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkHoa);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.cboDanToc);
            this.Controls.Add(this.lstv1);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai1SinhVienListView";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmBaitap1";
            this.Load += new EventHandler(this.frmBai1SinhVienListView_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmBai1SinhVienListView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ctxListView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
