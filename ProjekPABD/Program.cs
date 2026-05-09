using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekPABD
{
        internal static class Program
        {
            /// <summary>
            /// Main Program
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();

                Application.SetCompatibleTextRenderingDefault(false);

                // FORM PERTAMA
                Application.Run(new FormDashboard());
            }
        }
    }