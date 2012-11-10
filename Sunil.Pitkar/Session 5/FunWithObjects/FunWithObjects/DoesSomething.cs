using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        public string currentTitle;
        public string previousTitle;
        public bool recentlyChanged;
        public bool lastChanged=false;
        public bool Undone=false;
        public bool Done=false;
        public int formId = 0;
        public Form1 parentForm;

       //public DoesSomething LastObjectTouched;

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

        public DoesSomething(string title, Form1 mainForm) : this()
        {
            Text = "Action:" + " " + title;
            currentTitle = title;
            Done = false;
            Undone = true;
            parentForm = mainForm;

        }

        public DoesSomething(int thingOne, int thingTwo) : this((thingOne * thingTwo).ToString())
        {
            Done = false;
            Undone = true;
        }

        private void DoTheAction(object sender, System.EventArgs e)
        {
            DoIt();
            parentForm.LastUpdatedFormReference = this;
            
        }

        public void DoIt()
        {
            previousTitle = currentTitle;
            Text = "Done: " + currentTitle;
            Undone = false;
            Done = true;
            UndoButton.Enabled = true;
            DoButton.Enabled = false;
            lastChanged = true;
            parentForm.RevertLastActionButton.Enabled = true;
        }

        private void DoesSomething_Load(object sender, System.EventArgs e)
        {
            UndoButton.Enabled = false;
            //parentForm.RevertLastActionButton.Enabled = false;
        }

        private void UndoTheAction(object sender, System.EventArgs e)
        {
            UndoIt();
            parentForm.LastUpdatedFormReference = this;
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
