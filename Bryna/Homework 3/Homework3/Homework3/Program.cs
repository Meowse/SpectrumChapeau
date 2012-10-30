
// Bryna Shane
// .Net Development Foundations, Fall 2012
// Homework Assignment #3
// October 31, 2012
//
//  Assignment Tasks:  
//
//  Create a Visual Studio solution.
//  Create a Windows Forms application in this solution.
//  Put a TextBox, a Button (“Hello!”), and a Label on the form.
//  
//  When the user types their name into the TextBox, and clicks the “Hello!” button,
//  show a MessageBox that says, “Hello, <contents of the TextBox>!”
//
//  Program.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Homework3
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
            Application.Run(new HelloForm());
        }
    }
}
