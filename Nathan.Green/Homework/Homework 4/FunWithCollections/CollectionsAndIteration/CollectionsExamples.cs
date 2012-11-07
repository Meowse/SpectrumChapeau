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
            List<int> localNumbers;
            
            localNumbers = numbers;
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
             List<int> localNumbers = new List<int>();
            int numbersLength = numbers.Count;

            for (int i = 0; i < numbersLength; i++)
            {
                localNumbers.Add(2*(numbers[i]));
            }

            return localNumbers;
        }
    }
}
