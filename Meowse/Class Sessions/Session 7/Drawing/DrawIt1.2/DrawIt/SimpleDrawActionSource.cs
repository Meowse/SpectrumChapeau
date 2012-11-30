using System;
using System.Collections.Generic;

namespace DrawIt
{
    class SimpleDrawActionSource : IUndoRedoActionSource<DrawAction>
    {
        private readonly List<DrawAction> _drawActions = new List<DrawAction>();

        public IEnumerable<DrawAction> Actions {
            get
            {
                return new List<DrawAction>(_drawActions);
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

        public void Add(DrawAction drawAction)
        {
            _drawActions.Add(drawAction);
        }

        public virtual void Clear()
        {
            _drawActions.Clear();
        }
    }
}
