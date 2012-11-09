using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        private string _action;


        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title) : this()
        {
            Text = Text + " " + title;
            _action = title;
        }

        public DoesSomething(int thingOne, int thingTwo) : this((thingOne * thingTwo).ToString())
        {
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            if (button1.Text == "Do It!")
            {
                DoIt();
                button1.Text = "Undo";
            }
            else
            {
                Undo();
                button1.Text = "Do It!";
            }

        }

        public void DoIt()
        {
            Text = "Done (" + _action + ")";
        }

        public void Undo()
        {
            Text = "Action: " + _action;
        }
    }
}
