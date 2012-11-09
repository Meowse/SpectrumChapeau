using System.Collections.Generic;
using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Form1 : Form
    {
        private readonly List<Action> _allDoesSomethings = new List<Action>();

        public Form1()
        {
            InitializeComponent();

// Uncomment this to make one that says "Action 51"
//            new Action(3, 17).Show();

// Uncomment these to make lots of Action instances.
//            Action myDoesSomething = new Action("Number 1");
//            myDoesSomething.Show();
//
//            new Action("Number 2").Show();
//            new Action("Number 3").Show();
//
//            new Action().Show();
        }

        private void MakeNewDoesSomething(object sender, System.EventArgs e)
        {
            Action newDoesSomething = new Action(WhatToDo.Text);
            newDoesSomething.Show();
            _allDoesSomethings.Add(newDoesSomething);
        }

        private void DoAllTheThings(object sender, System.EventArgs e)
        {
            foreach (Action thing in _allDoesSomethings)
            {
                thing.DoIt();
            }
        }

        private void WhatToDo_TextChanged(object sender, System.EventArgs e)
        {

        }
    }

}
