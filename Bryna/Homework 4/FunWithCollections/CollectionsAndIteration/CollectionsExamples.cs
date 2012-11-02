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
            int length = numbers.Count - 1;
            int temp = 0;

            for(int j = 0; j < length; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }
            return numbers[1];
        }
        
        public List<int> DoubleInPlace(List<int> numbers)
        {
            List<int> doubledValues = new List<int>();

            foreach (int number in numbers)
                {
                    doubledValues.Add(number * 2);
                }
            return doubledValues;
        }

        public List<int> MultipliedByIndex(List<int> numbers)
        {
            int length = numbers.Count;
            List<int> multiplied = new List<int>();

            for (int i = 0; i < length; i++)
            {
                multiplied.Add(numbers[i] * i);
            }
            return multiplied;
        }
        
        public List<int> MultiplyByIndexInPlace(List<int> numbers)
        {
            int length = numbers.Count;
            List<int> multiplied = new List<int>();

            for (int i = 0; i < length; i++)
            {
                multiplied.Add(numbers[i] * i);
            }

            numbers = multiplied;
            return numbers;
        }

        public bool ContainsNumber(List<int> numbers, int n)
        {
            int valueSelected = n;
            bool contains = numbers.Contains(valueSelected);
            return contains;
        }

    
    }
}
