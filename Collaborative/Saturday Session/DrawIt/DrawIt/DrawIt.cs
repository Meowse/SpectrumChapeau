﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ActionSources;
using SimplifiedDrawingModel;

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
    /// 1) Draw things on the CanvasPanel using the DrawingModel in response to mouse events.
    /// 
    /// Tricks and Gotchas:
    /// 
    /// As is relatively standard for software, the "X" (horizontal) coordinate increases from left to right...
    /// ...and the "Y" (vertical) coordinate increases from TOP to BOTTOM.  The coordinate (0,0) is in the upper left corner of the
    /// thing you are drawing on (such as "canvasPanel").  This is VERY DIFFERENT from a "normal" (i.e. algebraic or geometric)
    /// "Cartesian" coordinate grid, where (0,0) is in the middle of the graph, and the Y (vertical) coordinate increases from bottom
    /// to top.  This is VERY CONFUSING.  I recommend strongly that you sketch out the coordinates on a piece of paper, with 0,0 in the
    /// upper left corner, and the values increasing to the right and downward, before you try to draw using GridDrawingModel.
    /// 
    /// Enjoy!
    /// </summary>

    public partial class DrawIt : Form
    {
        private const int _LINE_WIDTH = 3;

        // This DrawingModel wraps around the CanvasPanel and gives you a simple interface for drawing
        // lines and circles onto it.  This line doesn't actually create a DrawingModel -- we'll do
        // that in the DrawIt constructor below!
        private readonly DrawingModel _canvasModel;
        private readonly IUndoRedoActionSource<IDrawAction> _actions; 

        // A Pen is used by the drawing libraries to actually draw on the screen.  It controls things
        // like color, line width, etc.  We'll create a pen in the DrawIt constructor as well.
        private readonly Pen _pen;

        // A Pen of a different color to draw the cursor with.
        private readonly Pen _cursorPen;

        private static readonly Color _BACKGROUND_COLOR = Color.DarkGray;
        private static readonly Color _COLOR = Color.Red;
        private static readonly Color _CURSOR_COLOR = Color.AliceBlue;
        private Point _startPoint;
        private bool _isDrawing;

        // This is a constructor method for the DrawIt class.  Notice that it has the same name ("DrawIt") as the class,
        // and does not have a return type.  That's how we know it's a constructor method.
        public DrawIt()
        {
            // This may look familiar from last week's "create a Windows Forms application" assignment.
            // It is generated by Visual Studio to do the initial setup of the controls on your Windows Form.
            InitializeComponent();

            // This line creates a SimpleDrawActionSource(), which is a class that very minimally
            // implements IUndoRedoActionSource with an action type of IDrawAction.
            // This won't support Undo or Redo, so the buttons will always be disabled, but it 
            // will allow us to use the interface (since it has been implemented), and later we can
            // replace it with a more advanced implementation.
            // _actions = new SimpleActionSource<IDrawAction>();

            // This line creates a BrokenDrawActionSource(), with the behavior
            // we saw at the beginning of class (in DrawIt 1.0).  It appears to
            // allow Undo and Redo, but if you Undo some actions and then
            // start drawing more circles, it redraws the undone actions 
            // before it starts drawing the new circles.
            //_actions = new BrokenActionSource<IDrawAction>();
            
            // Homework: Create an actual UndoRedoDrawActionSource() and make sure
            // that it has the proper Undo() and Redo() semantics.
            _actions = new UndoRedoActionSource<IDrawAction>();

            // This line says, "I want to listen to ActionsChanged events from this IActionSource.
            // Every time the ActionsChanged event happens, I want my UpdateUi() method to be called.
            //
            // Note the use of "+=" instead of "=".  That's how delegates are assigned to events.  Instead
            // of using "=", which would imply that only one delegate could listen to an event, we use "+=",
            // which basically says "Add my UpdateUi method as a listener to this event, along with any other
            // listeners who are listening to this event."  This is a good thing, because while we're listening
            // to the ActionsChanged event to update our UI, the DrawingModel will be listening to the same
            // ActionsChanged event to know when to redraw.
            //
            // Note also that I did *NOT* put parentheses after the "UpdateUi" in the line below.  Parentheses
            // indicate a method call -- that I'm actually invoking the method.  In this line, I'm NOT invoking
            // UpdateUi.  Instead, I'm talking about it.  I'm actually giving the event a reference to the method,
            // rather than calling the method.  I'm treating "UpdateUi" as if it were just another value, to be
            // assigned.  This is one of the great things about C#: a method can be treated as just another value,
            // assigned to a variable, passed around to another method as a parameter, etc.  It's a very powerful
            // and advanced language feature, which we're using here to set up our "UpdateUi" method as a listener
            // ("delegate") on the ActionsChanged event of our actions model.
            _actions.ActionsChanged += UpdateUi;

            // This adds ANOTHER event handler ("event listener") on the ActionsChanged
            // event of the _actions object.  When the _actions object fires its
            // ActionsChanged event, it will also call UpdateClearButton()
            _actions.ActionsChanged += UpdateClearButton;

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
            _canvasModel = new DrawingModel(CanvasPanel, _actions)
            {
                Background = new DrawBackgroundAction(_BACKGROUND_COLOR)
            };

            // This creates the Pen intance that draws lines on the canvas.
            _pen = new Pen(_COLOR, _LINE_WIDTH);

            // This creates the Pen instance that draws the cursor.
            _cursorPen = new Pen(_CURSOR_COLOR, _LINE_WIDTH);

            // This starts us out with a dark gray background on the canvas (so the user can see
            // where to draw).
            Clear();

            // These three lines add "event handlers" to the canvas so that we get told when the user
            // does something with the mouse.  An "event handler" is just a method that knows how to 
            // respond to an event (something that happened).  You can watch the extra session from
            // this Thursday if you want to see how to create a method like this.
            CanvasPanel.MouseDown += HandleMouseDown;
            CanvasPanel.MouseUp += HandleMouseUp;
            CanvasPanel.MouseMove += HandleMouseMoved;
            CanvasPanel.MouseLeave += HandleMouseLeave;
        }

        private void HandleMouseLeave(object sender, EventArgs e)
        {
//            Pen blankCursorPen = new Pen(_BACKGROUND_COLOR, _LINE_WIDTH);
//            _canvasModel.Cursor = new DrawCircleAction(blankCursorPen, _lastKnownX, _lastKnownY, 20);
            _canvasModel.Cursor = null;
        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            if (DrawLinesButton.Checked)
            {
                // We don't want to actually draw a line (or even a "line cursor") here -- we just want
                // to record the start point for the line, and also mark that we're "drawing".
                _startPoint = new Point(e.Location.X, e.Location.Y);
                _isDrawing = true;
            }
            else if (DrawCirclesButton.Checked)
            {
                // Since we want to actually draw a circle here, we're going to make a new DrawCircleAction and
                // add it to the list of actions.  We get the center of the circle from the mouse event "e",
                // set the radius to 20, and use our standard pen "_pen" to draw the circle.

                _actions.Add(new DrawCircleAction(_pen, e.Location.X, e.Location.Y, 20));
            }
        }

        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            if (DrawLinesButton.Checked)
            {
                // Here's where we actually draw the line.  We also hide the line cursor (by setting it to 
                // null) and turn off the "_isDrawing" flag value.
                _actions.Add(new DrawLineAction(_pen, _startPoint.X, _startPoint.Y, e.Location.X, e.Location.Y));
                _canvasModel.Cursor = null;
                _isDrawing = false;
            }
        }

        // This will draw a temporary circle as a "cursor" wherever the user moves
        // the mouse.  This cursor is the same size as the actual circle that will
        // be drawn in HandleMouseDown(), so that the user can know where they are
        // going to be drawing if they click the mouse.
        private void HandleMouseMoved(object sender, MouseEventArgs e)
        {
            // We don't want to actually draw a circle here, but instead to draw a temporary cursor.
            // So we're going to make a new DrawCircleAction just like in HandleMouseDown, but instead
            // of adding it to the list of actions, we're going to set it as the Cursor of the DrawingModel.
            // We'll let the DrawingModel take care of the details of drawing a cursor (a temporary image)
            // instead of drawing a permanent circle.
            if (DrawLinesButton.Checked)
            {
                if (_isDrawing)
                {
                    _canvasModel.Cursor = new DrawLineAction(_cursorPen, _startPoint.X, _startPoint.Y, e.Location.X,
                                                             e.Location.Y);

                }
            }
            else if (DrawCirclesButton.Checked)
            {
                _canvasModel.Cursor = new DrawCircleAction(_cursorPen, e.Location.X, e.Location.Y, 20);
            }
//            _lastKnownX = e.Location.X;
//            _lastKnownY = e.Location.Y;
        }

        private void ClearButtonClicked(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            _actions.Clear();

            // We no longer need to call _canvasModel.DrawActionsChanged() here (and everywhere else in this class
            // that we modify the list of drawing actions).  The DrawingModel is now responsible for listening
            // to ActionsChanged events from the _actions model and updating itself accordingly, so we don't
            // need to worry about doing that ourselves.
            // _canvasModel.DrawActionsChanged()

            // We no longer need to call UpdateUi() here (and everywhere else in this class that we modify
            // the list of drawing actions).  We're listening to ActionsChanged events from the _actions
            // model, and calling UpdateUi whenever the actions change, so we will automatically call
            // UpdateUi when we Clear, Undo, Redo, etc. the _actions model.
            // UpdateUi();
        }

        private void UndoButtonClicked(object sender, EventArgs e)
        {
            _actions.Undo();
        }

        private void RedoButtonClicked(object sender, EventArgs e)
        {
            _actions.Redo();
            ClearButton.Enabled = _actions.CanClear;
        }

        private void UpdateUi()
        {
            UndoButton.Enabled = _actions.CanUndo;
            RedoButton.Enabled = _actions.CanRedo;
        }

        private void UpdateClearButton()
        {
            ClearButton.Enabled = _actions.CanClear;
        }
    }
}
