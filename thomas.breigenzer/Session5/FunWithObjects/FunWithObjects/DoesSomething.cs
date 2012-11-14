using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class DoesSomething : Form
    {
        public string previousText;
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
            previousText = Text;
            MessageBox.Show(previousText);
            Text = "Done!";
        }
        public void JustUndoIt()
        {
            Text = previousText;
            MessageBox.Show(Text);
        }

        //private void JustUndoTheAction(object sender, System.EventArgs e)
        //{
        //    JustUndoIt();
        //}

        private void JustUndoTheAction(object sender, System.EventArgs e)
        {
            JustUndoIt();
        }

        
      }
}
