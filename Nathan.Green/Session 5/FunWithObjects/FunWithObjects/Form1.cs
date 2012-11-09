using System.Collections.Generic;
using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Form1 : Form
    {
        private readonly List<DoesSomething> _allDoesSomethings = new List<DoesSomething>();

        public Form1()
        {
            InitializeComponent();

// Uncomment this to make one that says "DoesSomething 51"
//            new DoesSomething(3, 17).Show();

// Uncomment these to make lots of DoesSomething instances.
//            DoesSomething myDoesSomething = new DoesSomething("Number 1");
//            myDoesSomething.Show();
//
//            new DoesSomething("Number 2").Show();
//            new DoesSomething("Number 3").Show();
//
//            new DoesSomething().Show();
        }

        private void MakeNewDoesSomething(object sender, System.EventArgs e)
        {
            DoesSomething newDoesSomething = new DoesSomething(WhatToDo.Text);
            newDoesSomething.Show();
            _allDoesSomethings.Add(newDoesSomething);
        }

        private void DoAllTheThings(object sender, System.EventArgs e)
        {
            foreach (DoesSomething thing in _allDoesSomethings)
            {
                if (thing.Done != true)
                {
                    thing.DoIt();
                    UndoAllButton.Enabled = true;
                    DoAllButton.Enabled = false;
                }
            }
        }

        private void OnLoad(object sender, System.EventArgs e)
        {
            UndoAllButton.Enabled = false;
        }

        private void UndoAllTheThings(object sender, System.EventArgs e)
        {
            foreach (DoesSomething thing in _allDoesSomethings)
            {
                if (thing.Undone != true)
                {
                    thing.UndoIt();
                    UndoAllButton.Enabled = false;
                    DoAllButton.Enabled = true;
                    th
                }
            }
        }
    }
}
