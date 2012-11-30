using System.Collections.Generic;

namespace DrawIt
{
    public interface IActionSource<T>
    {
        IEnumerable<T> Actions { get; } 
    }
}
