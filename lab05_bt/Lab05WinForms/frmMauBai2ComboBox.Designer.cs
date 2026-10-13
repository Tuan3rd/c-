namespace Lab05WinForms
{
    partial class frmMauBai2ComboBox
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

        private Button btn_loadDL;
        private Label lbl_dantoc;
        private ComboBox cbo_dt;
        private Button btn_hienthi;
        private Label lbl_kq;

        private void InitializeComponent()
        {
            this.btn_loadDL = new Button();
            this.lbl_dantoc = new Label();
            this.cbo_dt = new ComboBox();
            this.btn_hienthi = new Button();
            this.lbl_kq = new Label();
            this.SuspendLayout();
            //
            // btn_loadDL
            //
            this.btn_loadDL.Location = new Point(70, 20);
            this.btn_loadDL.Name = "btn_loadDL";
            this.btn_loadDL.Size = new Size(220, 32);
            this.btn_loadDL.TabIndex = 0;
            this.btn_loadDL.Text = "Load dữ liệu Combobox";
            this.btn_loadDL.UseVisualStyleBackColor = true;
            this.btn_loadDL.Click += new EventHandler(this.btn_loadDL_Click);
            //
            // lbl_dantoc
            //
            this.lbl_dantoc.Location = new Point(30, 70);
            this.lbl_dantoc.Name = "lbl_dantoc";
            this.lbl_dantoc.Size = new Size(70, 25);
            this.lbl_dantoc.Text = "Dân tộc";
            this.lbl_dantoc.TextAlign = ContentAlignment.MiddleLeft;
            //
            // cbo_dt
            //
            this.cbo_dt.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbo_dt.Location = new Point(110, 68);
            this.cbo_dt.Name = "cbo_dt";
            this.cbo_dt.Size = new Size(220, 25);
            this.cbo_dt.TabIndex = 1;
            this.cbo_dt.SelectedIndexChanged += new EventHandler(this.cbo_dt_SelectedIndexChanged);
            //
            // btn_hienthi
            //
            this.btn_hienthi.Location = new Point(110, 110);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new Size(140, 32);
            this.btn_hienthi.TabIndex = 2;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new EventHandler(this.btn_hienthi_Click);
            //
            // lbl_kq
            //
            this.lbl_kq.ForeColor = Color.Red;
            this.lbl_kq.Location = new Point(30, 155);
            this.lbl_kq.Name = "lbl_kq";
            this.lbl_kq.Size = new Size(300, 25);
            this.lbl_kq.TextAlign = ContentAlignment.MiddleLeft;
            //
            // frmMauBai2ComboBox
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(360, 200);
            this.Controls.Add(this.btn_loadDL);
            this.Controls.Add(this.lbl_dantoc);
            this.Controls.Add(this.cbo_dt);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.lbl_kq);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai2ComboBox";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Cbo_Dantoc";
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai2ComboBox_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
