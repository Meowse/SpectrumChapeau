using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        private string _action = "";

        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title) : this()
        {
            
            Text = Text + "  " + title;
            _action = " " + title;



        }

        public DoesSomething(int thingOne, int thingTwo) : this((thingOne * thingTwo).ToString())
        {
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            DoIt();
        }

        public void DoIt()
        {
            if (button1.Text == "Do It!")
            {
                Text = "Done! " + _action;
                button1.Text = "Undo";
            }
            else
            {
                Text = "Action: "+ _action;
                button1.Text = "Do It!";
            }

     
        }
    }
}
