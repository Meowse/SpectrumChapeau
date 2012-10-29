// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #3
// October 31, 2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculate
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
            Application.Run(new Form1());
        }
    }
}
