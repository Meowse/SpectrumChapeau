using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        public int GetNthLargest(int[] numbers, int arraynumber)
        {
            System.Array.Sort(numbers);
            System.Array.Reverse(numbers);
            return numbers[arraynumber - 1];
        }

        public IEnumerable<int> GetDoubled(List<int> numbers)
        {
            List<int> doubledList = new List<int>();
            foreach (int number in numbers)
            {
                doubledList.Add(number*2);

            }
            return doubledList;

        }

        public List<int> GetDoubledInPlace(List<int> numbers)
        {
            for (int a = 0; a < numbers.Count; a++)
            {
                numbers[a] = numbers[a]*2;
            }
            return numbers;
        }

        public IEnumerable<int> GetMultipliedByIndex(List<int> numbers)
        {
            List<int> multiplyByIndexList = new List<int>();
            for (int a = 0; a < numbers.Count; a++)
            {
                multiplyByIndexList.Add(numbers[a]*a);

            }
            return multiplyByIndexList;
        }

        public List<int> GetMultipliedByIndexInPlace(List<int> numbers)
        {
            for (int a = 0; a < numbers.Count; a++)
            {
                numbers[a] = numbers[a]*a;

            }
            return numbers;
        }

        public bool GetContainsNumber(List<int> numbers, int listnumber)
        {
            bool containsNumber = numbers.Any(item => item == listnumber);
            return containsNumber;
        }

    }
}