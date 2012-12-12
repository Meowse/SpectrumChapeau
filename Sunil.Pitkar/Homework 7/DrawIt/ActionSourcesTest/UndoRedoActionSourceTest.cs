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

        // I've added a couple more sample test here, to show you some ways to work with the
        // Actions enumeration.

        [Test]
        public void CanAddOneItemToList()
        {
            _actionSource.Add(3);

            // The "ToList()" call here converts Actions, which is an IEnumerable<int>,
            // into a List<int>, which has a Count method, and which allows you to get 
            // specific elements via [0], [1], etc.  It's just a little easier to work with.
            //List<int> actualList = _actionSource.Actions.ToList();

            // This line verifies that we have exactly 1 element in the list of actions.
            //Assert.That(actualList.Count, Is.EqualTo(1));

            // This line verifies that the first element in the list (the element at index 0)
            // is "3", the expected value.
            Assert.That(_actionSource.Actions, Is.EqualTo(new[] { 3 }));
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
            Assert.That(_actionSource.Actions, Is.EqualTo(new[] { 3, 4 }));
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
