using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        public string currentTitle;
        public string previousTitle;

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
        }

        public void DoIt()
        {
            previousTitle = currentTitle;
            Text = "Done " + currentTitle;
        }
    }
}
