using System.Collections.Generic;
using System.Linq;

namespace DrawIt
{
    class BrokenDrawActionSource : IUndoRedoActionSource<IDrawAction>
    {
        // This line says, "SimpleDrawSourceAction objects are a source of ActionsChanged events,
        // and if you want to handle them, you should listen for them here, and you will need to be
        // an ActionsChangedEventHandler in order to do this."  Anybody who cares about ActionsChanged
        // events from a particular instance of SimpleDrawSourceAction will need to listen for them 
        // by having a method with the same signature as the ActionsChangedEventHandler delegate,
        // and by assigning that method (with "+=") to this ActionsChanged event.
        public event ActionsChangedEventHandler ActionsChanged;

        private readonly List<IDrawAction> _drawActions = new List<IDrawAction>(); 
        private int _numberOfActionsToDraw;

        public IEnumerable<IDrawAction> Actions {
            get { return _drawActions.Take(_numberOfActionsToDraw); }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                _numberOfActionsToDraw--;

                // This line causes an ActionsChanged event to be seen by all of the delegates
                // that are listening to the event.  Basically, it calls the method on each delegate
                // that has been registered (by being added with "+=") as a listener on the 
                // ActionsChanged event.
                ActionsChanged();
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                _numberOfActionsToDraw++;

                // This line also causes an ActionsChanged event to be seen by all of the delegates.
                // Notice that we have to call ActionsChanged even though we didn't modify the actual list
                // of actions (just how many of them should be drawn).  From the perspective of our
                // "consumers" (the objects that are using us as a resource), our effective list of actions
                // changes whenever _numberOfActionsToDraw changes, as well as when our actual _drawActions
                // list changes.  So we need to notify them that our actions have changed in either case.
                ActionsChanged();
            }
        }

        public bool CanUndo { get { return _numberOfActionsToDraw > 0; } }
        public bool CanRedo { get { return _numberOfActionsToDraw < _drawActions.Count; } }

        public void Add(IDrawAction drawAction)
        {
            _drawActions.Add(drawAction);
            _numberOfActionsToDraw++;

            // Notifying our listeners (our delegates) about the change in our actions.
            ActionsChanged();
        }

        public virtual void Clear()
        {
            _drawActions.Clear();
            _numberOfActionsToDraw = 0;

            // Notifying our listeners (our delegates) about the change in our actions.
            ActionsChanged();
        }
    }
}
