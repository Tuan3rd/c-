namespace Lab05ContinueWinForms
{
    partial class frmMauBai2ListView
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

        private Button btnthem;
        private Button btnxoa;
        private Button btnsua;
        private Label lblMaSV;
        private TextBox txtmssv;
        private Label lblHoTen;
        private TextBox txthoten;
        private ListView lstv1;
        private ColumnHeader colMaSo;
        private ColumnHeader colHoTen;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnthem = new Button();
            this.btnxoa = new Button();
            this.btnsua = new Button();
            this.lblMaSV = new Label();
            this.txtmssv = new TextBox();
            this.lblHoTen = new Label();
            this.txthoten = new TextBox();
            this.lstv1 = new ListView();
            this.colMaSo = new ColumnHeader();
            this.colHoTen = new ColumnHeader();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // btnthem
            //
            this.btnthem.Location = new Point(20, 15);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new Size(100, 30);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new EventHandler(this.btnthem_Click);
            //
            // btnxoa
            //
            this.btnxoa.Location = new Point(130, 15);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new Size(100, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new EventHandler(this.btnxoa_Click);
            //
            // btnsua
            //
            this.btnsua.Location = new Point(240, 15);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new Size(100, 30);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new EventHandler(this.btnsua_Click);
            //
            // lblMaSV
            //
            this.lblMaSV.Location = new Point(20, 58);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new Size(60, 23);
            this.lblMaSV.Text = "Mã SV";
            //
            // txtmssv
            //
            this.txtmssv.Location = new Point(90, 55);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new Size(250, 23);
            this.txtmssv.TabIndex = 3;
            //
            // lblHoTen
            //
            this.lblHoTen.Location = new Point(20, 88);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new Size(60, 23);
            this.lblHoTen.Text = "Họ tên";
            //
            // txthoten
            //
            this.txthoten.Location = new Point(90, 85);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new Size(250, 23);
            this.txthoten.TabIndex = 4;
            //
            // lstv1
            //
            this.lstv1.Columns.AddRange(new ColumnHeader[] { this.colMaSo, this.colHoTen });
            this.lstv1.FullRowSelect = true;
            this.lstv1.GridLines = true;
            this.lstv1.Location = new Point(20, 120);
            this.lstv1.MultiSelect = true;
            this.lstv1.Name = "lstv1";
            this.lstv1.Size = new Size(320, 220);
            this.lstv1.TabIndex = 5;
            this.lstv1.UseCompatibleStateImageBehavior = false;
            this.lstv1.View = View.Details;
            //
            // colMaSo
            //
            this.colMaSo.Text = "MÃ SỐ SV";
            this.colMaSo.Width = 140;
            //
            // colHoTen
            //
            this.colHoTen.Text = "HỌ VÀ TÊN";
            this.colHoTen.Width = 160;
            //
            // frmMauBai2ListView
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 360);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.lblMaSV);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.lstv1);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai2ListView";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "ListView";
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai2ListView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
