namespace Lab05ContinueWinForms;

internal static class Program
{
    /// <summary>
    /// Diem bat dau cua ung dung. Form khoi dong la frmMain (BTVN Bai 2: Form main co
    /// MenuStrip gan tat ca bai tap trong tuan, hien thi cac form khi chon menu tuong ung).
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmMain());
    }
}
