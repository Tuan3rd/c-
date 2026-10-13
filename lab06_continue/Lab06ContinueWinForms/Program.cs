namespace Lab06ContinueWinForms;

internal static class Program
{
    // Form khoi dong la frmMain (menu chon bai tap), tu do mo cac form con bang ShowDialog().
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmMain());
    }
}
