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
        private readonly List<T> _undoRedoStack = new List<T>(); 

        public IEnumerable<T> Actions {
            get
            {
                return new List<T>(_actions);
            }
        }

        public IEnumerable<T> UndoRedoStack {
            get 
            { 
                return new List<T>(_undoRedoStack);
            }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                T undoneAction = _actions[_actions.Count - 1];
                _actions.RemoveAt(_actions.Count - 1);
                _undoRedoStack.Add(undoneAction);
                if (ActionsChanged != null) { ActionsChanged(); }
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                _actions.Add(_undoRedoStack[_undoRedoStack.Count - 1]);
                _undoRedoStack.RemoveAt(_undoRedoStack.Count - 1);
                if (ActionsChanged != null) { ActionsChanged(); }
            }
        }

        public bool CanUndo
        {
            get { return _actions.Count > 0; }
        }
        public bool CanRedo
        {
            get { return _undoRedoStack.Count > 0; }
        }

        public void Add(T action)
        {
            _actions.Add(action);
            _undoRedoStack.Clear();
            if (ActionsChanged != null) { ActionsChanged(); }
        }

        public void Clear()
        {
            _actions.Clear();
            _undoRedoStack.Clear();
            if (ActionsChanged != null) { ActionsChanged(); }
        }
    }
}
