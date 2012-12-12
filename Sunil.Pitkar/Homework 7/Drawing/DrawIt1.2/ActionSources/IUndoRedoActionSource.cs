namespace ActionSources
{
    public interface IUndoRedoActionSource<T> : IActionSource<T>
    {
        
        void Undo();
        void Redo();
        bool CanUndo { get; }
        bool CanRedo { get; }
    }
}
