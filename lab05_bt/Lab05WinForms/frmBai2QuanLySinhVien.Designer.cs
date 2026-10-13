namespace Lab05WinForms
{
    partial class frmBai2QuanLySinhVien
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

        private TreeView trv_DS;
        private Label lblChonLop;
        private ComboBox cbo_ChonLop;

        private GroupBox grpThongTinSV;
        private Label lblMaSV;
        private TextBox txt_MaSV;
        private Label lblHoTen;
        private TextBox txt_HoTen;
        private Label lblDiaChi;
        private TextBox txt_DiaChi;
        private Button btn_CapNhat;
        private Button btn_Xoa;

        private CheckBox chk_ThemLop;
        private GroupBox grp_ThongTinLop;
        private Label lblTenLop;
        private TextBox txt_TenLop;
        private Button btn_ThemLop;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trv_DS = new TreeView();
            this.lblChonLop = new Label();
            this.cbo_ChonLop = new ComboBox();

            this.grpThongTinSV = new GroupBox();
            this.lblMaSV = new Label();
            this.txt_MaSV = new TextBox();
            this.lblHoTen = new Label();
            this.txt_HoTen = new TextBox();
            this.lblDiaChi = new Label();
            this.txt_DiaChi = new TextBox();
            this.btn_CapNhat = new Button();
            this.btn_Xoa = new Button();

            this.chk_ThemLop = new CheckBox();
            this.grp_ThongTinLop = new GroupBox();
            this.lblTenLop = new Label();
            this.txt_TenLop = new TextBox();
            this.btn_ThemLop = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpThongTinSV.SuspendLayout();
            this.grp_ThongTinLop.SuspendLayout();
            this.SuspendLayout();
            //
            // trv_DS
            //
            this.trv_DS.Location = new Point(20, 15);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new Size(260, 390);
            this.trv_DS.TabIndex = 0;
            this.trv_DS.AfterSelect += new TreeViewEventHandler(this.trv_DS_AfterSelect);
            //
            // lblChonLop
            //
            this.lblChonLop.Location = new Point(300, 15);
            this.lblChonLop.Name = "lblChonLop";
            this.lblChonLop.Size = new Size(80, 25);
            this.lblChonLop.Text = "Chọn Lớp";
            this.lblChonLop.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cbo_ChonLop
            //
            this.cbo_ChonLop.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_ChonLop.Location = new Point(385, 13);
            this.cbo_ChonLop.Name = "cbo_ChonLop";
            this.cbo_ChonLop.Size = new Size(245, 25);
            this.cbo_ChonLop.TabIndex = 1;
            //
            // grpThongTinSV
            //
            this.grpThongTinSV.Controls.Add(this.lblMaSV);
            this.grpThongTinSV.Controls.Add(this.txt_MaSV);
            this.grpThongTinSV.Controls.Add(this.lblHoTen);
            this.grpThongTinSV.Controls.Add(this.txt_HoTen);
            this.grpThongTinSV.Controls.Add(this.lblDiaChi);
            this.grpThongTinSV.Controls.Add(this.txt_DiaChi);
            this.grpThongTinSV.Controls.Add(this.btn_CapNhat);
            this.grpThongTinSV.Controls.Add(this.btn_Xoa);
            this.grpThongTinSV.Location = new Point(300, 50);
            this.grpThongTinSV.Name = "grpThongTinSV";
            this.grpThongTinSV.Size = new Size(330, 185);
            this.grpThongTinSV.TabStop = false;
            this.grpThongTinSV.Text = "Thông tin sinh viên";
            //
            // lblMaSV
            //
            this.lblMaSV.Location = new Point(15, 25);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new Size(70, 23);
            this.lblMaSV.Text = "Mã SV:";
            //
            // txt_MaSV
            //
            this.txt_MaSV.Location = new Point(90, 22);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new Size(220, 23);
            this.txt_MaSV.TabIndex = 0;
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new Point(15, 58);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(70, 23);
            this.lblHoTen.Text = "Họ Tên:";
            //
            // txt_HoTen
            //
            this.txt_HoTen.Location = new Point(90, 55);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new Size(220, 23);
            this.txt_HoTen.TabIndex = 1;
            //
            // lblDiaChi
            //
            this.lblDiaChi.Location = new Point(15, 91);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new Size(70, 23);
            this.lblDiaChi.Text = "Địa Chỉ";
            //
            // txt_DiaChi
            //
            this.txt_DiaChi.Location = new Point(90, 88);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new Size(220, 23);
            this.txt_DiaChi.TabIndex = 2;
            //
            // btn_CapNhat
            //
            this.btn_CapNhat.Location = new Point(90, 130);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new Size(100, 32);
            this.btn_CapNhat.TabIndex = 3;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new EventHandler(this.btn_CapNhat_Click);
            //
            // btn_Xoa
            //
            this.btn_Xoa.Location = new Point(210, 130);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new Size(100, 32);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new EventHandler(this.btn_Xoa_Click);
            //
            // chk_ThemLop
            //
            this.chk_ThemLop.Location = new Point(300, 245);
            this.chk_ThemLop.Name = "chk_ThemLop";
            this.chk_ThemLop.Size = new Size(150, 24);
            this.chk_ThemLop.TabIndex = 2;
            this.chk_ThemLop.Text = "Thêm lớp";
            this.chk_ThemLop.UseVisualStyleBackColor = true;
            this.chk_ThemLop.CheckedChanged += new EventHandler(this.chk_ThemLop_CheckedChanged);
            //
            // grp_ThongTinLop
            //
            this.grp_ThongTinLop.Controls.Add(this.lblTenLop);
            this.grp_ThongTinLop.Controls.Add(this.txt_TenLop);
            this.grp_ThongTinLop.Controls.Add(this.btn_ThemLop);
            this.grp_ThongTinLop.Location = new Point(300, 275);
            this.grp_ThongTinLop.Name = "grp_ThongTinLop";
            this.grp_ThongTinLop.Size = new Size(330, 70);
            this.grp_ThongTinLop.TabStop = false;
            this.grp_ThongTinLop.Text = "Thông tin lớp";
            this.grp_ThongTinLop.Visible = false;
            //
            // lblTenLop
            //
            this.lblTenLop.Location = new Point(15, 28);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new Size(65, 23);
            this.lblTenLop.Text = "Tên lớp";
            //
            // txt_TenLop
            //
            this.txt_TenLop.Location = new Point(85, 25);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new Size(145, 23);
            this.txt_TenLop.TabIndex = 0;
            //
            // btn_ThemLop
            //
            this.btn_ThemLop.Location = new Point(240, 23);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new Size(75, 28);
            this.btn_ThemLop.TabIndex = 1;
            this.btn_ThemLop.Text = "Thêm lớp";
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new EventHandler(this.btn_ThemLop_Click);
            //
            // frmBai2QuanLySinhVien
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(650, 420);
            this.Controls.Add(this.trv_DS);
            this.Controls.Add(this.lblChonLop);
            this.Controls.Add(this.cbo_ChonLop);
            this.Controls.Add(this.grpThongTinSV);
            this.Controls.Add(this.chk_ThemLop);
            this.Controls.Add(this.grp_ThongTinLop);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai2QuanLySinhVien";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Quản lý sinh viên";
            this.Load += new EventHandler(this.frmBai2QuanLySinhVien_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmBai2QuanLySinhVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpThongTinSV.ResumeLayout(false);
            this.grpThongTinSV.PerformLayout();
            this.grp_ThongTinLop.ResumeLayout(false);
            this.grp_ThongTinLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
