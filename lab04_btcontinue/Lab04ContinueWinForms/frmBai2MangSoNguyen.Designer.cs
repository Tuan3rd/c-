namespace Lab04ContinueWinForms
{
    partial class frmBai2MangSoNguyen
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
        private Button btnNhapMang;
        private TextBox txtNhapMang;
        private Button btnReset;
        private Label lblKetQuaMangCaption;
        private TextBox txtKetQuaMang;
        private Button btnThoat;
        private Button btnThucHien;
        private GroupBox grpSapXep;
        private RadioButton rdoTang;
        private RadioButton rdoGiam;

        private GroupBox grpTimKiem;
        private RadioButton rdoTimGiaTri;
        private TextBox txtTimGiaTri;
        private RadioButton rdoTimViTri;
        private TextBox txtTimViTri;
        private Label lblSoTimDuoc;
        private TextBox txtSoTimDuoc;
        private Button btnTim;

        private GroupBox grpXoa;
        private RadioButton rdoXoaGiaTri;
        private TextBox txtXoaGiaTri;
        private RadioButton rdoXoaViTri;
        private TextBox txtXoaViTri;
        private Label lblCanSapXepTang1;
        private Button btnXoa;

        private GroupBox grpThem;
        private Label lblThemGiaTri;
        private TextBox txtThemGiaTri;
        private Label lblThemViTri;
        private TextBox txtThemViTri;
        private Label lblCanSapXepTang2;
        private Button btnThem;

        private GroupBox grpTong;
        private Label lblTongMang;
        private TextBox txtTongMang;
        private Label lblTongChan;
        private TextBox txtTongChan;
        private Label lblTongLe;
        private TextBox txtTongLe;
        private Button btnTong;

        private GroupBox grpMaxMin;
        private Label lblMax;
        private TextBox txtMax;
        private Label lblMin;
        private TextBox txtMin;
        private Button btnTimMaxMin;

        private GroupBox grpThayThe;
        private RadioButton rdoThayTheGiaTri;
        private RadioButton rdoThayTheViTri;
        private TextBox txtThayTheChiTieu;
        private Label lblSoThayThe;
        private TextBox txtSoThayThe;
        private Button btnThayThe;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.btnNhapMang = new Button();
            this.txtNhapMang = new TextBox();
            this.btnReset = new Button();
            this.lblKetQuaMangCaption = new Label();
            this.txtKetQuaMang = new TextBox();
            this.btnThoat = new Button();
            this.btnThucHien = new Button();
            this.grpSapXep = new GroupBox();
            this.rdoTang = new RadioButton();
            this.rdoGiam = new RadioButton();

            this.grpTimKiem = new GroupBox();
            this.rdoTimGiaTri = new RadioButton();
            this.txtTimGiaTri = new TextBox();
            this.rdoTimViTri = new RadioButton();
            this.txtTimViTri = new TextBox();
            this.lblSoTimDuoc = new Label();
            this.txtSoTimDuoc = new TextBox();
            this.btnTim = new Button();

            this.grpXoa = new GroupBox();
            this.rdoXoaGiaTri = new RadioButton();
            this.txtXoaGiaTri = new TextBox();
            this.rdoXoaViTri = new RadioButton();
            this.txtXoaViTri = new TextBox();
            this.lblCanSapXepTang1 = new Label();
            this.btnXoa = new Button();

            this.grpThem = new GroupBox();
            this.lblThemGiaTri = new Label();
            this.txtThemGiaTri = new TextBox();
            this.lblThemViTri = new Label();
            this.txtThemViTri = new TextBox();
            this.lblCanSapXepTang2 = new Label();
            this.btnThem = new Button();

            this.grpTong = new GroupBox();
            this.lblTongMang = new Label();
            this.txtTongMang = new TextBox();
            this.lblTongChan = new Label();
            this.txtTongChan = new TextBox();
            this.lblTongLe = new Label();
            this.txtTongLe = new TextBox();
            this.btnTong = new Button();

            this.grpMaxMin = new GroupBox();
            this.lblMax = new Label();
            this.txtMax = new TextBox();
            this.lblMin = new Label();
            this.txtMin = new TextBox();
            this.btnTimMaxMin = new Button();

            this.grpThayThe = new GroupBox();
            this.rdoThayTheGiaTri = new RadioButton();
            this.rdoThayTheViTri = new RadioButton();
            this.txtThayTheChiTieu = new TextBox();
            this.lblSoThayThe = new Label();
            this.txtSoThayThe = new TextBox();
            this.btnThayThe = new Button();

            this.grpSapXep.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.grpXoa.SuspendLayout();
            this.grpThem.SuspendLayout();
            this.grpTong.SuspendLayout();
            this.grpMaxMin.SuspendLayout();
            this.grpThayThe.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkRed;
            this.lblTieuDe.Location = new Point(15, 10);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(520, 28);
            this.lblTieuDe.Text = "Mảng Số Nguyên";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnNhapMang
            //
            this.btnNhapMang.Location = new Point(15, 48);
            this.btnNhapMang.Name = "btnNhapMang";
            this.btnNhapMang.Size = new Size(110, 25);
            this.btnNhapMang.TabIndex = 0;
            this.btnNhapMang.Text = "Nhập mảng :";
            this.btnNhapMang.UseVisualStyleBackColor = true;
            this.btnNhapMang.Click += new EventHandler(this.btnNhapMang_Click);
            //
            // txtNhapMang
            //
            this.txtNhapMang.Location = new Point(130, 50);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new Size(290, 23);
            this.txtNhapMang.TabIndex = 1;
            //
            // btnReset
            //
            this.btnReset.Location = new Point(430, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(90, 25);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            //
            // lblKetQuaMangCaption
            //
            this.lblKetQuaMangCaption.Location = new Point(15, 80);
            this.lblKetQuaMangCaption.Name = "lblKetQuaMangCaption";
            this.lblKetQuaMangCaption.Size = new Size(110, 23);
            this.lblKetQuaMangCaption.Text = "Kết quả mảng :";
            this.lblKetQuaMangCaption.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtKetQuaMang
            //
            this.txtKetQuaMang.Location = new Point(130, 78);
            this.txtKetQuaMang.Name = "txtKetQuaMang";
            this.txtKetQuaMang.ReadOnly = true;
            this.txtKetQuaMang.Size = new Size(290, 23);
            this.txtKetQuaMang.TabIndex = 3;
            this.txtKetQuaMang.TabStop = false;
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(430, 78);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(90, 25);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // btnThucHien
            //
            this.btnThucHien.Location = new Point(15, 113);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new Size(110, 45);
            this.btnThucHien.TabIndex = 5;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new EventHandler(this.btnThucHien_Click);
            //
            // grpSapXep
            //
            this.grpSapXep.Controls.Add(this.rdoTang);
            this.grpSapXep.Controls.Add(this.rdoGiam);
            this.grpSapXep.Location = new Point(135, 110);
            this.grpSapXep.Name = "grpSapXep";
            this.grpSapXep.Size = new Size(295, 50);
            this.grpSapXep.TabStop = false;
            this.grpSapXep.Text = "Sắp Xếp";
            //
            // rdoTang
            //
            this.rdoTang.Checked = true;
            this.rdoTang.Location = new Point(10, 20);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new Size(130, 24);
            this.rdoTang.TabIndex = 0;
            this.rdoTang.Text = "Sắp xếp Tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            //
            // rdoGiam
            //
            this.rdoGiam.Location = new Point(150, 20);
            this.rdoGiam.Name = "rdoGiam";
            this.rdoGiam.Size = new Size(130, 24);
            this.rdoGiam.TabIndex = 1;
            this.rdoGiam.Text = "Sắp xếp Giảm";
            this.rdoGiam.UseVisualStyleBackColor = true;
            //
            // grpTimKiem
            //
            this.grpTimKiem.Controls.Add(this.rdoTimGiaTri);
            this.grpTimKiem.Controls.Add(this.txtTimGiaTri);
            this.grpTimKiem.Controls.Add(this.rdoTimViTri);
            this.grpTimKiem.Controls.Add(this.txtTimViTri);
            this.grpTimKiem.Controls.Add(this.lblSoTimDuoc);
            this.grpTimKiem.Controls.Add(this.txtSoTimDuoc);
            this.grpTimKiem.Controls.Add(this.btnTim);
            this.grpTimKiem.Location = new Point(15, 170);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new Size(260, 110);
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm Kiếm";
            //
            // rdoTimGiaTri
            //
            this.rdoTimGiaTri.Location = new Point(10, 20);
            this.rdoTimGiaTri.Name = "rdoTimGiaTri";
            this.rdoTimGiaTri.Size = new Size(145, 24);
            this.rdoTimGiaTri.TabIndex = 0;
            this.rdoTimGiaTri.Text = "Tìm giá trị cần tìm";
            this.rdoTimGiaTri.UseVisualStyleBackColor = true;
            //
            // txtTimGiaTri
            //
            this.txtTimGiaTri.Location = new Point(160, 18);
            this.txtTimGiaTri.Name = "txtTimGiaTri";
            this.txtTimGiaTri.Size = new Size(85, 23);
            this.txtTimGiaTri.TabIndex = 1;
            //
            // rdoTimViTri
            //
            this.rdoTimViTri.Checked = true;
            this.rdoTimViTri.Location = new Point(10, 45);
            this.rdoTimViTri.Name = "rdoTimViTri";
            this.rdoTimViTri.Size = new Size(145, 24);
            this.rdoTimViTri.TabIndex = 2;
            this.rdoTimViTri.Text = "Tìm vị trí cần tìm";
            this.rdoTimViTri.UseVisualStyleBackColor = true;
            //
            // txtTimViTri
            //
            this.txtTimViTri.Location = new Point(160, 43);
            this.txtTimViTri.Name = "txtTimViTri";
            this.txtTimViTri.Size = new Size(85, 23);
            this.txtTimViTri.TabIndex = 3;
            //
            // lblSoTimDuoc
            //
            this.lblSoTimDuoc.Location = new Point(10, 73);
            this.lblSoTimDuoc.Name = "lblSoTimDuoc";
            this.lblSoTimDuoc.Size = new Size(100, 23);
            this.lblSoTimDuoc.Text = "Số tìm được là :";
            //
            // txtSoTimDuoc
            //
            this.txtSoTimDuoc.Location = new Point(115, 70);
            this.txtSoTimDuoc.Name = "txtSoTimDuoc";
            this.txtSoTimDuoc.ReadOnly = true;
            this.txtSoTimDuoc.Size = new Size(60, 23);
            this.txtSoTimDuoc.TabIndex = 4;
            this.txtSoTimDuoc.TabStop = false;
            //
            // btnTim
            //
            this.btnTim.Location = new Point(185, 68);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new Size(60, 27);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new EventHandler(this.btnTim_Click);
            //
            // grpXoa
            //
            this.grpXoa.Controls.Add(this.rdoXoaGiaTri);
            this.grpXoa.Controls.Add(this.txtXoaGiaTri);
            this.grpXoa.Controls.Add(this.rdoXoaViTri);
            this.grpXoa.Controls.Add(this.txtXoaViTri);
            this.grpXoa.Controls.Add(this.lblCanSapXepTang1);
            this.grpXoa.Controls.Add(this.btnXoa);
            this.grpXoa.Location = new Point(285, 170);
            this.grpXoa.Name = "grpXoa";
            this.grpXoa.Size = new Size(260, 110);
            this.grpXoa.TabStop = false;
            this.grpXoa.Text = "Xóa";
            //
            // rdoXoaGiaTri
            //
            this.rdoXoaGiaTri.Checked = true;
            this.rdoXoaGiaTri.Location = new Point(10, 20);
            this.rdoXoaGiaTri.Name = "rdoXoaGiaTri";
            this.rdoXoaGiaTri.Size = new Size(145, 24);
            this.rdoXoaGiaTri.TabIndex = 0;
            this.rdoXoaGiaTri.Text = "Tìm giá trị cần xóa";
            this.rdoXoaGiaTri.UseVisualStyleBackColor = true;
            //
            // txtXoaGiaTri
            //
            this.txtXoaGiaTri.Location = new Point(160, 18);
            this.txtXoaGiaTri.Name = "txtXoaGiaTri";
            this.txtXoaGiaTri.Size = new Size(85, 23);
            this.txtXoaGiaTri.TabIndex = 1;
            //
            // rdoXoaViTri
            //
            this.rdoXoaViTri.Location = new Point(10, 45);
            this.rdoXoaViTri.Name = "rdoXoaViTri";
            this.rdoXoaViTri.Size = new Size(145, 24);
            this.rdoXoaViTri.TabIndex = 2;
            this.rdoXoaViTri.Text = "Tìm vị trí cần xóa";
            this.rdoXoaViTri.UseVisualStyleBackColor = true;
            //
            // txtXoaViTri
            //
            this.txtXoaViTri.Location = new Point(160, 43);
            this.txtXoaViTri.Name = "txtXoaViTri";
            this.txtXoaViTri.Size = new Size(85, 23);
            this.txtXoaViTri.TabIndex = 3;
            //
            // lblCanSapXepTang1
            //
            this.lblCanSapXepTang1.ForeColor = Color.Red;
            this.lblCanSapXepTang1.Font = new Font("Tahoma", 8F, FontStyle.Italic);
            this.lblCanSapXepTang1.Location = new Point(10, 73);
            this.lblCanSapXepTang1.Name = "lblCanSapXepTang1";
            this.lblCanSapXepTang1.Size = new Size(165, 23);
            this.lblCanSapXepTang1.Text = "Cần sắp xếp tăng";
            //
            // btnXoa
            //
            this.btnXoa.Location = new Point(185, 68);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new Size(60, 27);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new EventHandler(this.btnXoa_Click);
            //
            // grpThem
            //
            this.grpThem.Controls.Add(this.lblThemGiaTri);
            this.grpThem.Controls.Add(this.txtThemGiaTri);
            this.grpThem.Controls.Add(this.lblThemViTri);
            this.grpThem.Controls.Add(this.txtThemViTri);
            this.grpThem.Controls.Add(this.lblCanSapXepTang2);
            this.grpThem.Controls.Add(this.btnThem);
            this.grpThem.Location = new Point(15, 290);
            this.grpThem.Name = "grpThem";
            this.grpThem.Size = new Size(260, 110);
            this.grpThem.TabStop = false;
            this.grpThem.Text = "Thêm";
            //
            // lblThemGiaTri
            //
            this.lblThemGiaTri.Location = new Point(10, 20);
            this.lblThemGiaTri.Name = "lblThemGiaTri";
            this.lblThemGiaTri.Size = new Size(145, 24);
            this.lblThemGiaTri.Text = "Tìm giá trị cần thêm";
            //
            // txtThemGiaTri
            //
            this.txtThemGiaTri.Location = new Point(160, 18);
            this.txtThemGiaTri.Name = "txtThemGiaTri";
            this.txtThemGiaTri.Size = new Size(85, 23);
            this.txtThemGiaTri.TabIndex = 0;
            //
            // lblThemViTri
            //
            this.lblThemViTri.Location = new Point(10, 48);
            this.lblThemViTri.Name = "lblThemViTri";
            this.lblThemViTri.Size = new Size(145, 24);
            this.lblThemViTri.Text = "Tại vị trí cần thêm :";
            //
            // txtThemViTri
            //
            this.txtThemViTri.Location = new Point(160, 46);
            this.txtThemViTri.Name = "txtThemViTri";
            this.txtThemViTri.Size = new Size(85, 23);
            this.txtThemViTri.TabIndex = 1;
            //
            // lblCanSapXepTang2
            //
            this.lblCanSapXepTang2.ForeColor = Color.Red;
            this.lblCanSapXepTang2.Font = new Font("Tahoma", 8F, FontStyle.Italic);
            this.lblCanSapXepTang2.Location = new Point(10, 76);
            this.lblCanSapXepTang2.Name = "lblCanSapXepTang2";
            this.lblCanSapXepTang2.Size = new Size(165, 23);
            this.lblCanSapXepTang2.Text = "Cần sắp xếp tăng";
            //
            // btnThem
            //
            this.btnThem.Location = new Point(185, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new Size(60, 27);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new EventHandler(this.btnThem_Click);
            //
            // grpTong
            //
            this.grpTong.Controls.Add(this.lblTongMang);
            this.grpTong.Controls.Add(this.txtTongMang);
            this.grpTong.Controls.Add(this.lblTongChan);
            this.grpTong.Controls.Add(this.txtTongChan);
            this.grpTong.Controls.Add(this.lblTongLe);
            this.grpTong.Controls.Add(this.txtTongLe);
            this.grpTong.Controls.Add(this.btnTong);
            this.grpTong.Location = new Point(285, 290);
            this.grpTong.Name = "grpTong";
            this.grpTong.Size = new Size(260, 110);
            this.grpTong.TabStop = false;
            this.grpTong.Text = "Tổng";
            //
            // lblTongMang
            //
            this.lblTongMang.Location = new Point(10, 20);
            this.lblTongMang.Name = "lblTongMang";
            this.lblTongMang.Size = new Size(90, 23);
            this.lblTongMang.Text = "Tổng mảng";
            //
            // txtTongMang
            //
            this.txtTongMang.Location = new Point(105, 18);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.ReadOnly = true;
            this.txtTongMang.Size = new Size(80, 23);
            this.txtTongMang.TabIndex = 0;
            this.txtTongMang.TabStop = false;
            //
            // lblTongChan
            //
            this.lblTongChan.Location = new Point(10, 48);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new Size(90, 23);
            this.lblTongChan.Text = "Tổng chẵn";
            //
            // txtTongChan
            //
            this.txtTongChan.Location = new Point(105, 46);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.ReadOnly = true;
            this.txtTongChan.Size = new Size(80, 23);
            this.txtTongChan.TabIndex = 1;
            this.txtTongChan.TabStop = false;
            //
            // lblTongLe
            //
            this.lblTongLe.Location = new Point(10, 76);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new Size(90, 23);
            this.lblTongLe.Text = "Tổng lẻ";
            //
            // txtTongLe
            //
            this.txtTongLe.Location = new Point(105, 74);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.ReadOnly = true;
            this.txtTongLe.Size = new Size(80, 23);
            this.txtTongLe.TabIndex = 2;
            this.txtTongLe.TabStop = false;
            //
            // btnTong
            //
            this.btnTong.Location = new Point(195, 35);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new Size(55, 45);
            this.btnTong.TabIndex = 3;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new EventHandler(this.btnTong_Click);
            //
            // grpMaxMin
            //
            this.grpMaxMin.Controls.Add(this.lblMax);
            this.grpMaxMin.Controls.Add(this.txtMax);
            this.grpMaxMin.Controls.Add(this.lblMin);
            this.grpMaxMin.Controls.Add(this.txtMin);
            this.grpMaxMin.Controls.Add(this.btnTimMaxMin);
            this.grpMaxMin.Location = new Point(15, 410);
            this.grpMaxMin.Name = "grpMaxMin";
            this.grpMaxMin.Size = new Size(260, 90);
            this.grpMaxMin.TabStop = false;
            this.grpMaxMin.Text = "Max - Min";
            //
            // lblMax
            //
            this.lblMax.Location = new Point(10, 20);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new Size(115, 23);
            this.lblMax.Text = "Giá trị lớn nhất";
            //
            // txtMax
            //
            this.txtMax.Location = new Point(130, 18);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new Size(70, 23);
            this.txtMax.TabIndex = 0;
            this.txtMax.TabStop = false;
            //
            // lblMin
            //
            this.lblMin.Location = new Point(10, 48);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new Size(115, 23);
            this.lblMin.Text = "Giá trị nhỏ nhất";
            //
            // txtMin
            //
            this.txtMin.Location = new Point(130, 46);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new Size(70, 23);
            this.txtMin.TabIndex = 1;
            this.txtMin.TabStop = false;
            //
            // btnTimMaxMin
            //
            this.btnTimMaxMin.Location = new Point(205, 25);
            this.btnTimMaxMin.Name = "btnTimMaxMin";
            this.btnTimMaxMin.Size = new Size(45, 45);
            this.btnTimMaxMin.TabIndex = 2;
            this.btnTimMaxMin.Text = "Tìm";
            this.btnTimMaxMin.UseVisualStyleBackColor = true;
            this.btnTimMaxMin.Click += new EventHandler(this.btnTimMaxMin_Click);
            //
            // grpThayThe
            //
            this.grpThayThe.Controls.Add(this.rdoThayTheGiaTri);
            this.grpThayThe.Controls.Add(this.rdoThayTheViTri);
            this.grpThayThe.Controls.Add(this.txtThayTheChiTieu);
            this.grpThayThe.Controls.Add(this.lblSoThayThe);
            this.grpThayThe.Controls.Add(this.txtSoThayThe);
            this.grpThayThe.Controls.Add(this.btnThayThe);
            this.grpThayThe.Location = new Point(285, 410);
            this.grpThayThe.Name = "grpThayThe";
            this.grpThayThe.Size = new Size(260, 110);
            this.grpThayThe.TabStop = false;
            this.grpThayThe.Text = "Thay Thế";
            //
            // rdoThayTheGiaTri
            //
            this.rdoThayTheGiaTri.Checked = true;
            this.rdoThayTheGiaTri.Location = new Point(10, 20);
            this.rdoThayTheGiaTri.Name = "rdoThayTheGiaTri";
            this.rdoThayTheGiaTri.Size = new Size(150, 24);
            this.rdoThayTheGiaTri.TabIndex = 0;
            this.rdoThayTheGiaTri.Text = "Giá trị cần thay thế";
            this.rdoThayTheGiaTri.UseVisualStyleBackColor = true;
            //
            // rdoThayTheViTri
            //
            this.rdoThayTheViTri.Location = new Point(10, 45);
            this.rdoThayTheViTri.Name = "rdoThayTheViTri";
            this.rdoThayTheViTri.Size = new Size(150, 24);
            this.rdoThayTheViTri.TabIndex = 1;
            this.rdoThayTheViTri.Text = "Vị trí cần thay thế";
            this.rdoThayTheViTri.UseVisualStyleBackColor = true;
            //
            // txtThayTheChiTieu
            //
            this.txtThayTheChiTieu.Location = new Point(165, 20);
            this.txtThayTheChiTieu.Name = "txtThayTheChiTieu";
            this.txtThayTheChiTieu.Size = new Size(75, 23);
            this.txtThayTheChiTieu.TabIndex = 2;
            //
            // lblSoThayThe
            //
            this.lblSoThayThe.Location = new Point(10, 73);
            this.lblSoThayThe.Name = "lblSoThayThe";
            this.lblSoThayThe.Size = new Size(95, 23);
            this.lblSoThayThe.Text = "Số thay thế là :";
            //
            // txtSoThayThe
            //
            this.txtSoThayThe.Location = new Point(110, 70);
            this.txtSoThayThe.Name = "txtSoThayThe";
            this.txtSoThayThe.Size = new Size(65, 23);
            this.txtSoThayThe.TabIndex = 3;
            //
            // btnThayThe
            //
            this.btnThayThe.Location = new Point(185, 68);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new Size(65, 27);
            this.btnThayThe.TabIndex = 4;
            this.btnThayThe.Text = "Thay";
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new EventHandler(this.btnThayThe_Click);
            //
            // frmBai2MangSoNguyen
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(560, 535);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnNhapMang);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblKetQuaMangCaption);
            this.Controls.Add(this.txtKetQuaMang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.grpSapXep);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpXoa);
            this.Controls.Add(this.grpThem);
            this.Controls.Add(this.grpTong);
            this.Controls.Add(this.grpMaxMin);
            this.Controls.Add(this.grpThayThe);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBai2MangSoNguyen";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Mảng Số Nguyên";
            this.FormClosing += new FormClosingEventHandler(this.frmBai2MangSoNguyen_FormClosing);
            this.grpSapXep.ResumeLayout(false);
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpXoa.ResumeLayout(false);
            this.grpXoa.PerformLayout();
            this.grpThem.ResumeLayout(false);
            this.grpThem.PerformLayout();
            this.grpTong.ResumeLayout(false);
            this.grpTong.PerformLayout();
            this.grpMaxMin.ResumeLayout(false);
            this.grpMaxMin.PerformLayout();
            this.grpThayThe.ResumeLayout(false);
            this.grpThayThe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
