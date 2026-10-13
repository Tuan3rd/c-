namespace Lab05WinForms;

internal static class Program
{
    /// <summary>
    /// Diem bat dau cua ung dung. Form khoi dong la frmMain (menu chon bai tap),
    /// tu do mo cac form bai tap bang ShowDialog().
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmMain());
    }
}
