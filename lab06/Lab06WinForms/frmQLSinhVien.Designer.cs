namespace Lab06WinForms
{
    partial class frmQLSinhVien
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

        private Label lblMaLop;
        private TextBox txtMaLop;
        private Label lblMaSv;
        private TextBox txtMaSv;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private TextBox txtNgaySinh;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMaLop = new Label();
            this.txtMaLop = new TextBox();
            this.lblMaSv = new Label();
            this.txtMaSv = new TextBox();
            this.lblHoTen = new Label();
            this.txtHoTen = new TextBox();
            this.lblNgaySinh = new Label();
            this.txtNgaySinh = new TextBox();
            this.btnThem = new Button();
            this.btnXoa = new Button();
            this.btnSua = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblMaLop
            //
            this.lblMaLop.Location = new Point(20, 20);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new Size(80, 23);
            this.lblMaLop.Text = "Mã lớp";
            //
            // txtMaLop
            //
            this.txtMaLop.Location = new Point(110, 17);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new Size(220, 23);
            this.txtMaLop.TabIndex = 0;
            //
            // lblMaSv
            //
            this.lblMaSv.Location = new Point(20, 55);
            this.lblMaSv.Name = "lblMaSv";
            this.lblMaSv.Size = new Size(80, 23);
            this.lblMaSv.Text = "Mã sv";
            //
            // txtMaSv
            //
            this.txtMaSv.Location = new Point(110, 52);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new Size(220, 23);
            this.txtMaSv.TabIndex = 1;
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new Point(20, 90);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(80, 23);
            this.lblHoTen.Text = "Họ tên";
            //
            // txtHoTen
            //
            this.txtHoTen.Location = new Point(110, 87);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new Size(220, 23);
            this.txtHoTen.TabIndex = 2;
            //
            // lblNgaySinh
            //
            this.lblNgaySinh.Location = new Point(20, 125);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new Size(80, 23);
            this.lblNgaySinh.Text = "Ngày sinh";
            //
            // txtNgaySinh
            //
            this.txtNgaySinh.Location = new Point(110, 122);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.PlaceholderText = "dd/MM/yyyy";
            this.txtNgaySinh.Size = new Size(220, 23);
            this.txtNgaySinh.TabIndex = 3;
            //
            // btnThem
            //
            this.btnThem.Location = new Point(40, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(85, 32);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(145, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(85, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // btnSua
            //
            this.btnSua.Location = new Point(250, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new Size(85, 32);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new EventHandler(this.btnSua_Click);
            //
            // frmQLSinhVien
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(370, 220);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lblMaSv);
            this.Controls.Add(this.txtMaSv);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQLSinhVien";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
