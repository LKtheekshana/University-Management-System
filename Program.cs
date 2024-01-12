using System;
using System.Windows.Forms;

namespace NIBM_Management_System
{
    internal static class Program
    {
    
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}