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
            get {return _actions;}
        }

        public void Undo()
        {
            int lastActionIndex = _actions.Count - 1;
            TAction lastAction = _actions[lastActionIndex];
            _actions.RemoveAt(lastActionIndex);
            _redoActions.Add(lastAction);
            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public void Redo()
        {
            int lastActionIndex = _redoActions.Count - 1;
            TAction lastAction = _redoActions[lastActionIndex];
            _redoActions.RemoveAt(lastActionIndex);
            _actions.Add(lastAction);
            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public bool CanUndo
        {
            get {return _actions.Count > 0;}
        }

        public bool CanRedo
        {
            get {return _redoActions.Count > 0;}
        }

        public bool CanClear
        {
            get { return _actions.Count > 0; }
        }

        public void Add(TAction action)
        {
            if (_redoActions.Count>0){_redoActions.Clear();}
            _actions.Add(action);
            if (ActionsChanged != null) { ActionsChanged();}
        }

        public void Clear()
        {
            _actions.Clear();
            if (ActionsChanged != null) { ActionsChanged(); }
        }
    }
}
