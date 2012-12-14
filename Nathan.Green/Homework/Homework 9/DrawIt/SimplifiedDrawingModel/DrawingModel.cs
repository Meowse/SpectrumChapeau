using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ActionSources;

namespace SimplifiedDrawingModel
{
    public class DrawingModel
    {
        private static Control _control;
        private static IActionSource<IDrawAction> _drawActionSource;
        private static Bitmap _backBuffer;

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

        private static IDrawAction _background;
        public static IDrawAction Background
        {
            get { return _background; }
            set
            {
                _background = value; 
                DrawActionsChanged();
            }
        }

        public static bool DrawGrid = false;

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

        public static void DrawActionsChanged()
        {
            UpdateBackBuffer();
            _control.Invalidate();    
        }

        private static void UpdateBackBuffer()
        {
            if (_backBuffer == null)
            {
                _backBuffer = new Bitmap(_control.ClientSize.Width, _control.ClientSize.Height);
            }

            Graphics g = Graphics.FromImage(_backBuffer);
            DrawOn(g);
            g.Dispose();
        }

        public static void DrawOn(Graphics graphics)
        {
            Pen cursorPen = new Pen(Color.Black, 1);
            
            if (Background != null)
            {
                Background.DrawOn(graphics);
            }

            if (DrawGrid)
            {
                for (int i = 0; i <= 600; i += 5)
                {
                    for (int j = 0; j <= 500; j += 5)
                    {
                        graphics.DrawLine(cursorPen, i, j, i+1, j);
                    }
                }
            }

            foreach (IDrawAction drawAction in _drawActionSource.Actions)
            {
                drawAction.DrawOn(graphics);
            }
        }
    }
}

