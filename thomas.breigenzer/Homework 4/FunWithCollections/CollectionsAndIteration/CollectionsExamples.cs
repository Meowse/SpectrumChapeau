using System.Collections;
using System.Collections.Generic;

namespace CollectionsAndIteration
{
    public class CollectionsExamples
    {
        public int GetBiggest(List<int> numbers)
        {
            int currentLargest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > currentLargest)
                {
                    currentLargest = number;
                }

            }

            return currentLargest;
        }

        //TODO: needs add'l comparison- currently finds 1, 2-largest Mags
        public IEnumerable<int> GetBiggestMagnitude(List<int> numbers)
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

        public int Get2ndLargest(List<int> numbers)
        {
            int secondBiggest = numbers[0];
            int currentBiggest = numbers[0];
            foreach (int number in numbers)
            {
                if (currentBiggest < number)
                {
                    secondBiggest = currentBiggest;
                    currentBiggest = number;
                }
            }
            return secondBiggest;
        }

        public int GetNthLargest(int[] numbers, int arraynumber)
        {
            System.Array.Sort(numbers);
            return numbers[arraynumber - 1];
        }

        public IEnumerable<int> GetDoubled(List<int> numbers)
        {
            List <int>  doubledList = new List<int>();
            foreach (int number in numbers)
            {
                doubledList.Add(number*2);

            }
            return doubledList;

        }


    }
}