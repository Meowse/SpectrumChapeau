using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        private string lastActionText;

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
            lastActionText = Text;
            Text = "Done!";
            toggle_DoUndo();

        }

        public void UndoIt()
        {
            Text = lastActionText;
            toggle_DoUndo();
        }

        private void UndoTheAction(object sender, System.EventArgs e)
        {
            UndoIt();
        }

        private void toggle_DoUndo()
        {
            if (button1.Enabled == true)
            {
                button2.Enabled = true;
                button1.Enabled = false;
            }
            else if (button2.Enabled == true)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
    }
}
