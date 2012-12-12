using System;
using System.Collections.Generic;

namespace ActionSources
{
    public class SimpleActionSource<T> : IUndoRedoActionSource<T>
    {
        // This line says, "I have an event named ActionsChanged, and delegates that want
        // to listen to that event need to define a method with the ActionsChangedEventHandler
        // signature."  This is required by the IActionSource interface, and in fact I created
        // this line by using Alt-Enter when C# complained that I wasn't implementing all of the
        // members of the interface.
        public event ActionsChangedEventHandler ActionsChanged;

        private readonly List<T> _actions = new List<T>();

        public IEnumerable<T> Actions {
            get
            {
                return new List<T>(_actions);
            }
        }

        public void Undo()
        {
            throw new NotImplementedException("SimpleActionSource does not support Undo()");
        }

        public void Redo()
        {
            throw new NotImplementedException("SimpleActionSource does not support Redo()");
        }

        public bool CanUndo { get { return false; } }
        public bool CanRedo { get { return false; } }

        public void Add(T action)
        {
            _actions.Add(action);

            // This line causes an ActionsChanged event to be seen by all of the delegates
            // that are listening to the event.  Basically, it calls the method on each delegate
            // that has been registered (by being added with "+=") as a listener on the 
            // ActionsChanged event.
            //
            // Note that we have to check if ActionsChanged is null before we can call it.  If nobody
            // is listening, we don't want to tell nobody that our actions have changed!
            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public virtual void Clear()
        {
            _actions.Clear();

            // This line also causes an ActionsChanged event to be seen by all of the delegates.
            // We have to call ActionsChanged every time we change our _actions list, so that
            // anyone who cares about these events can react to the change in our actions.
            if (ActionsChanged != null) { ActionsChanged(); }
        }
    }
}
