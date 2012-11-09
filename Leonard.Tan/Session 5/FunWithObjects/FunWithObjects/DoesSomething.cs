using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        private string lastAction;

        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title) : this()
        {
            Text = Text + " " + title;
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
            lastAction = Text;
            Text = "Done!";
        }

        public void UndoIt()
        {
            Text = lastAction;
        }

        private void UndoTheAction(object sender, System.EventArgs e)
        {
            UndoIt();
        }
    }
}
