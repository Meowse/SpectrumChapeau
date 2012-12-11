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
        private List<T> _active = new List<T>();
        private List<T> _passive = new List<T>();

        public IEnumerable<T> Actions
        {
            get
            {
                return _active;
            }
        }

        public void Undo()
        {
            int lastActionIndex = _active.Count - 1;
            T lastAction = _active[lastActionIndex];
            _active.RemoveAt(lastActionIndex);
            _passive.Add(lastAction);
        }

        public void Redo()
        {
            int lastActionIndex = _passive.Count - 1;
            T lastAction = _passive[lastActionIndex];
            _passive.RemoveAt(lastActionIndex);
            _active.Add(lastAction);
        }

        public bool CanUndo
        {
            get { return false; }
        }

        public bool CanRedo
        {
            get { return false; }
        }

        public void Add(T action)
        {
            this._active.Add(action);
            
            if (ActionsChanged != null)
            {
                ActionsChanged();
            }
        }
         

        public void Clear()
        {
            this._active.Clear();
            if (ActionsChanged != null)
            {
                ActionsChanged();
            }

        }
    }
}
