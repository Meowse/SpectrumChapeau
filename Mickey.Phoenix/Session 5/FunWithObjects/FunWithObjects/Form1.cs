using System.Collections.Generic;
using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Form1 : Form
    {
        private readonly List<Action> _allActions = new List<Action>();
        private Action _lastActionChanged;

        // The "static" keyword here means that "LastActionChanged" belongs
        // to the class Form1, and not to a particular instance of that class.
        // You refer to it as "Form1.LastActionChanged", rather than
        // as "myForm1Instance.LastActionChanged".
        public Action LastActionChanged
        {
            get { return _lastActionChanged; }
            set
            {
                _lastActionChanged = value;
                doOrUndoLastChanged.Enabled = true;
            }
        }

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
            Action newAction = new Action(WhatToDo.Text, this);
            newAction.Show();
            _allActions.Add(newAction);
        }

        private void DoAllTheThings(object sender, System.EventArgs e)
        {
            foreach (Action action in _allActions)
            {
                action.IsDone = true;
            }
        }

        private void ToggleLastActionState(object sender, System.EventArgs e)
        {
            if (_allActions.Count > 0)
            {
                Action lastAction = _allActions[_allActions.Count - 1];
                lastAction.IsDone = !lastAction.IsDone;
            }
            else
            {
                // Note use of the backslash "escape character" to allow me to include
                // a literal double-quote character inside a string whose ends are marked
                // with double-quotes (a "double-quote-delimited string")
                MessageBox.Show("There is no \"Last Action\" to Do or Undo.");
            }
        }

        private void DoOrUndoLastChanged(object sender, System.EventArgs e)
        {
            if (LastActionChanged != null)
            {
                LastActionChanged.IsDone = !LastActionChanged.IsDone;
            }
            else
            {
                MessageBox.Show("No changed action to do/undo");
            }
        }
    }
}
