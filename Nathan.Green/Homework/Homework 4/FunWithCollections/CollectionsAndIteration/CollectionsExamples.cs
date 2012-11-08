using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndIteration
{
    public class CollectionsExamples
    {

        public int GetBiggest(List<int> numbers)
        {
            int currentLargest = numbers[0];

            return numbers.Concat(new[] { currentLargest }).Max();
        }

        //Returns the smallest number in a list
        public int GetSmallest(List<int> numbers)
        {
            int currentSmallest = numbers[0];

            return numbers.Concat(new[] { currentSmallest }).Min();
        }

        //      GetMostExtreme -- Return the number or numbers that are farthest from zero
        //          -- This is Extra Credit
        //          -- You can use the function "Math.Abs()" to get the absolute value of a number
        //          -- If the most extreme positive number and the most extreme negative number have the same absolute value, return a list containing both of them.
        //
        public int[] GetMostExtreme(List<int> numbers)
        {
            int currentLargest = numbers[0];
            int previousLargest = numbers[0];
            var largestMagnitude = new List<int>();

            foreach (int number in numbers)
            {
                if (Math.Abs(number) >= currentLargest)
                {
                    previousLargest = currentLargest;
                    currentLargest = number;
                }

            }

            if(Math.Abs(currentLargest) == Math.Abs(previousLargest))
            {
                largestMagnitude.Add(currentLargest);
                largestMagnitude.Add(previousLargest);

                return largestMagnitude.ToArray();
            }
            else
            {
                largestMagnitude.Add(currentLargest);

                return largestMagnitude.ToArray();
            }
        }

        //      GetNthLargest -- Given a list and a number "n", return the nth-largest number from the list
        //          -- This is Extra Credit
        //          -- Use zero-based indexing: GetNthLargest([1,2,3], 0) should return 3.
        //          -- It's up to you whether GetNthLargest([11, 12, 13, 13, 14, 15], 3) should return 12 or 13.
        //
        //      This solution also solves Get2ndLargest
        public int GetNthLargest(List<int> numbers, int nth)
        {
            int nthLargest = numbers[0];
            List<int> localNumbers = numbers;
            int numbersLength = localNumbers.Count;

            //if the nth element number is larger than the size of the list, return with error 0
            if (numbersLength < nth)
            {
                return 0;
            }

            for(int iCount = 0; iCount <= nth; iCount++)
            {
                nthLargest = localNumbers[0];
                for (int jCount = 0; jCount < numbersLength; jCount++)
                {
                    if (localNumbers[jCount] > nthLargest)
                    {
                        nthLargest = localNumbers[jCount];
                    }
                }
                localNumbers.Remove(nthLargest);
                numbersLength--;
            }
            return nthLargest;
        }

        //      Doubled -- Return a new list consisting of each number, doubled
        //          -- To make an empty list, just say "new List<int>()"
        public List<int> Doubled(List<int> numbers)
        {
            var localNumbers = new List<int>();
            int numbersLength = numbers.Count;

            for (int i = 0; i < numbersLength; i++)
            {
                localNumbers.Add(2*(numbers[i]));
            }

            return localNumbers;
        }

        //      DoubleInPlace -- Change the list so that the number at each index is doubled
        //      -- You can change the value at a given index in the list using the same "[index]" syntax we used in class to get the value.
        //      myList[1] = 12;   // sets the second element of myList to the value 12.
        public List<int> DoubleInPlace(List<int> numbers, int i)
        {
            List<int> localNumbers = numbers;

            localNumbers[i] = 2*numbers[i];
            
            return localNumbers;
        }

        //      MultipliedByIndex -- Return a new list consisting of each number multiplied by its index in the list (zero-based)
        //          -- A basic for-loop for iterating over the list "myList" looks like:
        //              for (int i = 0; i < myList.length; i++) {
        //                  // do something with i
        public List<int> MultipliedByIndex(List<int> numbers)
        {
            List<int> localNumbers = numbers;

            for (int i = 0; i < localNumbers.Count; i++)
            {
                localNumbers[i] = i*localNumbers[i];
            }

            return localNumbers;           
        }

        //      MultiplyByIndexInPlace -- Change the list so that the number at each index is multiplied by its index (modify the original list)
        //          -- Just putting the last few together
        public List<int> MultiplyByIndexInPlace(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = i * numbers[i];
            }

            return numbers;
        }

        //      OddBits -- Return a list consisting of the odd numbers "as-is", and the even numbers repeatedly divided by two until they are odd
        //          -- This is Extra Credit
        //          -- You can do this with a while loop inside a foreach loop, but it's a LOT more readable if you do it with a method call inside
        //              the foreach loop
        public List<int> OddBits(List<int> numbers)
        {
           List<int> localNumbers = numbers;

           for(int i=0;i<localNumbers.Count;i++)
            {
                while (localNumbers[i] % 2 == 0)
                {
                    localNumbers[i] = localNumbers[i]/2;
                }
            }

            return localNumbers;          
        }

        //      ContainsNumber -- Given a list and a number "n", return true if the number occurs in the list
        //          -- There's a really easy way to do this one.
        public bool ContainsNumber(List<int> numbers, int num)
        {
            bool returnValue = false;

            foreach (int number in numbers)
            {
                if (number == num)
                {
                    returnValue = true;
                }
            }
            return returnValue;
        }

        //      HasNoDuplicates -- Given a list, return true if the list contains no duplicated elements
        //          -- This is Extra Credit
        //          -- Set<int> can be really helpful for this one
        public bool HasNoDuplicates(List<int> numbers)
        {
            bool hasDuplicateValue = false;

            for(int i=0;i<numbers.Count;i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        hasDuplicateValue = true;
                    }
                }
            }

            if (hasDuplicateValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //      IsProperSubset -- Given two lists, return true if the second list is a proper subset of the first list
        //          (i.e. it consists entirely of elements from the first list, and does not contain all elements of the first list)
        //          -- This is Extra Credit
        public bool IsProperSubset(List<int> numbers, List<int> numbers2)
        {
            bool inList;

            if (numbers.Count < numbers2.Count)
            {
                return false;
            }

            foreach (int t in numbers2)
            {
                inList = numbers.Contains(t);
                
                if(inList == false)
                {
                    return false;
                }
            }
            return true;
        }

        //      Sort -- Given a list of numbers, return a new list containing all of the elements from the list in increasing numerical order
        //          -- This is Extra Credit
        //          -- There is a built-in "Sort" method.  For this assignment, don't use it -- write your own.
        //          -- Do feel free to google "sorting algorithms", but try to figure it out on your own first.
        //          -- Super duper extra credit: implement one of the more efficient sorting algorithms, e.g. Mergesort.
        public List<int> Sort(List<int> numbers)
        {
            List<int> localNumbers = numbers;
            List<int> sortedNumbers = new List<int>();
            int loop = 0;
            int lowestNumber = localNumbers[0];

            while (loop < localNumbers.Count)
            {
                for (int i = loop; i < localNumbers.Count; i++)
                {
                    if (lowestNumber > localNumbers[i])
                    {
                        lowestNumber = localNumbers[i];
                    }
                }
                loop++;
                sortedNumbers.Add(lowestNumber);
                localNumbers.Remove(lowestNumber);
                lowestNumber = localNumbers[0];
                if (localNumbers.Count == 1)
                {
                    sortedNumbers.Add(lowestNumber);
                }
            }

            return sortedNumbers;
        }
    }
}
