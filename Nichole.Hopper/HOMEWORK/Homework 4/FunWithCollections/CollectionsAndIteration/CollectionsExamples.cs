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

        //TODO: needs add'l comparison- currently finds 1, 2-largest Mags
        public int[] GetBiggestMagnitude(List<int> numbers)
        {
            int currentLargest = numbers[0];
            int previousLargest = numbers[0];
            var largestMagnitude = new List<int>();
            foreach (int number in numbers)
            {
                if (System.Math.Abs(number) >= currentLargest)
                {
                    previousLargest = currentLargest;
                    currentLargest = number;
                }

            }

            largestMagnitude.Add(currentLargest);
            largestMagnitude.Add(previousLargest);

            return largestMagnitude.ToArray();
        }

        public int GetSmallest(List<int> numbers)
        {
            int currentSmallest = numbers[0];

            return numbers.Concat(new[] { currentSmallest }).Min();

        }

        public int GetNthLargest(List<int> numbers, int NthNumber)
        {
            int SecondLargestNumber = 0;
            int SortSequence = 0;

            numbers.Sort();
            numbers.Reverse();
            var uninumber = numbers.Distinct();

            foreach (int number in uninumber)
            {
                SortSequence = SortSequence + 1;
                System.Console.Write(number.ToString());
                if (SortSequence == NthNumber)
                {
                    SecondLargestNumber = number;
                }

            }

            return SecondLargestNumber;

        }

        public int[] Doubled(List<int> numbers)
        {
            var doublelist = new List<int>();



            foreach (int number in numbers)
            {
                doublelist.Add(number + number);
            }

            return doublelist.ToArray();
        }

        public bool ContainsNumber(List<int> numbers, int testNumber)
        {
            foreach (int number in numbers)
            {
                if (number == testNumber)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
