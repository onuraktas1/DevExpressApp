using CafeOtomasyon.WinForms.AnaMenu;

namespace CafeOtomasyon.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmAnaMenu());
            
        }
    }
}