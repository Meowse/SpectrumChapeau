using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawIt
{
    class BrokenDrawActionSource : IUndoRedoActionSource<DrawAction>
    {
        private readonly List<DrawAction> _drawActions = new List<DrawAction>(); 
        private int _numberOfActionsToDraw;

        public IEnumerable<DrawAction> Actions {
            get { return _drawActions.Take(_numberOfActionsToDraw); }
        }

        public void Undo()
        {
            if (CanUndo)
            {
                _numberOfActionsToDraw--;
            }
        }

        public void Redo()
        {
            if (CanRedo)
            {
                _numberOfActionsToDraw++;
            }
        }

        public bool CanUndo { get { return _numberOfActionsToDraw > 0; } }
        public bool CanRedo { get { return _numberOfActionsToDraw < _drawActions.Count; } }

        public void Add(DrawAction drawAction)
        {
            _drawActions.Add(drawAction);
            _numberOfActionsToDraw++;
        }

        public virtual void Clear()
        {
            _drawActions.Clear();
            _numberOfActionsToDraw = 0;
        }
    }
}
