using System.Collections.Generic;
using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        private readonly List<DoesSomething> _allDoesSomethings = new List<DoesSomething>();

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = this.button1;
            


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
                if (thing.Text.StartsWith("Action"))
                {
                    thing.DoIt();
                }
            }
        }

        private void UndoLastActionClick(object sender, System.EventArgs e)
        {
//            button2.Enabled = false;  //have to disable button if calling this
//            foreach (DoesSomething thing in _allDoesSomethings)
//            {
//                counter = counter + 1;
//                if (counter == _allDoesSomethings.Count)
//                {
//
//                    thing.DoIt();
//                    _allDoesSomethings.RemoveAt(counter - 1);
//                    counter = 0;
//                    break;
//                }
//               // else
//               // {
//
//               // }
//
//            }
            int lastIndex = _allDoesSomethings.Count - 1;
            if (lastIndex >= 0)
            {
                DoesSomething lastAction = _allDoesSomethings[lastIndex];
                lastAction.DoIt();
            }
            else
            {
                MessageBox.Show("No 'last action' to Do or Undo!");
            }
        }

        //private void button4_Click(object sender, System.EventArgs e)
        //{
            
            //foreach(Control control in Controls)
            //{
            //    if(!control.GetType().Name.Contains("Button"))
            //    MessageBox.Show(control.Text);
            //}

            
        //}

    }
}
