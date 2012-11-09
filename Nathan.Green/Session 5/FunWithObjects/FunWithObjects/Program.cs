using System;
using System.Windows.Forms;

namespace FunWithObjects
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // MessageBox.Show("Just before application.run");
            Application.Run(new Form1());
            // MessageBox.Show("Just after application.run");
        }
    }
}
