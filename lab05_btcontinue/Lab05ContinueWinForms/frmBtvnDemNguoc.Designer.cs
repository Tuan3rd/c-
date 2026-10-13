namespace Lab05ContinueWinForms
{
    partial class frmBtvnDemNguoc
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

        private Label lblThoiGian;
        private Button btnBatDau;
        private System.Windows.Forms.Timer timer1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblThoiGian = new Label();
            this.btnBatDau = new Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //
            // lblThoiGian
            //
            this.lblThoiGian.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            this.lblThoiGian.Location = new Point(20, 20);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new Size(200, 45);
            this.lblThoiGian.Text = "30:00";
            this.lblThoiGian.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnBatDau
            //
            this.btnBatDau.Location = new Point(60, 75);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new Size(120, 32);
            this.btnBatDau.TabIndex = 0;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new EventHandler(this.btnBatDau_Click);
            //
            // timer1
            //
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            //
            // frmBtvnDemNguoc
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(240, 130);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.btnBatDau);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBtvnDemNguoc";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Đồng hồ";
            this.FormClosing += new FormClosingEventHandler(this.frmBtvnDemNguoc_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
