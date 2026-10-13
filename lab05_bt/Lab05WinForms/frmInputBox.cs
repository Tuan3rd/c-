namespace Lab05WinForms;

// Hop thoai nhap 1 dong van ban dung chung (thay cho InputBox cua VB), dung cho
// chuc nang "double click de doi ten" (Bai 1 nang cao) va cac cho can nhap nhanh khac.
// Viet thuan code (khong co Designer rieng) vi giao dien chi gom 1 Label, 1 TextBox, 2 Button.
public class frmInputBox : Form
{
    private readonly TextBox _txtGiaTri;

    public string GiaTri => _txtGiaTri.Text;

    public frmInputBox(string tieuDe, string nhan, string giaTriBanDau)
    {
        Text = tieuDe;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        StartPosition = FormStartPosition.CenterParent;
        MaximizeBox = false;
        MinimizeBox = false;
        ClientSize = new Size(360, 110);
        Font = new Font("Tahoma", 9F);

        var lblNhan = new Label
        {
            Text = nhan,
            Location = new Point(15, 15),
            Size = new Size(330, 23)
        };

        _txtGiaTri = new TextBox
        {
            Text = giaTriBanDau,
            Location = new Point(15, 42),
            Size = new Size(330, 23)
        };
        _txtGiaTri.SelectAll();

        var btnOk = new Button
        {
            Text = "OK",
            DialogResult = DialogResult.OK,
            Location = new Point(185, 75),
            Size = new Size(75, 28)
        };

        var btnCancel = new Button
        {
            Text = "Hủy",
            DialogResult = DialogResult.Cancel,
            Location = new Point(270, 75),
            Size = new Size(75, 28)
        };

        Controls.Add(lblNhan);
        Controls.Add(_txtGiaTri);
        Controls.Add(btnOk);
        Controls.Add(btnCancel);

        AcceptButton = btnOk;
        CancelButton = btnCancel;
    }

    // Tra ve gia tri moi, hoac null neu nguoi dung bam Huy.
    public static string? Hien(IWin32Window chu, string tieuDe, string nhan, string giaTriBanDau)
    {
        using var form = new frmInputBox(tieuDe, nhan, giaTriBanDau);
        return form.ShowDialog(chu) == DialogResult.OK ? form.GiaTri : null;
    }
}
