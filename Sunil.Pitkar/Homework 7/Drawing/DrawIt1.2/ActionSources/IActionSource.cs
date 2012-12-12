using System.Collections.Generic;

namespace ActionSources
{
    // Ths line says, "There are things in the world called ActionsChangedEventHandlers, and 
    // I can delegate to them the responsibility to handle ActionsChangedEvents."  It's just like
    // a method signature declaration, "public void ActionsChangedEventHandler", except that
    // it also has the word "delegate" in it.  And it defines the signature of any method 
    // that wants to act as an ActionsChangedEventHandler.  If someone else wants to handle
    // ActionsChangedEventHandler events, they'll need to define a method with the signature
    // "public void SomeMethodName()", to match this delegate declaration.
    //
    // Side note: C# does not allow delegate declarations in interfaces, since delegate declarations
    // are technically type declarations.  Thus, we have to move this line declaring the delegate
    // outside of the interface.  Just a language quirk.
    public delegate void ActionsChangedEventHandler();

    public interface IActionSource<T>
    {
        IEnumerable<T> Actions { get; }
        void Add(T action);
        void Clear();
        //bool CanClear { get; }
    
        // This line says, "IActionSource implementers are a source of ActionsChanged events,
        // and if you want to handle them, you should listen for them here, and you will need to be
        // an ActionsChangedEventHandler in order to do this."  Anybody who cares about ActionsChanged
        // events from a particular instance of of a particular class implementing IActionSource will 
        // need to listen for those events by:
        //  1) Declaring a method with the same signature as the ActionsChangedEventHandler delegate above, and
        //  2) Assigning that method (with "+=") to the ActionsChanged event of that instance.
        event ActionsChangedEventHandler ActionsChanged;
    }
}
