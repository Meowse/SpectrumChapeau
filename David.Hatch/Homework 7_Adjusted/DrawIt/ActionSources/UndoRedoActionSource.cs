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

        //dsh
        //set true when undo used - when add called clear redoActions list and set to false
        private bool UndoCalled;



        public List<TAction> Actions
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
                TAction lastAction = _actions[lastActionIndex];
                _actions.RemoveAt(lastActionIndex);
                _redoActions.Add(lastAction);
                UndoCalled=true;
                if (ActionsChanged != null)
                {
                    ActionsChanged();
                }
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                int lastActionIndex = _redoActions.Count - 1;
                TAction lastAction = _redoActions[lastActionIndex];
                _redoActions.RemoveAt(lastActionIndex);
                _actions.Add(lastAction);
                if (ActionsChanged != null)
                {
                    ActionsChanged();
                }
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

        public bool CanClear
        {
            get 
            { 
                return _actions.Count > 0 || _redoActions.Count > 0; 
            }
        }

        public void Add(TAction action)
        {
            if (UndoCalled)
            {
                _redoActions.Clear();
                UndoCalled = false;
            }
            _actions.Add(action);

            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public void Clear()
        {
            if (CanClear)
            {
                _actions.Clear();
                _redoActions.Clear();
                if (ActionsChanged != null)
                {
                    ActionsChanged();
                }
            }
        }


    }
}
