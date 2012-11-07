using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndIteration
{
    public class CollectionsExamples
    {

        public int GetBiggest(List<int> numbers)
        {
            int currentLargest = numbers[0];

            return numbers.Concat(new[] {currentLargest}).Max();
        }
        //TODO: needs add'l comparison- currently finds 1, 2-largest Mags
        public int[] GetBiggestMagnitude(List<int> numbers)
        {
            int currentLargest = numbers[0];
            int previousLargest = numbers[0];
            var largestMagnitude=new List<int>();
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

        public int GetSecondLargest(List<int> numbers)
        {
            numbers.Sort();
            numbers.Reverse();
            var uniqueNumbers = numbers.Distinct();
            int secondLargest = 0;

            secondLargest = numbers[1];
            return secondLargest;
        }
        public List<int> DoubleInPlace(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count(); ++i)
            {
                numbers[i] = numbers[i]*2;
                //System.Console.WriteLine(i);
            }

            return numbers;
        }
        public List<int> Doubled(List<int> numbers)
        {
            var newNumberList = new List<int>();

            for (int i = 0; i < numbers.Count(); ++i)
            {

                newNumberList.Insert(i, numbers[i]);
                newNumberList[i] = newNumberList[i]*2;
            }
            return newNumberList;
        }

        public List<int> MultipliedByIndex(List<int> numbers)
        {
            var newNumberList = new List<int>();

            for(int i=0; i<numbers.Count();i++)
            {
                newNumberList.Insert(i,numbers[i]);
                newNumberList[i] = newNumberList[i]*i;
            }

            return newNumberList;
        }

        public List<int> MultipliedByIndexInPlace(List<int> numbers)
        {
 
            for (int i = 0; i < numbers.Count(); i++)
            {
                numbers[i] = numbers[i]*i;
            }

            return numbers;
        }

        public bool ContainsNumber(List<int> numbers,int n)
        {
            for (int i = 0; i < numbers.Count(); ++i)
            {
                if (numbers[i] == n)
                {
                    return true;
                }
            }
            return false;
        }

 
    }

}
   