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
        private readonly List<T> _redoActions = new List<T>();

        public IEnumerable<T> Actions 
        {
            get
            {
                return _actions;
            }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                int lastActionIndex = _actions.Count - 1;
                T lastAction = _actions[lastActionIndex];
                _actions.RemoveAt(lastActionIndex);
                _redoActions.Add(lastAction);
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                int lastActionIndex = _redoActions.Count - 1;
                T lastAction = _redoActions[lastActionIndex];
                _redoActions.RemoveAt(lastActionIndex);
                _actions.Add(lastAction);
            }
        }

        public bool CanUndo
        {
            get 
            {
                return _actions.Count > 0;
            }
        }

        public bool CanRedo
        {
            get 
            { 
                return _redoActions.Count > 0; 
            }
        }

        public void Add(T action)
        {
            _actions.Add(action);
            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
