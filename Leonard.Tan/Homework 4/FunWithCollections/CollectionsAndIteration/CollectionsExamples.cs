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

        public List<int> Doubled(List<int> numbers)
        {
            List<int> doubledResults = new List<int>();
            foreach (int number in numbers)
            {
                doubledResults.Add(number*2);
            }
            return doubledResults;

        }

        public List<int> DoubleInPlace(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++ )
            {
                numbers[i] = numbers[i]*2;
            }
                return numbers;

        }

        public List<int> MultipliedByIndex(List<int> numbers)
        {

            List<int> multipledByIndexResults = new List<int>();
            int index = 0;
            foreach (int number in numbers)
            {
                multipledByIndexResults.Add(number * index);
                index++;

            }
            return multipledByIndexResults;

        }

        public List<int> MultiplyByIndexInPlace(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++ )
            {
                numbers[i] = numbers[i]*i;
            }
                return numbers;

        }


        public List<int> OddBits(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++ )
            {
                numbers[i] = DivideUntilOdd(numbers[i]);
            }
            return numbers;
        }

        // Recusion for Division of 2 Until Odd Number or Prime Number
        public int DivideUntilOdd (int number)
        {
            int result = number%2;
            if (result != 0 || number == 0)
            {
                return number;
            }
            return DivideUntilOdd(number / 2);
        }

        public bool ContainsNumber(List<int> numbers, int search)
        {
            return numbers.Contains(search);
        }

        public bool HasNoDuplicates(List<int> numbers)
        {
            //SortedSet removes duplicates.
            SortedSet<int> set = new SortedSet<int>(numbers);

            //If there is no duplicates Count of SortedSet and Numbers would be the same.
            if (set.Count != numbers.Count)
            {
                return false;
            }
            return true;
        }

        public bool IsProperSubset(List<int> subsetA, List<int> subsetB)
        {
            //remove duplicates from each list.
            SortedSet<int> setA = new SortedSet<int>(subsetA);
            SortedSet<int> setB = new SortedSet<int>(subsetB);

            //start comparision for each number in setA against setB.
            foreach (int elementA in setA)
            {
                if (!setB.Contains(elementA))
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> Sort(List<int> numbers)
        {
            int placeHolder;

            for (int x = 0; x < numbers.Count; x++)
            {
                for (int y = 0; y < numbers.Count - 1; y++)
                {
                    if (numbers[y] > numbers[y + 1])
                    {
                        placeHolder = numbers[y];
                        numbers[y] = numbers[y + 1];
                        numbers[y + 1] = placeHolder;
                    }

                }              
            }

//            numbers.Sort();
            return numbers;
        }
    }
}
