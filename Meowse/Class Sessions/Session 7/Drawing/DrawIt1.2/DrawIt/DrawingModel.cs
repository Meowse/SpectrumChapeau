using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DrawIt
{
    public class DrawingModel
    {
        private readonly Control _control;
        private readonly IActionSource<IDrawAction> _drawActionSource;
        private Bitmap _backBuffer;

        private IDrawAction _cursor;
        public IDrawAction Cursor
        {
            get { return _cursor; }
            set
            {
                _cursor = value;
                _control.Invalidate();
            }
        }

        private IDrawAction _background;
        public IDrawAction Background
        {
            get { return _background; }
            set
            {
                _background = value; 
                DrawActionsChanged();
            }
        }

        public DrawingModel(Control control, IActionSource<IDrawAction> drawActionSource)
        {
            _control = control;
            _drawActionSource = drawActionSource;

            // This line says, "I want to listen to my _drawActionSource for changes to 
            // its Actions.  Every time its Actions changes, I want it to call my
            // DrawActionsChanged method, so I can appropriately update the _control that
            // I'm drawing onto."
            _drawActionSource.ActionsChanged += DrawActionsChanged;

            control.Paint += Paint;
            control.SizeChanged += HandleControlSizeChanged;
            StopFlickerBySuspendingBackgroundRedrawing();
            UpdateBackBuffer();
        }

        private void StopFlickerBySuspendingBackgroundRedrawing()
        {
            typeof (Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(
                _control, true, null);
        }

        private void HandleControlSizeChanged(object sender, EventArgs e)
        {
            if (_backBuffer != null)
            {
                _backBuffer.Dispose();
                _backBuffer = null;
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(_backBuffer, 0, 0);
            if (Cursor != null)
            {
                Cursor.DrawOn(e.Graphics);
            }
        }

        public void DrawActionsChanged()
        {
            UpdateBackBuffer();
            _control.Invalidate();    
        }

        private void UpdateBackBuffer()
        {
            if (_backBuffer == null)
            {
                _backBuffer = new Bitmap(_control.ClientSize.Width, _control.ClientSize.Height);
            }

            Graphics g = Graphics.FromImage(_backBuffer);
            DrawOn(g);
            g.Dispose();
        }

        public void DrawOn(Graphics graphics)
        {
            if (Background != null)
            {
                Background.DrawOn(graphics);
            }
            foreach (IDrawAction drawAction in _drawActionSource.Actions)
            {
                drawAction.DrawOn(graphics);
            }
        }
    }
}

