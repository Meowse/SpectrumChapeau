namespace ActionSources
{
    public interface IUndoRedoActionSource<T> : IActionSource<T>
    {
        void Add(T action);
        void Clear();
        void Undo();
        void Redo();
        bool CanUndo { get; }
        bool CanRedo { get; }
        bool CanClear { get; }
    }
}
