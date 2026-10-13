namespace Lab05WinForms
{
    partial class frmBtvnDanhBa
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

        private TreeView trv_DanhBa;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnAdd;
        private Button btnExit;
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trv_DanhBa = new TreeView();
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.btnAdd = new Button();
            this.btnExit = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // trv_DanhBa
            //
            this.trv_DanhBa.Location = new Point(20, 15);
            this.trv_DanhBa.Name = "trv_DanhBa";
            this.trv_DanhBa.Size = new Size(280, 440);
            this.trv_DanhBa.TabIndex = 0;
            //
            // lblFirstName
            //
            this.lblFirstName.Location = new Point(320, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new Size(85, 23);
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtFirstName
            //
            this.txtFirstName.Location = new Point(410, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new Size(200, 23);
            this.txtFirstName.TabIndex = 1;
            //
            // lblLastName
            //
            this.lblLastName.Location = new Point(320, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new Size(85, 23);
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            //
            // txtLastName
            //
            this.txtLastName.Location = new Point(410, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(200, 23);
            this.txtLastName.TabIndex = 2;
            //
            // btnAdd
            //
            this.btnAdd.Location = new Point(500, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(110, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            //
            // btnExit
            //
            this.btnExit.Location = new Point(500, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new Size(110, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new EventHandler(this.btnExit_Click);
            //
            // frmBtvnDanhBa
            //
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 475);
            this.Controls.Add(this.trv_DanhBa);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Font = new Font("Tahoma", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBtvnDanhBa";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "frmBTVN2";
            this.Load += new EventHandler(this.frmBtvnDanhBa_Load);
            this.FormClosing += new FormClosingEventHandler(this.frmBtvnDanhBa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
