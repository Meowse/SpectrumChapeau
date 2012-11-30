using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawIt
{
    public interface IUndoRedoActionSource<T> : IActionSource<T>
    {
        void Add(T action);
        void Clear();
        void Undo();
        void Redo();
        bool CanUndo { get; }
        bool CanRedo { get; }
    }
}
