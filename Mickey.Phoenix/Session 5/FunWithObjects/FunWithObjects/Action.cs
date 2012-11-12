using System.Windows.Forms;

namespace FunWithObjects
{
    public partial class Action : Form
    {
        private const string _DONE_TITLE_FORMAT = "Done ({0})";
        private const string _ACTION_TITLE_FORMAT = "Action: {0}";
        private const string _UNDO_ACTION_BUTTON_LABEL = "Undo";
        private const string _DO_ACTION_BUTTON_LABEL = "Do it!";

        private bool _isDone;
        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                bool attemptingUndo = _isDone && !value;

                if (attemptingUndo)
                {
                    if (_hasBeenUndone)
                    {
                        return;
                    }
                    _hasBeenUndone = true;
                }
                _isDone = value;
                UpdateUI();
            }
        }

        private bool _hasBeenUndone;
        private readonly string _description;

        public Action()
        {
            InitializeComponent();
        }

        public Action(string description) : this()
        {
            _description = description;
            UpdateUI();
        }

        private void ToggleState(object sender, System.EventArgs e)
        {
            IsDone = !IsDone;
        }

        private void UpdateUI()
        {
            UpdateWindowTitle();
            UpdateActionButton();
        }

        private void UpdateWindowTitle()
        {
            string format = IsDone ? _DONE_TITLE_FORMAT : _ACTION_TITLE_FORMAT;
            Text = string.Format(format, _description);
        }

        private void UpdateActionButton()
        {
            actionButton.Text = IsDone ? _UNDO_ACTION_BUTTON_LABEL : _DO_ACTION_BUTTON_LABEL;
            if (IsDone && _hasBeenUndone)
            {
                actionButton.Enabled = false;
            }
        }
    }
}
