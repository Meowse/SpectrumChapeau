using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        public string currentTitle;
        public string previousTitle;
        public bool recentlyChanged;
        public bool Undone=false;
        public bool Done=false;

        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title) : this()
        {
            Text = "Action:" + " " + title;
            currentTitle = title;
            Done = false;
            Undone = true;
        }

        public DoesSomething(int thingOne, int thingTwo) : this((thingOne * thingTwo).ToString())
        {
            Done = false;
            Undone = true;
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            DoIt();
        }

        public void DoIt()
        {
            previousTitle = currentTitle;
            Text = "Done: " + currentTitle;
            Undone = false;
            Done = true;
            UndoButton.Enabled = true;
            DoButton.Enabled = false;
        }

        private void DoesSomething_Load(object sender, System.EventArgs e)
        {
            UndoButton.Enabled = false;
        }

        private void UndoTheAction(object sender, System.EventArgs e)
        {
            UndoIt();
        }

        public void UndoIt()
        {
            currentTitle = previousTitle;
            Text = "Action:" + " " + currentTitle;
            Undone = true;
            Done = false;
            UndoButton.Enabled = false;
            DoButton.Enabled = true;
        }
    }
}
