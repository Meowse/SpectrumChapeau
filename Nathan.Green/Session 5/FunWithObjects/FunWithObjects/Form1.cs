using System.Collections.Generic;
using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Form1 : Form
    {
        private readonly List<DoesSomething> _allDoesSomethings = new List<DoesSomething>();
        public List<DoesSomething> LastTouchedWindow = new List<DoesSomething>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeNewDoesSomething(object sender, System.EventArgs e)
        {
            if (WhatToDo.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid value in the entry field.");
            }
            else
            {
                DoesSomething newDoesSomething = new DoesSomething(WhatToDo.Text);
                newDoesSomething.Show();
                _allDoesSomethings.Add(newDoesSomething);   
            }
        }

        private void DoAllTheThings(object sender, System.EventArgs e)
        {
            foreach (DoesSomething thing in _allDoesSomethings)
            {
                if (thing.Done != true)
                {
                    thing.DoIt();
                }
            }
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
        }

        private void UndoAllTheThings(object sender, System.EventArgs e)
        {
            foreach (DoesSomething thing in _allDoesSomethings)
            {
                if (thing.Undone != true)
                {
                    thing.UndoIt();
                }
            }
        }

        private void RevertLastAction(object sender, System.EventArgs e)
        {

        }
    }
}
