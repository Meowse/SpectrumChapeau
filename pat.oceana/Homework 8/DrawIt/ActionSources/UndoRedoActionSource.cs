using System;
using System.Collections.Generic;

namespace ActionSources
{
    public class UndoRedoActionSource<TAction> : IUndoRedoActionSource<TAction>
    {
        // This declares the ActionsChanged event.  Remember to call ActionsChanged() whenever
        // the publicly-visible list of Actions changes, so that your delegates can respond
        // appropriately to the list of Actions changing.
        public event ActionsChangedEventHandler ActionsChanged;

        private readonly List<TAction> _actions = new List<TAction>();
        private readonly List<TAction> _redoActions = new List<TAction>(); 

        public List<TAction> Actions
        {
            get
            {
                return _actions;
            }
        }

        public void Undo()
        {
            int lastActionIndex = _actions.Count - 1;
            TAction lastAction = _actions[lastActionIndex];
            _actions.RemoveAt(lastActionIndex);
            _redoActions.Add(lastAction);
        }

        public void Redo()
        {
            int lastActionIndex = _redoActions.Count - 1;
            TAction lastAction = _redoActions[lastActionIndex];
            _redoActions.RemoveAt(lastActionIndex);
            _actions.Add(lastAction);
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
                throw new NotImplementedException();
            }
        }

        public bool CanClear
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(TAction action)
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
