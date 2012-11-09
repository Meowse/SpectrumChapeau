using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Action : Form
    {
        public Action()
        {
            InitializeComponent();
        }

        public Action(string title) : this()
        {
            Text = Text + " " + title;
        }

        public Action(int thingOne, int thingTwo) : this((thingOne * thingTwo).ToString())
        {
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            DoIt();
        }

        public void DoIt()
        {
            Text = "Done!";
        }
    }
}
