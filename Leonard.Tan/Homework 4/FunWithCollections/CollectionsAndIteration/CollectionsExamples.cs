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

        public int GetSmallest(List<int> numbers)
        {
            return numbers.Min();
        }

        public List<int> GetMostExtreme(List<int> numbers)
        {

            int absoluteMax = System.Math.Abs(numbers.Max());
            int absoluteMin = System.Math.Abs(numbers.Min());
            List<int> results = null;
            if (absoluteMax == absoluteMin)
            {
                results = new List<int> { numbers.Max(), numbers.Min() };                
            }

            if (absoluteMax < absoluteMin)
            {
               results = new List<int> { numbers.Min() } ;
            }

            if (absoluteMax > absoluteMin)
            {
                 results = new List<int> { numbers.Max() };
                
            }

            return results;
 
        }

        public int GetSecondLargest(List<int> numbers)
        {
            return GetNthLargest(numbers, 2);
            
        }

        public int GetNthLargest(List<int> numbers, int index)
        {
            List<int> tempNumbers = numbers;
            if (index <= numbers.Count())
            {
                for (int i = 1; i < index; i++)
                {
                    tempNumbers.RemoveAt(tempNumbers.BinarySearch(tempNumbers.Max()));
                }
                return tempNumbers.Max();
            }

            return 0;
        }

    }
}
