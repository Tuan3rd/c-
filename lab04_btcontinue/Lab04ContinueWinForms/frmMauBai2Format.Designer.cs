namespace Lab04ContinueWinForms
{
    partial class frmMauBai2Format
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

        private Label lblNoiDung;
        private GroupBox grpFontStyle;
        private CheckBox chkRegular;
        private CheckBox chkBold;
        private CheckBox chkItalic;
        private CheckBox chkBoldItalic;
        private GroupBox grpColor;
        private RadioButton rdoAutoColor;
        private RadioButton rdoRed;
        private RadioButton rdoGreen;
        private RadioButton rdoBlue;
        private Button btnExit;

        private void InitializeComponent()
        {
            this.lblNoiDung = new Label();
            this.grpFontStyle = new GroupBox();
            this.chkRegular = new CheckBox();
            this.chkBold = new CheckBox();
            this.chkItalic = new CheckBox();
            this.chkBoldItalic = new CheckBox();
            this.grpColor = new GroupBox();
            this.rdoAutoColor = new RadioButton();
            this.rdoRed = new RadioButton();
            this.rdoGreen = new RadioButton();
            this.rdoBlue = new RadioButton();
            this.btnExit = new Button();
            this.grpFontStyle.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            //
            // lblNoiDung
            //
            this.lblNoiDung.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            this.lblNoiDung.ForeColor = Color.Firebrick;
            this.lblNoiDung.Location = new Point(20, 15);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new Size(380, 50);
            this.lblNoiDung.Text = "Trường Đại Học Công Nghiệp Thực Phẩm\r\nKhoa Công Nghệ Thông Tin";
            this.lblNoiDung.TextAlign = ContentAlignment.MiddleCenter;
            //
            // grpFontStyle
            //
            this.grpFontStyle.Controls.Add(this.chkRegular);
            this.grpFontStyle.Controls.Add(this.chkBold);
            this.grpFontStyle.Controls.Add(this.chkItalic);
            this.grpFontStyle.Controls.Add(this.chkBoldItalic);
            this.grpFontStyle.Location = new Point(20, 80);
            this.grpFontStyle.Name = "grpFontStyle";
            this.grpFontStyle.Size = new Size(170, 150);
            this.grpFontStyle.TabStop = false;
            this.grpFontStyle.Text = "Font Style";
            //
            // chkRegular
            //
            this.chkRegular.Checked = true;
            this.chkRegular.Location = new Point(15, 25);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new Size(140, 24);
            this.chkRegular.TabIndex = 0;
            this.chkRegular.Text = "Regular";
            this.chkRegular.UseVisualStyleBackColor = true;
            this.chkRegular.CheckedChanged += new EventHandler(this.chkFontStyle_CheckedChanged);
            //
            // chkBold
            //
            this.chkBold.Location = new Point(15, 55);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new Size(140, 24);
            this.chkBold.TabIndex = 1;
            this.chkBold.Text = "Bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new EventHandler(this.chkFontStyle_CheckedChanged);
            //
            // chkItalic
            //
            this.chkItalic.Location = new Point(15, 85);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new Size(140, 24);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new EventHandler(this.chkFontStyle_CheckedChanged);
            //
            // chkBoldItalic
            //
            this.chkBoldItalic.Location = new Point(15, 115);
            this.chkBoldItalic.Name = "chkBoldItalic";
            this.chkBoldItalic.Size = new Size(140, 24);
            this.chkBoldItalic.TabIndex = 3;
            this.chkBoldItalic.Text = "Bold and Italic";
            this.chkBoldItalic.UseVisualStyleBackColor = true;
            this.chkBoldItalic.CheckedChanged += new EventHandler(this.chkFontStyle_CheckedChanged);
            //
            // grpColor
            //
            this.grpColor.Controls.Add(this.rdoAutoColor);
            this.grpColor.Controls.Add(this.rdoRed);
            this.grpColor.Controls.Add(this.rdoGreen);
            this.grpColor.Controls.Add(this.rdoBlue);
            this.grpColor.Location = new Point(210, 80);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new Size(170, 150);
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            //
            // rdoAutoColor
            //
            this.rdoAutoColor.Checked = true;
            this.rdoAutoColor.Location = new Point(15, 25);
            this.rdoAutoColor.Name = "rdoAutoColor";
            this.rdoAutoColor.Size = new Size(140, 24);
            this.rdoAutoColor.TabIndex = 0;
            this.rdoAutoColor.Text = "AutoColor";
            this.rdoAutoColor.UseVisualStyleBackColor = true;
            this.rdoAutoColor.CheckedChanged += new EventHandler(this.rdoColor_CheckedChanged);
            //
            // rdoRed
            //
            this.rdoRed.Location = new Point(15, 55);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new Size(140, 24);
            this.rdoRed.TabIndex = 1;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new EventHandler(this.rdoColor_CheckedChanged);
            //
            // rdoGreen
            //
            this.rdoGreen.Location = new Point(15, 85);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new Size(140, 24);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new EventHandler(this.rdoColor_CheckedChanged);
            //
            // rdoBlue
            //
            this.rdoBlue.Location = new Point(15, 115);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new Size(140, 24);
            this.rdoBlue.TabIndex = 3;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new EventHandler(this.rdoColor_CheckedChanged);
            //
            // btnExit
            //
            this.btnExit.Location = new Point(145, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(110, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            //
            // frmMauBai2Format
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(420, 300);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.grpFontStyle);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.btnExit);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai2Format";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmFormat";
            this.grpFontStyle.ResumeLayout(false);
            this.grpColor.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
