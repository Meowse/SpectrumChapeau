using System.Collections.Generic;
using System.Linq;

namespace ActionSources
{
    public class BrokenActionSource<T> : IUndoRedoActionSource<T>
    {
        // This line says, "SimpleDrawSourceAction objects are a source of ActionsChanged events,
        // and if you want to handle them, you should listen for them here, and you will need to be
        // an ActionsChangedEventHandler in order to do this."  Anybody who cares about ActionsChanged
        // events from a particular instance of SimpleDrawSourceAction will need to listen for them 
        // by having a method with the same signature as the ActionsChangedEventHandler delegate,
        // and by assigning that method (with "+=") to this ActionsChanged event.
        public event ActionsChangedEventHandler ActionsChanged;

        private readonly List<T> _actions = new List<T>(); 
        private int _numberOfActionsToTake;

        public List<T> Actions
        {
            get { return _actions.Take(_numberOfActionsToTake).ToList(); }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                _numberOfActionsToTake--;

                // This line causes an ActionsChanged event to be seen by all of the delegates
                // that are listening to the event.  Basically, it calls the method on each delegate
                // that has been registered (by being added with "+=") as a listener on the 
                // ActionsChanged event.
                if (ActionsChanged != null) { ActionsChanged(); }
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                _numberOfActionsToTake++;

                // This line also causes an ActionsChanged event to be seen by all of the delegates.
                // Notice that we have to call ActionsChanged even though we didn't modify the actual list
                // of actions (just how many of them should be drawn).  From the perspective of our
                // "consumers" (the objects that are using us as a resource), our effective list of actions
                // changes whenever _numberOfActionsToTake changes, as well as when our actual _actions
                // list changes.  So we need to notify them that our actions have changed in either case.
                if (ActionsChanged != null) { ActionsChanged(); }
            }
        }

        public bool CanUndo { get { return _numberOfActionsToTake > 0; } }
        public bool CanRedo { get { return _numberOfActionsToTake < _actions.Count; } }
        public bool CanClear { get { return _actions.Count > 0; } }

        public void Add(T action)
        {
            _actions.Add(action);
            _numberOfActionsToTake++;

            // Notifying our listeners (our delegates) about the change in our actions.
            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public virtual void Clear()
        {
            if (CanClear)
            {
                _actions.Clear();
                _numberOfActionsToTake = 0;

                // Notifying our listeners (our delegates) about the change in our actions.
                if (ActionsChanged != null)
                {
                    ActionsChanged();
                }
            }
        }
    }
}
