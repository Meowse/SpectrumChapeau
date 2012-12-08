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

        [Test]
        public void CanNotRedoEmptyList()
        {
            Assert.That(_actionSource.CanRedo, Is.False);
        }

        [Test]
        public void CanNotRedoIfNoMoreItemsOnList()
        {
            _actionSource.Add(1);
            _actionSource.Add(3);
            Assert.That(_actionSource.CanRedo, Is.False);
        }

        [Test]
        public void CanRedoIfMoreItemsOnList()
        {
            _actionSource.Add(1);
            _actionSource.Add(3);
            _actionSource.Undo();
            Assert.That(_actionSource.CanRedo, Is.True);
        }

        [Test]
        public void CanNotClearEmptyList()
        {
            Assert.That(_actionSource.CanClear, Is.False);
        }

        [Test]
        public void CanClearIfListNotEmpty()
        {
            _actionSource.Add(1);
            Assert.That(_actionSource.CanClear, Is.True);
        }

        [Test]
        public void CanClearIfCanClearButNotClearAfterClearIncludeUndo()
        {
            _actionSource.Add(1);
            _actionSource.Add(2);
            _actionSource.Undo();
            _actionSource.Clear();
            Assert.That(_actionSource.CanClear, Is.False);
        }

        [Test]
        public void CanNotUndoTooManyTimes()
        {
            _actionSource.Add(1);
            _actionSource.Undo();
            _actionSource.Undo();
            _actionSource.Undo();
            //it's gonna bomb - not sure how to test it except to see if it makes it this far
            // it fails ok with the exception error etc. - passes after adding if statement to undo method to check for canundo
            Assert.That(_actionSource.Actions, Is.EqualTo(new int[] {}));
        }

        [Test]
        public void CanNotRedoTooManyTimes()
        {
            _actionSource.Add(1);
            _actionSource.Undo();
            _actionSource.Redo();
            _actionSource.Redo();
            _actionSource.Redo();
            Assert.That(_actionSource.Actions.Count(), Is.EqualTo(1));
        }

        [Test]
        public void DiscardRedoItemFromListAfterAddAfterUndo()
        {
            _actionSource.Add(1);
            _actionSource.Add(2);
            _actionSource.Add(3);
            _actionSource.Add(4);
            _actionSource.Add(5);
            _actionSource.Undo(); // 1,2,3,4
            _actionSource.Undo(); //1,2,3
            _actionSource.Add(6); //1,2,3,6
            _actionSource.Add(7); //1,2,3,6,7
            _actionSource.Undo(); //1,2,3,6
            _actionSource.Undo(); //1,2,3
            _actionSource.Undo(); // 1,2
            _actionSource.Redo(); // 1,2,3
            _actionSource.Redo(); // 1,2,3,6
            _actionSource.Redo(); // 1,2,3,6,7

             // should not be able to redo anymore
            Assert.That(_actionSource.CanRedo, Is.False);
            Assert.That(_actionSource.Actions, Is.EqualTo(new[] {1,2,3,6,7}));

        }

        [Test]
        public void TestToSeeIfScreenIsBeingRedrawn()
        {
            //how to test for this - it has to do with the listening event
            // you see it when you run the drawit prog

        }

    }
}
