namespace Lab05ContinueWinForms
{
    partial class frmMauBai3FileDialog
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
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button btnLuuFile;
        private Button btnMoFile;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.richTextBox1 = new RichTextBox();
            this.textBox1 = new TextBox();
            this.btnLuuFile = new Button();
            this.btnMoFile = new Button();
            this.saveFileDialog1 = new SaveFileDialog();
            this.openFileDialog1 = new OpenFileDialog();
            this.SuspendLayout();
            //
            // lblTieuDe
            //
            this.lblTieuDe.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(300, 23);
            this.lblTieuDe.Text = "Nhập đoạn text";
            //
            // richTextBox1
            //
            this.richTextBox1.Location = new Point(20, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(310, 230);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            //
            // textBox1
            //
            this.textBox1.Location = new Point(20, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(310, 23);
            this.textBox1.TabStop = false;
            //
            // btnLuuFile
            //
            this.btnLuuFile.Location = new Point(135, 318);
            this.btnLuuFile.Name = "btnLuuFile";
            this.btnLuuFile.Size = new Size(95, 30);
            this.btnLuuFile.TabIndex = 1;
            this.btnLuuFile.Text = "Lưu file";
            this.btnLuuFile.UseVisualStyleBackColor = true;
            this.btnLuuFile.Click += new EventHandler(this.btnLuuFile_Click);
            //
            // btnMoFile
            //
            this.btnMoFile.Location = new Point(235, 318);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new Size(95, 30);
            this.btnMoFile.TabIndex = 2;
            this.btnMoFile.Text = "Mở file";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new EventHandler(this.btnMoFile_Click);
            //
            // saveFileDialog1
            //
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            //
            // openFileDialog1
            //
            this.openFileDialog1.Filter = "All Text File (*.txt)|*.txt|All Document (*.pdf)|*.pdf";
            //
            // frmMauBai3FileDialog
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(350, 365);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLuuFile);
            this.Controls.Add(this.btnMoFile);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai3FileDialog";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Save File Dialog";
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai3FileDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
