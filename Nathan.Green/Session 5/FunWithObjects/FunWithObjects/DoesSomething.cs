using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        public string currentTitle;
        public string previousTitle;
        private bool recentlyChanged;

        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title) : this()
        {
            Text = "Action:" + " " + title;
            currentTitle = title;
        }

        public DoesSomething(int thingOne, int thingTwo) : this((thingOne * thingTwo).ToString())
        {
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            DoIt();
            recentlyChanged = true;
            UndoButton.Enabled = true;
            DoButton.Enabled = false;
        }

        public void DoIt()
        {
            previousTitle = currentTitle;
            Text = "Done " + currentTitle;
        }

        private void DoesSomething_Load(object sender, System.EventArgs e)
        {
            UndoButton.Enabled = false;
        }

        private void UndoTheAction(object sender, System.EventArgs e)
        {
            UndoIt();
            recentlyChanged = true;
            UndoButton.Enabled = false;
            DoButton.Enabled = true;
        }

        public void UndoIt()
        {
            currentTitle = previousTitle;
            Text = "Action:" + " " + currentTitle;
        }
    }
}
