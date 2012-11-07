using System.Collections.Generic;
using CollectionsAndIteration;
using NUnit.Framework;

namespace CollectionsAndIterationTest
{
    [TestFixture]
    public class CollectionsExamplesTest
    {
        [Test]
        public void ShouldReturnTheLargestNumber()
        {
            List<int> numbers = new List<int> { 1, 2, 4, 3};
            Assert.That(new CollectionsExamples().GetBiggest(numbers), Is.EqualTo(4));
        }

        [Test]
        public void ShouldReturnTheLargestNegativeNumber()
        {
            List<int> numbers = new List<int> {-3, -5, -1, -2};
            Assert.That(new CollectionsExamples().GetBiggest(numbers), Is.EqualTo(-1));
        }

        [Test]
        public void ShouldReturnTheSmallestNumber()
        {
            List<int> numbers = new List<int> { 1, 2, 4, 3 };
            Assert.That(new CollectionsExamples().GetSmallest(numbers), Is.EqualTo(1));
        }

        [Test]
        public void ShouldReturnTheSmallestNegativeNumber()
        {
            List<int> numbers = new List<int> { -3, -5, -1, -2 };
            Assert.That(new CollectionsExamples().GetSmallest(numbers), Is.EqualTo(-5));
        }

        [Test]
        public void ShouldReturnTheTwoLargestMagnitudeSameNegativeandPostiveNumber()
        {
            List<int> numbers=new List<int> {4, 5, -3, -5};
            var largestInList = new List<int>();
            largestInList.Add(5);
            largestInList.Add(-5);
            CollectionAssert.AreEquivalent(largestInList, new CollectionsExamples().GetMostExtreme(numbers));
        }

        [Test]
        public void ShouldReturnTheLargestMagnitudePositiveNumber()
        {
            List<int> numbers = new List<int> { 4, 8, -3, -5 };
            List<int> returnValue = new List<int> { 8 };

            Assert.That(new CollectionsExamples().GetMostExtreme(numbers), Is.EqualTo(returnValue));
        }
        
        [Test]
        public void ShouldReturn0ThLargestNumber()
        {
            List<int> numbers = new List<int> {4, 8, -3, -5, 13, 4, 85};
            int nth = 0;

            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(85));
        }
        
        [Test]
        public void ShouldReturn1StLargestNumber()
        {
            List<int> numbers = new List<int> {4, 8, -3, -5, 13, 4, 85};
            int nth = 1;

            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(13));
        }
        
        [Test]
        public void ShouldReturn2NdLargestNumber()
        {
            List<int> numbers = new List<int> {4, 8, -3, -5, 13, 4, 85};
            int nth = 2;

            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(8));
        }

        [Test]
        public void ShouldReturn3RdLargestNumber()
        {
            List<int> numbers = new List<int> {4, 8, -3, -5, 13, 4, 85};
            int nth = 3;
            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(4));
        }

        [Test]
        public void ShouldReturn4ThLargestNumber()
        {
            List<int> numbers = new List<int> {4, 8, -3, -5, 13, 4, 85};
            int nth = 4;

            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(4));
        }

        [Test]
        public void ShouldReturn5ThLargestNumber()
        {
            List<int> numbers = new List<int> {4, 8, -3, -5, 13, 4, 85};
            int nth = 5;
            
            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(-3));
        }

        [Test]
        public void ShouldReturn6ThLargestNumber()
        {
            List<int> numbers = new List<int> { 4, 8, -3, -5, 13, 4, 85 };
            int nth = 6;

            Assert.That(new CollectionsExamples().GetNthLargest((numbers), nth), Is.EqualTo(-5));
        }

        // TODO: EXTRA CREDIT: What should we do if the list is empty?

        // For all of the below, don't worry about handling exceptional conditions such as empty lists.  
        // For extra credit, however, feel free to do so if you are so inclined.

        // For each task, please use the provided name.  For tasks which specify multiple arguments (e.g. a list and a number), please
        // put the list parameter first.  For all tasks, assume that we're dealing only with integers (i.e. "List<int>" for the list parameter).

        // This is a big homework assignment.  My advice is to solve these in order, and ask on the class forums for help when you get stuck.
        // It's a lot easier to understand and solve the later ones if you've already understood and solved the earlier ones.
        
        // Keep working at it.  Remember that homework is graded on whether you attempted it, not on whether you got 100% of it working perfectly.

        // And above all else, remember that you get better at writing software by...writing software.

        // Given a list of numbers:
        //      GetBiggest -- Return the largest
        //          -- already done
        //
        //      GetSmallest -- Return the smallest
        //          -- much like the former
        //
        //      GetMostExtreme -- Return the number or numbers that are farthest from zero
        //          -- This is Extra Credit
        //          -- You can use the function "Math.Abs()" to get the absolute value of a number
        //          -- If the most extreme positive number and the most extreme negative number have the same absolute value, return a list containing both of them.
        //
        //      GetSecondLargest -- Return the second-largest number
        //          -- As you solve this, think about whether your solution generalizes well to solving the next problem
        //
        //      GetNthLargest -- Given a list and a number "n", return the nth-largest number from the list
        //          -- This is Extra Credit
        //          -- Use zero-based indexing: GetNthLargest([1,2,3], 0) should return 3.
        //          -- It's up to you whether GetNthLargest([11, 12, 13, 13, 14, 15], 3) should return 12 or 13.
        //
        //      Doubled -- Return a new list consisting of each number, doubled
        //          -- To make an empty list, just say "new List<int>()"
        // 
        //      DoubleInPlace -- Change the list so that the number at each index is doubled
        //          -- You can change the value at a given index in the list using the same "[index]" syntax we used in class to get the value.
        //              myList[1] = 12;   // sets the second element of myList to the value 12.
        //
        //      MultipliedByIndex -- Return a new list consisting of each number multiplied by its index in the list (zero-based)
        //          -- A basic for-loop for iterating over the list "myList" looks like:
        //              for (int i = 0; i < myList.length; i++) {
        //                  // do something with i
        //              }
        //          -- We'll talk more about the structure of a for-loop in the next class; for now, you can just use the above as boiler-plate
        //              to count through all of the index values from 0 to the highest index in the list (which is, by the way, myList.length - 1)
        //
        //      MultiplyByIndexInPlace -- Change the list so that the number at each index is multiplied by its index (modify the original list)
        //          -- Just putting the last few together
        //
        //      OddBits -- Return a list consisting of the odd numbers "as-is", and the even numbers repeatedly divided by two until they are odd
        //          -- This is Extra Credit
        //          -- You can do this with a while loop inside a foreach loop, but it's a LOT more readable if you do it with a method call inside
        //              the foreach loop
        // 
        //      ContainsNumber -- Given a list and a number "n", return true if the number occurs in the list
        //          -- There's a really easy way to do this one.
        // 
        //      HasNoDuplicates -- Given a list, return true if the list contains no duplicated elements
        //          -- This is Extra Credit
        //          -- Set<int> can be really helpful for this one
        //
        //      IsProperSubset -- Given two lists, return true if the second list is a proper subset of the first list
        //          (i.e. it consists entirely of elements from the first list, and does not contain all elements of the first list)
        //          -- This is Extra Credit
        //
        //      Sort -- Given a list of numbers, return a new list containing all of the elements from the list in increasing numerical order
        //          -- This is Extra Credit
        //          -- There is a built-in "Sort" method.  For this assignment, don't use it -- write your own.
        //          -- Do feel free to google "sorting algorithms", but try to figure it out on your own first.
        //          -- Super duper extra credit: implement one of the more efficient sorting algorithms, e.g. Mergesort.
    }
}
