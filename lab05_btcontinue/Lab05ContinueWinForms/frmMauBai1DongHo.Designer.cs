namespace Lab05ContinueWinForms
{
    partial class frmMauBai1DongHo
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

        private Label label1;
        private System.Windows.Forms.Timer timer1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            this.label1.ForeColor = Color.Red;
            this.label1.Location = new Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new Size(260, 30);
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            //
            // timer1
            //
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            //
            // frmMauBai1DongHo
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Beige;
            this.ClientSize = new Size(300, 150);
            this.Controls.Add(this.label1);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai1DongHo";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Demo Timer";
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai1DongHo_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
