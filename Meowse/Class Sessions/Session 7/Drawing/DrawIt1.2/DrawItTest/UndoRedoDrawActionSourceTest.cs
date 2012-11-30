using DrawIt;
using NUnit.Framework;

namespace DrawItTest
{
    [TestFixture]
    public class UndoRedoDrawActionSourceTest
    {
        private UndoRedoDrawActionSource _actionSource;

        [SetUp]
        public void SetUp()
        {
             _actionSource = new UndoRedoDrawActionSource();
        }

        [Test]
        public void CannotUndoEmptyList()
        {
            Assert.That(_actionSource.CanUndo, Is.False);
        }
    }
}
