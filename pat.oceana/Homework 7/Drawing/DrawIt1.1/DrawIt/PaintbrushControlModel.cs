using System.Drawing;
using System.Windows.Forms;

namespace DrawIt
{
    // A PaintbrushControlModel listens to "mouse events" from a Control (something on the screen that the user can click on),
    // and translates them into "paintbrush actions" on an IPaintbrushEventHandler (a class that knows how to take paintbrush
    // actions such as drawing something at a location).
    //
    // "mouse events" are things that happen every time the mouse is moved, clicked, released, dragged, etc.  They're very low-level
    // and annoying to work with.
    //
    // When something is low-level and annoying to work with, we like to "encapsulate" it into a "higher-level abstraction".
    // In this case, the "low-level detail" is "mouse events", and the "higher-level abstraction" is "paintbrush actions that
    // will be implemented by an IPaintbrushEventHandler".
    //
    // This class performs that encapsulation by taking a Control and an IPaintbrushEventHandler, listening to the Control
    // for mouse events, and calling IPaintbrushEventHandler methods on the IPaintbrushEventHandler in response to them.
    public class PaintbrushControlModel
    {
        private readonly Control _control;
        private readonly IPaintbrushEventHandler _handler;

        // Method with the same name as the class is a "constructor".
        //
        // This method makes a new PaintbrushControlModel.  Every time you make a new PaintbrushControlModel,
        // you have to provide it with a Control (something on the screen that a user can click on) and 
        // an IPaintbrushEventHandler (something that defines the methods in the IPaintbrushEventHandler interface).
        public PaintbrushControlModel(Control control, IPaintbrushEventHandler handler)
        {
            _control = control;
            _handler = handler;

            // MouseUp, MouseDown, and MouseMove are a special kind of variable called a "delegate".
            // A "delegate" is a place to which you can attach an event handler.
            //
            // The method "HandleMouseUp" is an event handler (it's a method that handles an event).
            // When I say "_control.MouseUp += HandleMouseUp", I'm saying, "Add my HandleMouseUp method
            // to the list of event handlers to which you send a MouseUp event."
            // 
            // This is so that lots of different event handlers can listen to a single event, without
            // "getting in each other's way".  I could add an event handler to the control's MouseUp
            // delegate, and someone else could add an event handler to the control's MouseUp delegate,
            // and both of those event handlers would get called when the mouse button was released.
            _control.MouseUp += HandleMouseUp;
            
            // HandleMouseUp is an event handler -- a method that knows how to handle MouseUp events.
            //
            // This is another way of making a "method that knows how to handle MouseUp events".  It is
            // called an "anonymous function" or "a lambda" (for historical reasons).
            // It says, "Make an anonymous function that takes an object called 'sender' and some MouseEventArgs
            // called 'e', and show a message with MessageBox.Show().
            // _control.MouseUp += (sender, e) => MessageBox.Show("second event handler" + e.Location);

            // This is another event handler (also a lambda).  It's only different in that it calls 
            // the second parameter "args" instead of "e", and says "third event handler" instead of "second event handler"
            // _control.MouseUp += (sender, args) => MessageBox.Show("third event handler" + args.Location);

            // "I want to listen to the MouseDown event of this control with my HandleMouseDown event handler method."
            _control.MouseDown += HandleMouseDown;

            // "I want to listen to the MouseMove event of this control with my HandleMouseMove event handler method."
            _control.MouseMove += HandleMouseMove;
        }

        // Every variable has a "scope" -- the places it is defined, or exists.
        //
        // A local variable -- a variable declared inside a method -- is "in scope" from the line where
        // it is declared to the end of that same method.
        //
        // An instance variable -- a variable declared inside a class -- is "in scope" anywhere in that class.
        // All methods in the class can see that variable, and all of the methods in that class share the same
        // bucket in memory by that name.
        //
        // Any time you want to use the same bucket in multiple methods -- for example, to set it in one method and
        // then later use it in another method -- you will need to use an instance variable.

        private void HandleMouseUp(object sender, MouseEventArgs e)
        {
            // We only want to do one of these two things.  If the user just clicked and released the mouse in one place,
            // then we should just do a "DrawSomethingAt()".  If the user clicked at one place, dragged the mouse
            // somewhere else, and then released it, then we should do a "DrawSomethingFrom()".  How can we tell these two
            // cases apart?
            //
            // Uncomment this line and look at the "mouse down" and "mouse up" locations for "clicks" (mouse down and up
            // in one place) vs. "drags" (mouse down in one place, drag the mouse, mouse up somewhere else).
            //
            // For "clicks", the start and end locations will be the same.
            // For "drags", the start and end locations will be different.
            //
            // So we can tell whether we're in the "DrawSomethingAt()" case ("click") or the "DrawSomethingFrom()" case ("drag")
            // by comparing the start and end locations.
            // MessageBox.Show(string.Format("mouse down at {0}, mouse up at {1}", _lineStart, e.Location));

            // We want to do one of two things (draw something at a single location, or draw something from one location to another).
            // How do we "do one of two things" in our program code?
            // Logically, we want to say "If the start location and the end location are different, DrawSomethingFrom().  Otherwise, DrawSomethingAt()."
            if (IsDragging(e))
            {
                // "End a line" by calling DrawSomethingFrom from where the mouse was clicked down to where the mouse was released.
                // 
                // Notice that we are using the instance variable _lineStart here.  We are saying, "Whatever value some other method
                // might have left in the '_lineStart' bucket, use that as the starting point of the line."
                //
                // We're also using the Location property of the mouse event, 'e', here.  We're saying, "The end of the line should be
                // whatever location the mouse is at when the mouse is released -- the Location of the current event."
                _handler.DrawSomethingFrom(_lineStart, e.Location);
            }
            else
            {
                _handler.DrawSomethingAt(e.Location);
            }

            // Whenever we finish dragging the mouse and draw something, we re-set _lineStart to the
            // _NOT_DRAGGING marker value so that we know we're not dragging.
            _lineStart = _NOT_DRAGGING;
        }

        // We can use this "marker value", a Point at location (-1, -1), to indicate that
        // the user is not in the middle of dragging the mouse to draw a line, circle, rectangle, etc.
        //
        // We need to start off _lineStart with the _NOT_DRAGGING marker value (since, when we
        // first start up the application, we're not dragging the mouse), and we need to
        // set _lineStart to _NOT_DRAGGING whenever the mouse goes up and we finish drawing something.
        private static readonly Point _NOT_DRAGGING = new Point(-1, -1);

        // This is a "private" instance variable -- it can only be seen from inside this class, PaintbrushControlModel.
        // But it can be seen *anywhere* inside this class -- before it is declared, after it is declared -- anywhere.
        private Point _lineStart = _NOT_DRAGGING;

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            // "Start a line" by remembering where the mouse was clicked down

            // "Point" says "I am declaring a variable of type 'Point' -- a bucket in the computer's memory where I can put things.
            // The only things I can put into this bucket in memory are 'Point' objects.
            // Anything I get out of this bucket in memory will be treated like a 'Point' object.
            //
            // "lineStart" says, "I am naming this bucket in memory 'lineStart'.  Anywhere I say 'lineStart', I am talking
            // about this particular bucket in memory."
            //
            // "= e.Location" says, "Take whatever value is in the 'Location' property of the object in 'e', and copy it into
            // the 'lineStart' bucket that I just declared."
            // 
            // However, this won't work, because the "scope" of lineStart -- the locations where it exists -- is just this one method.
            // A local variable (a variable declared inside a method) only exists -- is only "in scope" -- until the end of that 
            // same method.
            // Point lineStart = e.Location;

            _lineStart = e.Location;
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging(e))
            {
                _handler.DrawSomethingFrom(_lineStart, e.Location, true);
            }
        }

        // If we're "dragging", we'll have a _lineStart value that is not the
        // _NOT_DRAGGING marker value, and the _lineStart value will be different 
        // from the current location.
        private bool IsDragging(MouseEventArgs e)
        {
            return (_lineStart != _NOT_DRAGGING) && !_lineStart.Equals(e.Location);
        }
    }
}
