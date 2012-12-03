using System.Drawing;

namespace DrawIt
{
    // An "interface" is kind of like a promise that an object can make about what it will do.
    //
    // An interface is not a class (clas
    //
    // If an object says, "Yes, I am an IPaintbrushEventHandler", then it is promising to provide
    // methods "DrawSomethingAt(Point location)" and "DrawSomethingFrom(Point start, Point end)" and
    // so on.
    //
    // An "inteface" is a way for different objects to "agree ahead of time" on how they will collaborate,
    // without worrying about how they will do it (how they will "implement the interface").
    //
    // In this case, IPaintbrushEventHandler is the agreement that any object must agree to if it wants to be
    // told about Paintbrush events by a PaintbrushControlModel.
    public interface IPaintbrushEventHandler
    {
        void DrawSomethingAt(Point location, bool isCursor = false);

        // As soon as I declare this method, every class that has agreed to be an IPaintbrushEventHandler 
        // will have to define that method as well.
        void DrawSomethingFrom(Point start, Point end, bool isCursor = false);
    }
}