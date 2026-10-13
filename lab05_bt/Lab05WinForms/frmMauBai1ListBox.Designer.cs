namespace Lab05WinForms
{
    partial class frmMauBai1ListBox
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

        private ListBox lst_Trai;
        private ListBox lst_Phai;
        private Button btnQuaPhai;
        private Button btnQuaPhaiAll;
        private Button btnQuaTrai;
        private Button btnQuaTraiAll;
        private Button btnChuyenTuyY;

        private void InitializeComponent()
        {
            this.lst_Trai = new ListBox();
            this.lst_Phai = new ListBox();
            this.btnQuaPhai = new Button();
            this.btnQuaPhaiAll = new Button();
            this.btnQuaTrai = new Button();
            this.btnQuaTraiAll = new Button();
            this.btnChuyenTuyY = new Button();
            this.SuspendLayout();
            //
            // lst_Trai
            //
            this.lst_Trai.SelectionMode = SelectionMode.MultiExtended;
            this.lst_Trai.Location = new Point(20, 20);
            this.lst_Trai.Name = "lst_Trai";
            this.lst_Trai.Size = new Size(160, 220);
            this.lst_Trai.TabIndex = 0;
            //
            // lst_Phai
            //
            this.lst_Phai.Location = new Point(280, 20);
            this.lst_Phai.Name = "lst_Phai";
            this.lst_Phai.Size = new Size(160, 220);
            this.lst_Phai.TabIndex = 4;
            //
            // btnQuaPhai
            //
            this.btnQuaPhai.Location = new Point(195, 40);
            this.btnQuaPhai.Name = "btnQuaPhai";
            this.btnQuaPhai.Size = new Size(70, 28);
            this.btnQuaPhai.TabIndex = 1;
            this.btnQuaPhai.Text = ">";
            this.btnQuaPhai.UseVisualStyleBackColor = true;
            this.btnQuaPhai.Click += new EventHandler(this.btnQuaPhai_Click);
            //
            // btnQuaPhaiAll
            //
            this.btnQuaPhaiAll.Location = new Point(195, 75);
            this.btnQuaPhaiAll.Name = "btnQuaPhaiAll";
            this.btnQuaPhaiAll.Size = new Size(70, 28);
            this.btnQuaPhaiAll.TabIndex = 2;
            this.btnQuaPhaiAll.Text = ">>";
            this.btnQuaPhaiAll.UseVisualStyleBackColor = true;
            this.btnQuaPhaiAll.Click += new EventHandler(this.btnQuaPhaiAll_Click);
            //
            // btnQuaTrai
            //
            this.btnQuaTrai.Location = new Point(195, 110);
            this.btnQuaTrai.Name = "btnQuaTrai";
            this.btnQuaTrai.Size = new Size(70, 28);
            this.btnQuaTrai.TabIndex = 3;
            this.btnQuaTrai.Text = "<";
            this.btnQuaTrai.UseVisualStyleBackColor = true;
            this.btnQuaTrai.Click += new EventHandler(this.btnQuaTrai_Click);
            //
            // btnQuaTraiAll
            //
            this.btnQuaTraiAll.Location = new Point(195, 145);
            this.btnQuaTraiAll.Name = "btnQuaTraiAll";
            this.btnQuaTraiAll.Size = new Size(70, 28);
            this.btnQuaTraiAll.TabIndex = 3;
            this.btnQuaTraiAll.Text = "<<";
            this.btnQuaTraiAll.UseVisualStyleBackColor = true;
            this.btnQuaTraiAll.Click += new EventHandler(this.btnQuaTraiAll_Click);
            //
            // btnChuyenTuyY
            //
            this.btnChuyenTuyY.Location = new Point(20, 250);
            this.btnChuyenTuyY.Name = "btnChuyenTuyY";
            this.btnChuyenTuyY.Size = new Size(160, 30);
            this.btnChuyenTuyY.TabIndex = 5;
            this.btnChuyenTuyY.Text = "Chuyển tùy ý";
            this.btnChuyenTuyY.UseVisualStyleBackColor = true;
            this.btnChuyenTuyY.Click += new EventHandler(this.btnChuyenTuyY_Click);
            //
            // frmMauBai1ListBox
            //
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(460, 300);
            this.Controls.Add(this.lst_Trai);
            this.Controls.Add(this.lst_Phai);
            this.Controls.Add(this.btnQuaPhai);
            this.Controls.Add(this.btnQuaPhaiAll);
            this.Controls.Add(this.btnQuaTrai);
            this.Controls.Add(this.btnQuaTraiAll);
            this.Controls.Add(this.btnChuyenTuyY);
            this.Font = new Font("Tahoma", 11F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMauBai1ListBox";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Sử dụng listbox";
            this.FormClosing += new FormClosingEventHandler(this.frmMauBai1ListBox_FormClosing);
            this.Load += new EventHandler(this.frmMauBai1ListBox_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
