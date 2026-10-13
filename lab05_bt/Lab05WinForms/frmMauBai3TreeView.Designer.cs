namespace Lab05WinForms
{
    partial class frmMauBai3TreeView
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

        private Label lblPhongBanTitle;
        private TreeView trv_DS;
        private Label lblPhongBan;
        private TextBox txt_Phongban;
        private Button btn_ThemPB;
        private Button btn_XoaPB;

        private Label lblHoSoTitle;
        private Label lblMaSo;
        private TextBox txt_maso;
        private Label lblHoTen;
        private TextBox txt_hoten;
        private Label lblDiaChi;
        private TextBox txt_diachi;
        private Label lblPhongBanCbo;
        private ComboBox cbo_phongban;
        private Button btn_ThemNV;
        private Button btn_Thoat;

        private void InitializeComponent()
        {
            this.lblPhongBanTitle = new Label();
            this.trv_DS = new TreeView();
            this.lblPhongBan = new Label();
            this.txt_Phongban = new TextBox();
            this.btn_ThemPB = new Button();
            this.btn_XoaPB = new Button();

            this.lblHoSoTitle = new Label();
            this.lblMaSo = new Label();
            this.txt_maso = new TextBox();
            this.lblHoTen = new Label();
            this.txt_hoten = new TextBox();
            this.lblDiaChi = new Label();
            this.txt_diachi = new TextBox();
            this.lblPhongBanCbo = new Label();
            this.cbo_phongban = new ComboBox();
            this.btn_ThemNV = new Button();
            this.btn_Thoat = new Button();
            this.SuspendLayout();
            //
            // lblPhongBanTitle
            //
            this.lblPhongBanTitle.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            this.lblPhongBanTitle.Location = new Point(20, 15);
            this.lblPhongBanTitle.Name = "lblPhongBanTitle";
            this.lblPhongBanTitle.Size = new Size(150, 23);
            this.lblPhongBanTitle.Text = "Phòng ban";
            //
            // trv_DS
            //
            this.trv_DS.Location = new Point(20, 42);
            this.trv_DS.Name = "trv_DS";
            this.trv_DS.Size = new Size(260, 230);
            this.trv_DS.TabIndex = 0;
            //
            // lblPhongBan
            //
            this.lblPhongBan.Location = new Point(20, 282);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new Size(70, 23);
            this.lblPhongBan.Text = "Phòng ban";
            //
            // txt_Phongban
            //
            this.txt_Phongban.Location = new Point(95, 279);
            this.txt_Phongban.Name = "txt_Phongban";
            this.txt_Phongban.Size = new Size(185, 23);
            this.txt_Phongban.TabIndex = 1;
            //
            // btn_ThemPB
            //
            this.btn_ThemPB.Location = new Point(20, 312);
            this.btn_ThemPB.Name = "btn_ThemPB";
            this.btn_ThemPB.Size = new Size(260, 30);
            this.btn_ThemPB.TabIndex = 2;
            this.btn_ThemPB.Text = "Thêm phòng ban";
            this.btn_ThemPB.UseVisualStyleBackColor = true;
            this.btn_ThemPB.Click += new EventHandler(this.btn_ThemPB_Click);
            //
            // btn_XoaPB
            //
            this.btn_XoaPB.Location = new Point(20, 347);
            this.btn_XoaPB.Name = "btn_XoaPB";
            this.btn_XoaPB.Size = new Size(260, 30);
            this.btn_XoaPB.TabIndex = 3;
            this.btn_XoaPB.Text = "Xóa phòng ban";
            this.btn_XoaPB.UseVisualStyleBackColor = true;
            this.btn_XoaPB.Click += new EventHandler(this.btn_XoaPB_Click);
            //
            // lblHoSoTitle
            //
            this.lblHoSoTitle.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            this.lblHoSoTitle.ForeColor = Color.RoyalBlue;
            this.lblHoSoTitle.Location = new Point(310, 15);
            this.lblHoSoTitle.Name = "lblHoSoTitle";
            this.lblHoSoTitle.Size = new Size(320, 30);
            this.lblHoSoTitle.Text = "HỒ SƠ NHÂN VIÊN";
            //
            // lblMaSo
            //
            this.lblMaSo.Location = new Point(310, 58);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new Size(55, 23);
            this.lblMaSo.Text = "Mã số";
            //
            // txt_maso
            //
            this.txt_maso.Location = new Point(370, 55);
            this.txt_maso.Name = "txt_maso";
            this.txt_maso.Size = new Size(100, 23);
            this.txt_maso.TabIndex = 4;
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new Point(480, 58);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(55, 23);
            this.lblHoTen.Text = "Họ tên";
            //
            // txt_hoten
            //
            this.txt_hoten.Location = new Point(540, 55);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new Size(90, 23);
            this.txt_hoten.TabIndex = 5;
            //
            // lblDiaChi
            //
            this.lblDiaChi.Location = new Point(310, 93);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new Size(60, 23);
            this.lblDiaChi.Text = "Địa chỉ";
            //
            // txt_diachi
            //
            this.txt_diachi.Location = new Point(375, 90);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new Size(255, 23);
            this.txt_diachi.TabIndex = 6;
            //
            // lblPhongBanCbo
            //
            this.lblPhongBanCbo.Location = new Point(310, 128);
            this.lblPhongBanCbo.Name = "lblPhongBanCbo";
            this.lblPhongBanCbo.Size = new Size(70, 23);
            this.lblPhongBanCbo.Text = "Phòng ban";
            //
            // cbo_phongban
            //
            this.cbo_phongban.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_phongban.Location = new Point(375, 125);
            this.cbo_phongban.Name = "cbo_phongban";
            this.cbo_phongban.Size = new Size(255, 25);
            this.cbo_phongban.TabIndex = 7;
            //
            // btn_ThemNV
            //
            this.btn_ThemNV.Location = new Point(375, 165);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new Size(90, 32);
            this.btn_ThemNV.TabIndex = 8;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = true;
            this.btn_ThemNV.Click += new EventHandler(this.btn_ThemNV_Click);
            //
            // btn_Thoat
            //
            this.btn_Thoat.Location = new Point(475, 165);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new Size(90, 32);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new EventHandler(this.btn_Thoat_Click);
            //
            // frmMauBai3TreeView
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(650, 400);
            this.Controls.Add(this.lblPhongBanTitle);
            this.Controls.Add(this.trv_DS);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.txt_Phongban);
            this.Controls.Add(this.btn_ThemPB);
            this.Controls.Add(this.btn_XoaPB);
            this.Controls.Add(this.lblHoSoTitle);
            this.Controls.Add(this.lblMaSo);
            this.Controls.Add(this.txt_maso);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.lblPhongBanCbo);
            this.Controls.Add(this.cbo_phongban);
            this.Controls.Add(this.btn_ThemNV);
            this.Controls.Add(this.btn_Thoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai3TreeView";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "TreeView";
            this.Load += new EventHandler(this.frmMauBai3TreeView_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai3TreeView_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
