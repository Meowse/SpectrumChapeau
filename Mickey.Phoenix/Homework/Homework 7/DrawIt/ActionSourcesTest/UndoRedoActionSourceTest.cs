using System.Collections.Generic;
using System.Data;
using System.Linq;
using ActionSources;
using NUnit.Framework;

namespace ActionSourcesTest
{
    [TestFixture]
    public class UndoRedoActionSourceTest
    {
        private UndoRedoActionSource<int> _actionSource;

        [SetUp]
        public void SetUp()
        {
             _actionSource = new UndoRedoActionSource<int>();
        }

        [Test]
        public void CannotUndoEmptyList()
        {
            Assert.That(_actionSource.CanUndo, Is.False);
        }

        [Test]
        public void CanAddOneItemToList()
        {
            _actionSource.Add(3);
            Assert.That(_actionSource.Actions, Is.EqualTo(new[] { 3 }));
        }

        [Test]
        public void CanUndoAfterAdding()
        {
            _actionSource.Add(3);
            Assert.That(_actionSource.CanUndo, Is.True);
        }

        [Test]
        public void UndoWorksAfterAdding()
        {
            _actionSource.Add(3);
            _actionSource.Undo();

            // These two lines are equivalent, in this case, because the "Is.EqualTo()"
            // is only looking at the contents of the collections, not the type of the
            // collections.
            Assert.That(_actionSource.Actions, Is.EqualTo(new List<int>()));
            Assert.That(_actionSource.Actions, Is.EqualTo(new int[] { }));
        }

        [Test]
        public void RedoAfterUndoRestoresList()
        {
            _actionSource.Add(3);
            _actionSource.Undo();
            _actionSource.Redo();

            Assert.That(_actionSource.Actions, Is.EqualTo(new[] { 3 }));
        }

        [Test]
        public void CanAddMultipleItemsToList()
        {
            _actionSource.Add(3);
            _actionSource.Add(4);
            Assert.That(_actionSource.Actions, Is.EqualTo(new[] { 3, 4 }));
        }

        [Test]
        public void SendsActionsChangedEventWhenActionIsAdded()
        {
            CountingActionsChangedEventHandler eventsHandledCounter = new CountingActionsChangedEventHandler();
            _actionSource.ActionsChanged += eventsHandledCounter.HandleActionsChanged;


            Assert.That(eventsHandledCounter.EventsHandled, Is.EqualTo(0));
            _actionSource.Add(3);
            Assert.That(eventsHandledCounter.EventsHandled, Is.EqualTo(1));
            _actionSource.Add(4);
            Assert.That(eventsHandledCounter.EventsHandled, Is.EqualTo(2));
        }

        public class CountingActionsChangedEventHandler
        {
            public int EventsHandled;

            public void HandleActionsChanged()
            {
                EventsHandled++;
            }
        }
    }
}
