using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
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
            Text = "Done!";
        }

        private void DoesSomething_Load(object sender, System.EventArgs e)
        {

        }
    }
}
