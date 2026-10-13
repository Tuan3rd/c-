namespace Lab05WinForms
{
    partial class frmBtvnListBoxSo
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
        private Label lblListBoxCaption;
        private TextBox txtNhapSo;
        private Button btnNhap;
        private ListBox lstSo;

        private Label lblXuLy;
        private Button btnTongPhanTu;
        private Button btnXoaDauCuoi;
        private Button btnXoaDangChon;
        private Button btnTang2;
        private Button btnBinhPhuong;
        private Button btnChonChan;
        private Button btnChonLe;
        private Button btnKetThuc;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new Label();
            this.lblListBoxCaption = new Label();
            this.txtNhapSo = new TextBox();
            this.btnNhap = new Button();
            this.lstSo = new ListBox();

            this.lblXuLy = new Label();
            this.btnTongPhanTu = new Button();
            this.btnXoaDauCuoi = new Button();
            this.btnXoaDangChon = new Button();
            this.btnTang2 = new Button();
            this.btnBinhPhuong = new Button();
            this.btnChonChan = new Button();
            this.btnChonLe = new Button();
            this.btnKetThuc = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.BackColor = Color.Orange;
            this.lblTieuDe.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.White;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(600, 45);
            this.lblTieuDe.Text = "LISTBOX";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            //
            // lblListBoxCaption
            //
            this.lblListBoxCaption.Location = new Point(20, 75);
            this.lblListBoxCaption.Name = "lblListBoxCaption";
            this.lblListBoxCaption.Size = new Size(100, 23);
            this.lblListBoxCaption.Text = "Listbox";
            //
            // txtNhapSo
            //
            this.txtNhapSo.Location = new Point(20, 100);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new Size(160, 23);
            this.txtNhapSo.TabIndex = 0;
            this.txtNhapSo.KeyPress += new KeyPressEventHandler(this.txtNhapSo_KeyPress);
            //
            // btnNhap
            //
            this.btnNhap.Location = new Point(190, 98);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new Size(90, 28);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new EventHandler(this.btnNhap_Click);
            //
            // lstSo
            //
            this.lstSo.SelectionMode = SelectionMode.MultiExtended;
            this.lstSo.Location = new Point(20, 135);
            this.lstSo.Name = "lstSo";
            this.lstSo.Size = new Size(260, 275);
            this.lstSo.TabIndex = 2;
            //
            // lblXuLy
            //
            this.lblXuLy.Location = new Point(300, 75);
            this.lblXuLy.Name = "lblXuLy";
            this.lblXuLy.Size = new Size(150, 23);
            this.lblXuLy.Text = "Xử lý Listbox";
            //
            // btnTongPhanTu
            //
            this.btnTongPhanTu.Location = new Point(300, 100);
            this.btnTongPhanTu.Name = "btnTongPhanTu";
            this.btnTongPhanTu.Size = new Size(320, 32);
            this.btnTongPhanTu.TabIndex = 3;
            this.btnTongPhanTu.Text = "Tổng các phần tử trong List";
            this.btnTongPhanTu.UseVisualStyleBackColor = true;
            this.btnTongPhanTu.Click += new EventHandler(this.btnTongPhanTu_Click);
            //
            // btnXoaDauCuoi
            //
            this.btnXoaDauCuoi.Location = new Point(300, 135);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new Size(320, 32);
            this.btnXoaDauCuoi.TabIndex = 4;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new EventHandler(this.btnXoaDauCuoi_Click);
            //
            // btnXoaDangChon
            //
            this.btnXoaDangChon.Location = new Point(300, 170);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new Size(320, 32);
            this.btnXoaDangChon.TabIndex = 5;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new EventHandler(this.btnXoaDangChon_Click);
            //
            // btnTang2
            //
            this.btnTang2.Location = new Point(300, 205);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new Size(320, 32);
            this.btnTang2.TabIndex = 6;
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new EventHandler(this.btnTang2_Click);
            //
            // btnBinhPhuong
            //
            this.btnBinhPhuong.Location = new Point(300, 240);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new Size(320, 32);
            this.btnBinhPhuong.TabIndex = 7;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new EventHandler(this.btnBinhPhuong_Click);
            //
            // btnChonChan
            //
            this.btnChonChan.Location = new Point(300, 275);
            this.btnChonChan.Name = "btnChonChan";
            this.btnChonChan.Size = new Size(320, 32);
            this.btnChonChan.TabIndex = 8;
            this.btnChonChan.Text = "Chọn số chẵn";
            this.btnChonChan.UseVisualStyleBackColor = true;
            this.btnChonChan.Click += new EventHandler(this.btnChonChan_Click);
            //
            // btnChonLe
            //
            this.btnChonLe.Location = new Point(300, 310);
            this.btnChonLe.Name = "btnChonLe";
            this.btnChonLe.Size = new Size(320, 32);
            this.btnChonLe.TabIndex = 9;
            this.btnChonLe.Text = "Chọn số lẻ";
            this.btnChonLe.UseVisualStyleBackColor = true;
            this.btnChonLe.Click += new EventHandler(this.btnChonLe_Click);
            //
            // btnKetThuc
            //
            this.btnKetThuc.Location = new Point(20, 420);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new Size(600, 38);
            this.btnKetThuc.TabIndex = 10;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new EventHandler(this.btnKetThuc_Click);
            //
            // frmBtvnListBoxSo
            //
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 475);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblListBoxCaption);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lstSo);
            this.Controls.Add(this.lblXuLy);
            this.Controls.Add(this.btnTongPhanTu);
            this.Controls.Add(this.btnXoaDauCuoi);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnBinhPhuong);
            this.Controls.Add(this.btnChonChan);
            this.Controls.Add(this.btnChonLe);
            this.Controls.Add(this.btnKetThuc);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBtvnListBoxSo";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmListbox";
            this.FormClosing += new FormClosingEventHandler(this.frmBtvnListBoxSo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
