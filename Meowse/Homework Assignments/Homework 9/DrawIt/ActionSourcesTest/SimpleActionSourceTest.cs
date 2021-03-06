﻿using System.Collections.Generic;
using System.Linq;
using ActionSources;
using NUnit.Framework;

namespace ActionSourcesTest
{
    [TestFixture]
    public class SimpleActionSourceTest
    {
        private SimpleActionSource<int> _actionSource;

        [SetUp]
        public void SetUp()
        {
             _actionSource = new SimpleActionSource<int>();
        }

        [Test]
        public void CannotUndoEmptyList()
        {
            Assert.That(_actionSource.CanUndo, Is.False);
        }

        // This is a BAD EXAMPLE.  You should NOT write tests like this.  They are BAD.
        [Test]
        public void UndoBehavesCorrectly()
        {
            // Can't undo on an empty list
            Assert.That(_actionSource.CanUndo, Is.False);
            
            _actionSource.Add(3);

            // Still can't undo after adding
            Assert.That(_actionSource.CanUndo, Is.False);
            
            _actionSource.Add(2);

            // Can't undo after adding twice
            Assert.That(_actionSource.CanUndo, Is.False);
        }

        [Test]
        public void CannotUndoListEvenAfterAdding()
        {
            _actionSource.Add(5);
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
            //
            // Of course, as Pat points out, this is also DEAD WRONG.  "EquivalentTo" doesn't
            // care about the order of the elements, and we do.  We determined this by changing
            // the 3, 4 to 4,3, and observing that the test still passed.
            Assert.That(_actionSource.Actions, Is.EquivalentTo(new[] { 3, 4 }));

            // Mickey's solution was to write a helper function, AssertActions, which 
            // verifies both the elements and their sequence.
            AssertActions(_actionSource.Actions, new[] { 3, 4 });

            // But Josh points out, correctly, that "Is.EqualTo()" actually compares
            // the contents of collections, rather than the type of the collections, and
            // so all we need to do is use Is.EqualTo() here.
            Assert.That(_actionSource.Actions, Is.EqualTo(new[] { 3, 4 }));
        }

        // This is Mickey's AssertActions helper function, written to verify that
        // the expected actions have the same sequence as the actual actions.
        private void AssertActions(IEnumerable<int> actions, int[] expectedActions)
        {
            List<int> actionsList = actions.ToList();
            Assert.That(actionsList.Count, Is.EqualTo(expectedActions.Length));
            for (int i = 0; i < actionsList.Count; i++)
            {
                Assert.That(actionsList[i], Is.EqualTo(expectedActions[i]), "Actions lists differ at index " + i);
            }
        }

        // And one more sample test, to show you how to verify that you are sending ActionsChanged
        // events at the right times.

        [Test]
        public void SendsActionsChangedEventWhenActionIsAdded()
        {
            CountingActionsChangedEventHandler otherEventsHandlerCounter = new CountingActionsChangedEventHandler();
            CountingActionsChangedEventHandler eventsHandledCounter = new CountingActionsChangedEventHandler();
            _actionSource.ActionsChanged += eventsHandledCounter.HandleActionsChanged;

            Assert.That(eventsHandledCounter.EventsHandled, Is.EqualTo(0));
            Assert.That(otherEventsHandlerCounter.EventsHandled, Is.EqualTo(0));
            _actionSource.Add(3);
            Assert.That(eventsHandledCounter.EventsHandled, Is.EqualTo(1));
            Assert.That(otherEventsHandlerCounter.EventsHandled, Is.EqualTo(0));
            _actionSource.Add(4);
            Assert.That(eventsHandledCounter.EventsHandled, Is.EqualTo(2));
            Assert.That(otherEventsHandlerCounter.EventsHandled, Is.EqualTo(0));
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
