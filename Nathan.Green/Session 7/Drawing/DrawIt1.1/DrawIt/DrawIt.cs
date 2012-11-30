using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawIt
{
    /// <summary>
    /// What you have to work with:
    /// 
    /// 1) DrawingModel is a class that encapsulates ("hides the unpleasant bits of) the Windows drawing API
    /// (called "GDI+"), to make it easy for you to draw lines and circles on a control (like a Panel).
    /// 
    /// 2) You can find out the methods that DrawingModel provides for you by control-clicking on "DrawingModel"
    /// below, or by opening DrawingModel.cs and looking for "public class DrawingModel".
    /// 
    /// 3) I've set up a DrawingModel on the CanvasPanel for you.  I've also implemented the methods ShowCurrentPlayer1Location()
    /// and ShowCurrentPlayer2Location() so you can see an example of how to use GridDrawingModel.
    /// 
    /// 4) I've set up the DrawIt class to listen to some "mouse events" from the CanvasPanel (MouseDown when the mouse button is
    /// pressed, MouseUp when the mouse button is released, and MouseMoved when the mouse is moved).  You will draw things on the
    /// CanvasPanel in response to those mouse events.
    /// 
    /// Your job:
    /// 
    /// 1) Add as many of the requested features to this program as you can.
    /// 2) Fix as many of the bugs in this program as you can.
    /// 
    /// Features:
    ///     1) Line width should be changeable.
    ///     2) The user should be able to draw ovals that fill the "virtual rectangle" defined by dragging the mouse.  If the user 
    ///         dragged the mouse from (0,0) to (100,10), this would draw a horizontal oval that went from (0,5) to (100,5) horizontally,
    ///         and from (50,0) to (50,10) vertically.
    ///     3) Hitting the "Esc" key should stop the current drawing action, and make the cursor disappear.  If the user starts dragging the mouse,
    ///         and then hits "Esc", and then releases the mouse button, nothing should be drawn.
    ///     4) Color should be changeable.  We get tired of Red all the time.
    ///     5) Closed shapes like circles and rectangles should have a "fill" option that draws a solid shape instead of an outline.
    ///
    /// Bugs (some of these are VERY TRICKY):
    ///     1) Undo doesn't work to undo a "Clear".
    ///     2) Rectangle and X don't draw the correct cursor.  They only draw one of their lines as a cursor.
    ///     3) Rectangle and X don't Undo/Redo as units.  Instead, they Undo/Redo one line at a time.
    ///     4) When you Undo something and then draw something new, the new things should replace all of the undone actions.
    ///         Instead, it adds the new thing onto the end of the draw actions, and redraws one of the things you previously undid.
    ///     5) The Undo and Redo buttons are always enabled.  Intead, the Undo button should be disabled when there is nothing to Undo,
    ///         and the Redo button should be disabled when there is nothing to Redo.
    /// 
    /// Tricks and Gotchas:
    /// 
    /// 1) As is relatively standard for software, the "X" (horizontal) coordinate increases from left to right...
    ///     ...and the "Y" (vertical) coordinate increases from TOP to BOTTOM.  The coordinate (0,0) is in the upper left corner of the
    ///     thing you are drawing on (such as "canvasPanel").  This is VERY DIFFERENT from a "normal" (i.e. algebraic or geometric)
    ///     "Cartesian" coordinate grid, where (0,0) is in the middle of the graph, and the Y (vertical) coordinate increases from bottom
    ///     to top.  This is VERY CONFUSING.  I recommend strongly that you sketch out the coordinates on a piece of paper, with 0,0 in the
    ///     upper left corner, and the values increasing to the right and downward, before you try to draw using GridDrawingModel.
    /// 
    /// 2) One way to fix bugs (2) and (3) would be to create a RectangleDrawAction and an XDrawAction,
    ///     and add methods DrawRectangle() and DrawX() to DrawingModel.  A different way to fix bugs (2) and (3) 
    ///     would be to create a CompositeDrawAction that combines several DrawActions into one, and make DrawingModel's
    ///     AddDrawAction() method public.  There are advantages and disadvantages to each approach.
    /// 
    /// 3) You could fix defect (4) by fiddling around with the undo/redo code in DrawingModel.  But that code is already really complicated.
    ///     The easier way to fix defect (4) is to create a new class, UndoRedoStack, which encapsulates all of the complicated behavior
    ///     of managing Undo and Redo actions for the DrawingModel.  We'll be doing this together in next Tuesday's class, but go ahead and
    ///     work on it now.
    /// 
    /// Enjoy!
    /// </summary>

    public partial class DrawIt : Form, IPaintbrushEventHandler
    {
        private const int _LINE_WIDTH = 3;
        private const int _CIRCLE_RADIUS = 5;

        // This DrawingModel wraps around the CanvasPanel and gives you a simple interface for drawing
        // lines and circles onto it.  This line doesn't actually create a DrawingModel -- we'll do
        // that in the DrawIt constructor below!
        private readonly DrawingModel _canvasModel;

        // A Pen is used by the drawing libraries to actually draw on the screen.  It controls things
        // like color, line width, etc.  We'll create a pen in the DrawIt constructor as well.
        private readonly Pen _pen;

        private static readonly Color _BACKGROUND_COLOR = Color.DarkGray;
        private static readonly Color _COLOR = Color.Red;

        // This is a constructor method for the DrawIt class.  Notice that it has the same name ("DrawIt") as the class,
        // and does not have a return type.  That's how we know it's a constructor method.
        public DrawIt()
        {
            // This may look familiar from last week's "create a Windows Forms application" assignment.
            // It is generated by Visual Studio to do the initial setup of the controls on your Windows Form.
            InitializeComponent();

            // This line creates a new DrawingModel which wraps around and encapsulates 
            // the CanvasPanel, and then stores that DrawingModel into the instance variable 
            // _canvasModel.
            //
            // Since _canvasModel is an "instance variable" (declared as part of the DrawIt
            // class, above), all of the "instance methods" here in DrawIt (also declared as
            // part of the DrawIt class) will be able to see it.  Anything that wants to draw
            // something on the canvas can say _canvasModel.DrawLine() or _canvasModel.DrawCircle() or...
            //
            // I have implemented versions of HandleMouseDown() and HandleMouseMoved() below
            // that draw simple circles on the canvas, and a circular cursor to show where
            // the next circle will be drawn, to illustrate how to use the DrawingModel.
            _canvasModel = new DrawingModel(CanvasPanel);

            // This line creates a PaintbrushControlModel to listen to the mouse events from the
            // CanvasPanel, and call our IPaintbrushEventHandler methods when appropriate.
            //
            // When we created the DrawingModel above, we put it into an instance variable called
            // "_canvasModel", because we needed to be able to call methods on it later.
            // 
            // We don't need to call any methods on the PaintbrushControlModel later, so we 
            // aren't going to put it into an instance variable.  Just creating it with the
            // CanvasPanel and ourself is enough.
            //
            // If we decided later to give the PaintbrushControlModel methods that we'd want
            // to call (for example, a "SuspendDrawing()" method that blocked all drawing
            // actions from being forwarded to us), we'd make an instance variable _paintbrushControlModel
            // and set its value to this new object.
            new PaintbrushControlModel(CanvasPanel, this);

            // This creates the Pen intance that draws lines on the canvas.
            _pen = new Pen(_COLOR, _LINE_WIDTH);

            // This starts us out with a dark gray background on the canvas (so the user can see
            // where to draw).
            _canvasModel.Clear(_BACKGROUND_COLOR);
        }

        public void DrawSomethingAt(Point location, bool isCursor)
        {
            if (DrawCirclesButton.Checked)
            {
                _canvasModel.DrawCircle(_pen, location.X, location.Y, _CIRCLE_RADIUS, isCursor);
            }
            else
            {
                _canvasModel.DrawCircle(_pen, location.X, location.Y, _LINE_WIDTH / 2, isCursor);
            }            
        }

        public void DrawSomethingFrom(Point start, Point end, bool isCursor)
        {            
            if (DrawCirclesButton.Checked)
            {
                // Draw a circle whose center is start, and whose outside passes through end
                _canvasModel.DrawCircle(_pen, start.X, start.Y, MathHelpers.GetRadius(start, end), isCursor);
            }
            else if (DrawXesButton.Checked)
            {
                _canvasModel.DrawLine(_pen, start.X, start.Y, end.X, end.Y, isCursor);
                _canvasModel.DrawLine(_pen, start.X, end.Y, end.X, start.Y, isCursor);
            }
            else if (DrawRectanglesButton.Checked)
            {
                _canvasModel.DrawLine(_pen, start.X, start.Y, end.X, start.Y, isCursor);
                _canvasModel.DrawLine(_pen, end.X, start.Y, end.X, end.Y, isCursor);
                _canvasModel.DrawLine(_pen, end.X, end.Y, start.X, end.Y, isCursor);
                _canvasModel.DrawLine(_pen, start.X, end.Y, start.X, start.Y, isCursor);
            }
            else
            {
                _canvasModel.DrawLine(_pen, start.X, start.Y, end.X, end.Y, isCursor);
            }
        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            _canvasModel.Clear(_BACKGROUND_COLOR);
        }

        private void UndoButtonClicked(object sender, EventArgs e)
        {
            _canvasModel.Undo();
        }

        private void RedoButtonClicked(object sender, EventArgs e)
        {
            _canvasModel.Redo();
        }
    }
}
