using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace DrawIt
{
    public class DrawingModel
    {
        private readonly Control _control;
        private readonly IActionSource<DrawAction> _drawActionSource;
        private Bitmap _backBuffer;

        private DrawAction _cursor;
        public DrawAction Cursor
        {
            get { return _cursor; }
            set
            {
                _cursor = value; 
                DrawActionsChanged();
            }
        }

        private DrawAction _background;
        public DrawAction Background
        {
            get { return _background; }
            set
            {
                _background = value; 
                DrawActionsChanged();
            }
        }

        public DrawingModel(Control control, IActionSource<DrawAction> drawActionSource)
        {
            _control = control;
            _drawActionSource = drawActionSource;

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
            foreach (DrawAction drawAction in _drawActionSource.Actions)
            {
                drawAction.DrawOn(graphics);
            }
        }
    }

    public abstract class DrawAction
    {
        public abstract void DrawOn(Graphics graphics);

        public virtual void Invalidate(Control control)
        {
            control.Invalidate();
        }
    }

    public class DrawBackgroundAction : DrawAction
    {
        private readonly Color _backgroundColor;

        public DrawBackgroundAction(Color backgroundColor)
        {
            _backgroundColor = backgroundColor;
        }

        public override void DrawOn(Graphics graphics)
        {
            graphics.Clear(_backgroundColor);
        }
    }

    public class DrawLineAction : DrawAction
    {
        private readonly Pen _pen;
        private readonly Point _startPoint;
        private readonly Point _endPoint;

        public DrawLineAction(Pen pen, int x1, int y1, int x2, int y2)
        {
            _pen = pen;
            _startPoint = new Point(x1, y1);
            _endPoint = new Point(x2, y2);

        }

        public override void DrawOn(Graphics graphics)
        {
            graphics.DrawLine(_pen, _startPoint, _endPoint);
        }
    }

    public class DrawCircleAction : DrawAction
    {
        private readonly Pen _pen;
        private readonly Point _center;
        private readonly int _radius;
        private readonly int _diameter;

        public DrawCircleAction(Pen pen, int x, int y, int radius)
        {
            _pen = pen;
            _center = new Point(x, y);
            _radius = radius;
            _diameter = _radius*2;
        }

        public override void DrawOn(Graphics graphics)
        {
            graphics.DrawArc(_pen, _center.X - _radius, _center.Y - _radius, _diameter, _diameter, 0, 360);
        }
    }
}

