using System;
using System.Collections.Generic;

namespace DrawIt
{
    public class UndoRedoDrawActionSource : IUndoRedoActionSource<DrawAction>
    {
        public IEnumerable<DrawAction> Actions {
            get
            {
                throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }
        public bool CanRedo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(DrawAction action)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
