using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        private string _action = "";
        //private bool FirstTime = true;
        private int ExtentOfUse = 0;

        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title)
            : this()
        {

            Text = Text + "  " + title;
            _action = " " + title;
        }

        public DoesSomething(int thingOne, int thingTwo)
            : this((thingOne*thingTwo).ToString())
        {
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            DoIt();
        }

        public void DoIt()
        {
            if (ExtentOfUse == 3)
            {
                MessageBox.Show("You can only Undo One Time");
            }

            else
            {

                if (button1.Text == "Do It!")
                {
                    Text = "Done! " + _action;
                    button1.Text = "Undo";
                    ExtentOfUse = ExtentOfUse + 1;
                }
                else
                {
                    Text = "Action: " + _action;
                    button1.Text = "Do It!";
                    ExtentOfUse = ExtentOfUse + 1;
                }

            }
        }
    }
}
