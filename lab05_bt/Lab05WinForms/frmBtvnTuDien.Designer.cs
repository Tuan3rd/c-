namespace Lab05WinForms
{
    partial class frmBtvnTuDien
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

        private TabControl tabDichThuat;
        private TabPage tabAnhViet;
        private TabPage tabVietAnh;

        private Label lblTiengAnh1;
        private ComboBox cboTuAnh;
        private ListBox lstTuAnh;
        private Label lblTiengViet1;
        private TextBox txtNghiaViet;

        private Label lblTiengViet2;
        private ComboBox cboTuViet;
        private ListBox lstTuViet;
        private Label lblTiengAnh2;
        private TextBox txtNghiaAnh;

        private Button btnThoat;

        private void InitializeComponent()
        {
            this.tabDichThuat = new TabControl();
            this.tabAnhViet = new TabPage();
            this.tabVietAnh = new TabPage();

            this.lblTiengAnh1 = new Label();
            this.cboTuAnh = new ComboBox();
            this.lstTuAnh = new ListBox();
            this.lblTiengViet1 = new Label();
            this.txtNghiaViet = new TextBox();

            this.lblTiengViet2 = new Label();
            this.cboTuViet = new ComboBox();
            this.lstTuViet = new ListBox();
            this.lblTiengAnh2 = new Label();
            this.txtNghiaAnh = new TextBox();

            this.btnThoat = new Button();
            this.tabDichThuat.SuspendLayout();
            this.tabAnhViet.SuspendLayout();
            this.tabVietAnh.SuspendLayout();
            this.SuspendLayout();
            //
            // tabDichThuat
            //
            this.tabDichThuat.Controls.Add(this.tabAnhViet);
            this.tabDichThuat.Controls.Add(this.tabVietAnh);
            this.tabDichThuat.Location = new Point(15, 15);
            this.tabDichThuat.Name = "tabDichThuat";
            this.tabDichThuat.SelectedIndex = 0;
            this.tabDichThuat.Size = new Size(500, 330);
            this.tabDichThuat.TabIndex = 0;
            //
            // tabAnhViet
            //
            this.tabAnhViet.Controls.Add(this.lblTiengAnh1);
            this.tabAnhViet.Controls.Add(this.cboTuAnh);
            this.tabAnhViet.Controls.Add(this.lstTuAnh);
            this.tabAnhViet.Controls.Add(this.lblTiengViet1);
            this.tabAnhViet.Controls.Add(this.txtNghiaViet);
            this.tabAnhViet.Location = new Point(4, 26);
            this.tabAnhViet.Name = "tabAnhViet";
            this.tabAnhViet.Padding = new Padding(10);
            this.tabAnhViet.Size = new Size(492, 300);
            this.tabAnhViet.Text = "ANH - VIỆT";
            this.tabAnhViet.UseVisualStyleBackColor = true;
            //
            // lblTiengAnh1
            //
            this.lblTiengAnh1.Location = new Point(15, 15);
            this.lblTiengAnh1.Name = "lblTiengAnh1";
            this.lblTiengAnh1.Size = new Size(120, 23);
            this.lblTiengAnh1.Text = "Tiếng Anh";
            //
            // cboTuAnh
            //
            this.cboTuAnh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboTuAnh.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cboTuAnh.Location = new Point(15, 40);
            this.cboTuAnh.Name = "cboTuAnh";
            this.cboTuAnh.Size = new Size(220, 25);
            this.cboTuAnh.TabIndex = 0;
            this.cboTuAnh.KeyDown += new KeyEventHandler(this.cboTuAnh_KeyDown);
            //
            // lstTuAnh
            //
            this.lstTuAnh.Location = new Point(15, 72);
            this.lstTuAnh.Name = "lstTuAnh";
            this.lstTuAnh.Size = new Size(220, 200);
            this.lstTuAnh.TabIndex = 1;
            this.lstTuAnh.DoubleClick += new EventHandler(this.lstTuAnh_DoubleClick);
            //
            // lblTiengViet1
            //
            this.lblTiengViet1.Location = new Point(255, 15);
            this.lblTiengViet1.Name = "lblTiengViet1";
            this.lblTiengViet1.Size = new Size(150, 23);
            this.lblTiengViet1.Text = "Tiếng Việt";
            //
            // txtNghiaViet
            //
            this.txtNghiaViet.Location = new Point(255, 40);
            this.txtNghiaViet.Multiline = true;
            this.txtNghiaViet.ReadOnly = true;
            this.txtNghiaViet.Size = new Size(220, 100);
            this.txtNghiaViet.TabStop = false;
            //
            // tabVietAnh
            //
            this.tabVietAnh.Controls.Add(this.lblTiengViet2);
            this.tabVietAnh.Controls.Add(this.cboTuViet);
            this.tabVietAnh.Controls.Add(this.lstTuViet);
            this.tabVietAnh.Controls.Add(this.lblTiengAnh2);
            this.tabVietAnh.Controls.Add(this.txtNghiaAnh);
            this.tabVietAnh.Location = new Point(4, 26);
            this.tabVietAnh.Name = "tabVietAnh";
            this.tabVietAnh.Padding = new Padding(10);
            this.tabVietAnh.Size = new Size(492, 300);
            this.tabVietAnh.Text = "VIỆT - ANH";
            this.tabVietAnh.UseVisualStyleBackColor = true;
            //
            // lblTiengViet2
            //
            this.lblTiengViet2.Location = new Point(15, 15);
            this.lblTiengViet2.Name = "lblTiengViet2";
            this.lblTiengViet2.Size = new Size(120, 23);
            this.lblTiengViet2.Text = "Tiếng Việt";
            //
            // cboTuViet
            //
            this.cboTuViet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cboTuViet.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cboTuViet.Location = new Point(15, 40);
            this.cboTuViet.Name = "cboTuViet";
            this.cboTuViet.Size = new Size(220, 25);
            this.cboTuViet.TabIndex = 0;
            this.cboTuViet.KeyDown += new KeyEventHandler(this.cboTuViet_KeyDown);
            //
            // lstTuViet
            //
            this.lstTuViet.Location = new Point(15, 72);
            this.lstTuViet.Name = "lstTuViet";
            this.lstTuViet.Size = new Size(220, 200);
            this.lstTuViet.TabIndex = 1;
            this.lstTuViet.DoubleClick += new EventHandler(this.lstTuViet_DoubleClick);
            //
            // lblTiengAnh2
            //
            this.lblTiengAnh2.Location = new Point(255, 15);
            this.lblTiengAnh2.Name = "lblTiengAnh2";
            this.lblTiengAnh2.Size = new Size(150, 23);
            this.lblTiengAnh2.Text = "Tiếng Anh";
            //
            // txtNghiaAnh
            //
            this.txtNghiaAnh.Location = new Point(255, 40);
            this.txtNghiaAnh.Multiline = true;
            this.txtNghiaAnh.ReadOnly = true;
            this.txtNghiaAnh.Size = new Size(220, 100);
            this.txtNghiaAnh.TabStop = false;
            //
            // btnThoat
            //
            this.btnThoat.Location = new Point(395, 355);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(120, 32);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);
            //
            // frmBtvnTuDien
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(530, 400);
            this.Controls.Add(this.tabDichThuat);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBtvnTuDien";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            this.Load += new EventHandler(this.frmBtvnTuDien_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmBtvnTuDien_FormClosing);
            this.tabAnhViet.ResumeLayout(false);
            this.tabVietAnh.ResumeLayout(false);
            this.tabDichThuat.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
