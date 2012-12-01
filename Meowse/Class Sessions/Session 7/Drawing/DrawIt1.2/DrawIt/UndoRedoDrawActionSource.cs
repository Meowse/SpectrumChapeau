using System;
using System.Collections.Generic;

namespace DrawIt
{
    public class UndoRedoDrawActionSource : IUndoRedoActionSource<IDrawAction>
    {
        // This declares the ActionsChanged event.  Remember to call ActionsChanged() whenever
        // the publicly-visible list of Actions changes, so that your delegates can respond
        // appropriately to the list of Actions changing.
        public event ActionsChangedEventHandler ActionsChanged;

        public IEnumerable<IDrawAction> Actions {
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

        public void Add(IDrawAction action)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
