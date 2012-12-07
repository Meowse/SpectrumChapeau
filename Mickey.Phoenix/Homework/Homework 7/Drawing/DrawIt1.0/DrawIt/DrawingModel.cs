using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DrawIt
{
    public class DrawingModel
    {
        private readonly Control _control;
        private readonly List<DrawAction> _drawActions = new List<DrawAction>();

        private int _numberOfActionsToDraw;
        private int _numberOfActionsDrawn;
        private Bitmap _backBuffer;

        private DrawAction Cursor { get; set; }

        public DrawingModel(Control control)
        {
            _control = control;
            control.Paint += Paint;
            control.SizeChanged += HandleControlSizeChanged;
            StopFlickerBySuspendingBackgroundRedrawing();
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
            UpdateBackBuffer();
            e.Graphics.DrawImageUnscaled(_backBuffer, 0, 0);
            if (Cursor != null)
            {
                Cursor.DrawOn(e.Graphics);
            }
        }

        private void UpdateBackBuffer()
        {
            if (_backBuffer == null)
            {
                _backBuffer = new Bitmap(_control.ClientSize.Width, _control.ClientSize.Height);
            }
            if (_numberOfActionsDrawn < _numberOfActionsToDraw)
            {
                Graphics g = Graphics.FromImage(_backBuffer);
                DrawOn(g);
                g.Dispose();
            }
        }

        public void Undo()
        {
            if (_numberOfActionsToDraw > 1)
            {
                _numberOfActionsToDraw--;
                _numberOfActionsDrawn = 0;
                UpdateBackBuffer();
                _control.Invalidate();
            }
        }

        public void Redo()
        {
            if (_numberOfActionsToDraw < _drawActions.Count)
            {
                _numberOfActionsToDraw++;
                UpdateBackBuffer();
                _control.Invalidate();
            }
        }

        public virtual void DrawLine(Pen pen, int x1, int y1, int x2, int y2, bool isCursor = false)
        {
            AddDrawAction(new DrawLineAction(pen, x1, y1, x2, y2), isCursor);
        }

        public virtual void DrawCircle(Pen pen, int x, int y, int radius, bool isCursor = false)
        {
            AddDrawAction(new DrawCircleAction(pen, x, y, radius), isCursor);
        }

        private void AddDrawAction(DrawAction drawAction, bool isCursor = false)
        {
            if (isCursor)
            {
                Cursor = drawAction;
            }
            else
            {
                Cursor = null;
                _numberOfActionsToDraw++;
                _drawActions.Add(drawAction);
            }
            drawAction.Invalidate(_control);
        }

        public void DrawOn(Graphics graphics)
        {
            foreach (DrawAction drawAction in _drawActions.Take(_numberOfActionsToDraw).Skip(_numberOfActionsDrawn))
            {
                drawAction.DrawOn(graphics);
            }
            _numberOfActionsDrawn = _numberOfActionsToDraw;
        }

        public virtual void Clear(Color color)
        {
            _drawActions.Clear();
            _numberOfActionsToDraw = 0;
            _numberOfActionsDrawn = 0;
            AddDrawAction(new DrawBackgroundAction(color));
        }

        public virtual void Clear()
        {
            _drawActions.Clear();
            _numberOfActionsToDraw = 0;
            _numberOfActionsDrawn = 0;
            _control.Invalidate();
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

