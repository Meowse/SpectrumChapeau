using System;
using System.Collections.Generic;

namespace ActionSources
{
    public class UndoRedoActionSource<T> : IUndoRedoActionSource<T>
    {
        // This declares the ActionsChanged event.  Remember to call ActionsChanged() whenever
        // the publicly-visible list of Actions changes, so that your delegates can respond
        // appropriately to the list of Actions changing.
        public event ActionsChangedEventHandler ActionsChanged;
        private readonly List<T> _actions = new List<T>();
        public List<T> Actions {
            get
            {
                //throw new NotImplementedException();
                return _actions;
            }
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        public void Redo()
        {
            throw new NotImplementedException();
        }

        public bool CanUndo
        {
            get
            {
                //throw new NotImplementedException();
                return false;
            }
        }
        public bool CanRedo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T action)
        {
            //throw new NotImplementedException();
            _actions.Add(action);
            //ActionsChanged();
            if (ActionsChanged != null)
            {
                ActionsChanged();
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
