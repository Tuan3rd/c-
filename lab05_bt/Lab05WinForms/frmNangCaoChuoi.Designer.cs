namespace Lab05WinForms
{
    partial class frmNangCaoChuoi
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

        private Button btnNgauNhien;
        private ListBox lstTen;
        private Button btnXoaDangChon;
        private Button btnXoaTenSon;
        private Button btnXoaHoLe;
        private Button btnChuyenHoa;
        private Button btnChuyenThuong;
        private Button btnVietHoaDau;
        private Button btnXoaTatCa;

        private void InitializeComponent()
        {
            this.btnNgauNhien = new Button();
            this.lstTen = new ListBox();
            this.btnXoaDangChon = new Button();
            this.btnXoaTenSon = new Button();
            this.btnXoaHoLe = new Button();
            this.btnChuyenHoa = new Button();
            this.btnChuyenThuong = new Button();
            this.btnVietHoaDau = new Button();
            this.btnXoaTatCa = new Button();
            this.SuspendLayout();
            //
            // btnNgauNhien
            //
            this.btnNgauNhien.Location = new Point(20, 15);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new Size(260, 32);
            this.btnNgauNhien.TabIndex = 0;
            this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new EventHandler(this.btnNgauNhien_Click);
            //
            // lstTen
            //
            this.lstTen.SelectionMode = SelectionMode.MultiExtended;
            this.lstTen.Location = new Point(20, 55);
            this.lstTen.Name = "lstTen";
            this.lstTen.Size = new Size(260, 330);
            this.lstTen.TabIndex = 1;
            this.lstTen.DoubleClick += new EventHandler(this.lstTen_DoubleClick);
            //
            // btnXoaDangChon
            //
            this.btnXoaDangChon.Location = new Point(300, 55);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new Size(320, 32);
            this.btnXoaDangChon.TabIndex = 2;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new EventHandler(this.btnXoaDangChon_Click);
            //
            // btnXoaTenSon
            //
            this.btnXoaTenSon.Location = new Point(300, 95);
            this.btnXoaTenSon.Name = "btnXoaTenSon";
            this.btnXoaTenSon.Size = new Size(320, 32);
            this.btnXoaTenSon.TabIndex = 3;
            this.btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
            this.btnXoaTenSon.UseVisualStyleBackColor = true;
            this.btnXoaTenSon.Click += new EventHandler(this.btnXoaTenSon_Click);
            //
            // btnXoaHoLe
            //
            this.btnXoaHoLe.Location = new Point(300, 135);
            this.btnXoaHoLe.Name = "btnXoaHoLe";
            this.btnXoaHoLe.Size = new Size(320, 32);
            this.btnXoaHoLe.TabIndex = 4;
            this.btnXoaHoLe.Text = "Xóa Phần tử có họ là Lê";
            this.btnXoaHoLe.UseVisualStyleBackColor = true;
            this.btnXoaHoLe.Click += new EventHandler(this.btnXoaHoLe_Click);
            //
            // btnChuyenHoa
            //
            this.btnChuyenHoa.Location = new Point(300, 175);
            this.btnChuyenHoa.Name = "btnChuyenHoa";
            this.btnChuyenHoa.Size = new Size(320, 32);
            this.btnChuyenHoa.TabIndex = 5;
            this.btnChuyenHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
            this.btnChuyenHoa.UseVisualStyleBackColor = true;
            this.btnChuyenHoa.Click += new EventHandler(this.btnChuyenHoa_Click);
            //
            // btnChuyenThuong
            //
            this.btnChuyenThuong.Location = new Point(300, 215);
            this.btnChuyenThuong.Name = "btnChuyenThuong";
            this.btnChuyenThuong.Size = new Size(320, 32);
            this.btnChuyenThuong.TabIndex = 6;
            this.btnChuyenThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            this.btnChuyenThuong.UseVisualStyleBackColor = true;
            this.btnChuyenThuong.Click += new EventHandler(this.btnChuyenThuong_Click);
            //
            // btnVietHoaDau
            //
            this.btnVietHoaDau.Location = new Point(300, 255);
            this.btnVietHoaDau.Name = "btnVietHoaDau";
            this.btnVietHoaDau.Size = new Size(320, 45);
            this.btnVietHoaDau.TabIndex = 7;
            this.btnVietHoaDau.Text = "Chuyển PT đang chọn thành viết Hoa đầu mỗi từ";
            this.btnVietHoaDau.UseVisualStyleBackColor = true;
            this.btnVietHoaDau.Click += new EventHandler(this.btnVietHoaDau_Click);
            //
            // btnXoaTatCa
            //
            this.btnXoaTatCa.Location = new Point(300, 320);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new Size(320, 32);
            this.btnXoaTatCa.TabIndex = 8;
            this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new EventHandler(this.btnXoaTatCa_Click);
            //
            // frmNangCaoChuoi
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 400);
            this.Controls.Add(this.btnNgauNhien);
            this.Controls.Add(this.lstTen);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.btnXoaTenSon);
            this.Controls.Add(this.btnXoaHoLe);
            this.Controls.Add(this.btnChuyenHoa);
            this.Controls.Add(this.btnChuyenThuong);
            this.Controls.Add(this.btnVietHoaDau);
            this.Controls.Add(this.btnXoaTatCa);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNangCaoChuoi";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmChuoi";
            this.FormClosing += new FormClosingEventHandler(this.frmNangCaoChuoi_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
