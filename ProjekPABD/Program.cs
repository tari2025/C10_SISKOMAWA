using System;
using System.Windows.Forms;

namespace ProjekPABD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDashboard()); // ← HARUS ADA INI!
        }
    }
}