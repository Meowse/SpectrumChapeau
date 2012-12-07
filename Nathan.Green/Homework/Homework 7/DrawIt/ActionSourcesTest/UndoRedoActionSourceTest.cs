using System.Collections.Generic;
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

        // I've added a couple more sample test here, to show you some ways to work with the
        // Actions enumeration.

        [Test]
        public void CanAddOneItemToList()
        {
            _actionSource.Add(3);

            // The "ToList()" call here converts Actions, which is an IEnumerable<int>,
            // into a List<int>, which has a Count method, and which allows you to get 
            // specific elements via [0], [1], etc.  It's just a little easier to work with.
            List<int> actualList = _actionSource.Actions.ToList();

            // This line verifies that we have exactly 1 element in the list of actions.
            Assert.That(actualList.Count, Is.EqualTo(1));

            // This line verifies that the first element in the list (the element at index 0)
            // is "3", the expected value.
            Assert.That(actualList[0], Is.EqualTo(3));
        }

        [Test]
        public void CanAddMultipleItemsToList()
        {
            _actionSource.Add(3);
            _actionSource.Add(4);

            // Here, instead of using the "ToList()" call and then verifying the attributes
            // of the resulting List, we're using the "EquivalentTo" test helper.  The
            // "EquivalentTo" test helper allows you to check whether two collections have
            // the same elements in them.  I recommend using this syntax, rather than the
            // "ToList()" syntax above, because it's a lot simpler.  It is more clear and
            // direct in expressing your expectation about the results -- and tests are all
            // about clearly and directly expressing expectations for the results of the code.
            Assert.That(_actionSource.Actions, Is.EquivalentTo(new[] { 3, 4 }));
        }

        // This test asserts that a list where Undo has not been pressed, Redo cannot be done 
        [Test]
        public void CannotRedoOnAListWhenNeverPressedUndo()
        {
            _actionSource.Add(3);

            //This line verifies that Redo cannot be done since Undo has not been pressed
            Assert.That(_actionSource.CanRedo == false);
        }

        // This test asserts that a one item list that has been undone has a list size of 0
        [Test]
        public void UndoAOneItemListResultsinaZeroLengthList()
        {
            _actionSource.Add(3);
            _actionSource.Undo();

            // The "ToList()" call here converts Actions, which is an IEnumerable<int>,
            // into a List<int>, which has a Count method, and which allows you to get 
            // specific elements via [0], [1], etc.  It's just a little easier to work with.
            List<int> actualList = _actionSource.Actions.ToList();

            // This line verifies that we have exactly 0 elements in the list of actions.
            Assert.That(actualList.Count, Is.EqualTo(0));
        }

        // This is a complicated test
        [Test]
        public void ConfirmThatMultipleAddsUndosRedosAddsAgainWorkTest()
        {
            _actionSource.Add(1);
            _actionSource.Add(2);
            _actionSource.Add(3);

            // List now contains 3 elements: 1, 2, 3.

            // This line verifies that we have exactly 3 elements in the list of actions and they are: 1, 2, 3.
            Assert.That(_actionSource.Actions.Count(), Is.EqualTo(3));
            Assert.That(_actionSource.Actions, Is.EquivalentTo(new[] { 1, 2, 3 }));

            // Attempt an Undo
            _actionSource.Undo();

            // List now contains 2 elements: 1, 2.

            // This line verifies that we have exactly 2 elements in the list of actions and they are:  1, 2.
            Assert.That(_actionSource.Actions.Count(), Is.EqualTo(2));
            Assert.That(_actionSource.Actions, Is.EquivalentTo(new[] { 1, 2 }));

            // Add a new member
            _actionSource.Add(4);

            // List now contains 3 elements: 1, 2, 4.

            // This line verifies that we have exactly 3 elements in the list of actions and they are:  1, 2, 4.
            Assert.That(_actionSource.Actions.Count(), Is.EqualTo(3));
            Assert.That(_actionSource.Actions, Is.EquivalentTo(new[] { 1, 2, 4 }));

            // Undo twice, then add 2 new members
            _actionSource.Undo();
            _actionSource.Undo();
            _actionSource.Add(5);
            _actionSource.Add(6);

            // List now contains 3 elements: 1, 5, 6.

            // This line verifies that we have exactly 3 elements in the list of actions and they are:  1, 5, 6.
            Assert.That(_actionSource.Actions.Count(), Is.EqualTo(3));
            Assert.That(_actionSource.Actions, Is.EquivalentTo(new[] { 1, 5, 6 }));
        }

        // And one more sample test, to show you how to verify that you are sending ActionsChanged
        // events at the right times.

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
