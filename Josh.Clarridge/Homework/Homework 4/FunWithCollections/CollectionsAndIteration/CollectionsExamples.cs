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

        public int GetSmallest(List<int> numbers)
        {
            int currentSmallest = numbers[0];

            foreach (int number in numbers)
            {
                if (number < currentSmallest)
                {
                    currentSmallest = number;
                }
            }

            return currentSmallest;
        }

        public int GetSecondLargest(List<int> numbers)
        {
            int currentLargest = int.MinValue;
            int currentSecondLargest = int.MinValue;

            foreach (int number in numbers)
            {
                if (number > currentSecondLargest)
                {
                    if (number > currentLargest)
                    {
                        currentSecondLargest = currentLargest;
                        currentLargest = number;
                    }
                    else
                    {
                        currentSecondLargest = number;
                    }
                }
            }

            return currentSecondLargest;

        }

        public List<int> Doubled(List<int> numbers)
        {
            List<int> doubledList = new List<int>();

            foreach (int number in numbers)
            {
                doubledList.Add(number * 2);
            }

            return doubledList;
        }

        public List<int> DoubleInPlace(List<int> numbers)
        {
            for (int index = 0; index < numbers.Count; index++)
            {
                numbers[index] *= 2;
            }

            return numbers;
        }
    }
}
