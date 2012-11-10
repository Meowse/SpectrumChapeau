using System.Collections.Generic;
using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Form1 : Form
    {
        private readonly List<DoesSomething> _allDoesSomethings = new List<DoesSomething>();

        public DoesSomething LastUpdatedDoSomething;
        public bool UndoneAll = false;
        public bool DoneAll = false;
        public DoesSomething LastUpdatedFormReference;
        //public Form1 mainForm = this;

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
            if (WhatToDo.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid value in the entry field.");
            }
            else
            {
                DoesSomething newDoesSomething = new DoesSomething(WhatToDo.Text,this);
                newDoesSomething.Show();
                WhatToDo.Text = "";
                _allDoesSomethings.Add(newDoesSomething);             
            }
        }

        private void DoAllTheThings(object sender, System.EventArgs e)
        {
            UndoneAll = false;
            DoneAll = true;
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
            RevertLastActionButton.Enabled = false;
        }

        private void UndoAllTheThings(object sender, System.EventArgs e)
        {
            UndoneAll = true;
            DoneAll = false;
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
            if(LastUpdatedFormReference.Done == true)
            {
                LastUpdatedFormReference.UndoIt();
            }
            else
            {
                LastUpdatedFormReference.DoIt();
            }
        }
    }
}
