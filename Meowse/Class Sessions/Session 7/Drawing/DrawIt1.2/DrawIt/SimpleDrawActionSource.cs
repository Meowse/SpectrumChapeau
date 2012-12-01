using System;
using System.Collections.Generic;

namespace DrawIt
{
    class SimpleDrawActionSource : IUndoRedoActionSource<IDrawAction>
    {
        // This line says, "I have an event named ActionsChanged, and delegates that want
        // to listen to that event need to define a method with the ActionsChangedEventHandler
        // signature."  This is required by the IActionSource interface, and in fact I created
        // this line by using Alt-Enter when C# complained that I wasn't implementing all of the
        // members of the interface.
        public event ActionsChangedEventHandler ActionsChanged;

        private readonly List<IDrawAction> _drawActions = new List<IDrawAction>();

        public IEnumerable<IDrawAction> Actions {
            get
            {
                return new List<IDrawAction>(_drawActions);
            }
        }

        public void Undo()
        {
            throw new NotImplementedException("SimpleDrawActionSource does not support Undo()");
        }

        public void Redo()
        {
            throw new NotImplementedException("SimpleDrawActionSource does not support Redo()");
        }

        public bool CanUndo { get { return false; } }
        public bool CanRedo { get { return false; } }

        public void Add(IDrawAction drawAction)
        {
            _drawActions.Add(drawAction);

            // This line causes an ActionsChanged event to be seen by all of the delegates
            // that are listening to the event.  Basically, it calls the method on each delegate
            // that has been registered (by being added with "+=") as a listener on the 
            // ActionsChanged event.
            ActionsChanged();
        }

        public virtual void Clear()
        {
            _drawActions.Clear();

            // This line also causes an ActionsChanged event to be seen by all of the delegates.
            // We have to call ActionsChanged every time we change our _drawActions list, so that
            // anyone who cares about these events can react to the change in our actions.
            ActionsChanged();
        }
    }
}
