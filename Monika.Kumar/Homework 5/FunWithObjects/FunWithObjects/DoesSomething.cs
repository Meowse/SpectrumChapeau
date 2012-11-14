using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        private string message = string.Empty;
        public DoesSomething()
        {
            InitializeComponent();
        }

        public DoesSomething(string title) : this()
        {
            this.message = title;
            Text = Text + " " + this.message;
            this.button1.Enabled = true;
            this.button2.Enabled = false;
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
            Text = string.Format("Done {0}!", this.message);
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button2.Focus();
            this.AcceptButton = this.button2;
        }
        private void UndoTheAction(object sender, System.EventArgs e)
        {
            Undo();
        }
        public void Undo()
        {
            Text = string.Format("Undone {0}!", this.message);
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            Undo();
            this.button2.Enabled = false;
            this.button1.Enabled = true;
            this.button1.Focus();
            this.AcceptButton = this.button1;
        }

        private void DoesSomething_Load(object sender, System.EventArgs e)
        {

        }
    }
}
