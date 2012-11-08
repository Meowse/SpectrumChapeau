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

            return numbers.Concat(new[] {currentSmallest}).Min();
        }

        public List<int> DoubleListOfNumbers(List<int> numbers)
        {

            List<int> doubledList = new List<int> {};
            foreach (int number in numbers)
            {
                doubledList.Add(number*2);
            }
            return doubledList;
        }

        public List<int> DoubleListOfNumbersInPlace(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i]*2;
            }
            return numbers;
        }

        public List<int> MultiplyByIndexInPlace(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = numbers[i]*i;
            }
            return numbers;
        }

        public List<int> MultiplyByIndex(List<int> numbers)
        {
            List<int> IndexMultipliedList = new List<int> {};
            for (int i = 0; i < numbers.Count; i++)
            {
                IndexMultipliedList.Add(numbers[i]*i);
            }
            return IndexMultipliedList;
        }

        public List<int> SortList(List<int> numbers)
        {
            //List<int> IndexMultipliedList = new List<int> { };
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int temp = numbers[j];
                    if (numbers[j] > numbers[i])
                    {
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }

        public int ReturnNthLargest(List<int> numbers, int index)
        {
            //List<int> IndexMultipliedList = new List<int> { };
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int temp = numbers[j];
                    if (numbers[j] > numbers[i])
                    {
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers[index - 1];
        }

        public int Return2NdLargest(List<int> numbers)
        {
            //List<int> IndexMultipliedList = new List<int> { };
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    int temp = numbers[j];
                    if (numbers[j] > numbers[i])
                    {
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers[1];
        }

        public bool HasNoDuplicates(List<int> numbers)
        {
            //List<int> IndexMultipliedList = new List<int> { };
            bool duplicate = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        return !duplicate;
                    }
                }
            }
            return duplicate;
        }

        public bool HasGivenNumber(List<int> numbers, int number)
        {
            //List<int> IndexMultipliedList = new List<int> { };
            bool containsIt = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    return containsIt;
                }
            }
            return !containsIt;
        }

        private int convertToOdd(int anEvenNumber)
        {
            return (anEvenNumber/2);
        }

        public List<int> HasOddBits(List<int> numbers)
        {

            List<int> OddNumberList = new List<int> { };
            foreach (int i in numbers)
            {
               if(i%2 == 0)
               {
                   //even
                   int j = i;
                   bool isEven = true;
                   while (isEven)
                   {
                       j = convertToOdd(j);
                       if (i%2 != 0) {isEven = false;}
                       
                   }
                   OddNumberList.Add(j);
               }
               else
               {
                   OddNumberList.Add(i);
               }

            }
            return OddNumberList;
            ////List<int> IndexMultipliedList = new List<int> { };
            //bool containsIt = true;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == number)
            //    {
            //        return containsIt;
            //    }
            //}
            //return !containsIt;
        }

        public bool IsASubset(List<int> numbers, List<int> fewerNumbers)
        {
            bool sizeIsDifferent = false;
            if (numbers.Count() > fewerNumbers.Count())
            {
                sizeIsDifferent = true;
            }
            else
            {
                sizeIsDifferent = false;
            }
            bool isInNumbers = false;
            for (int i = 0; i < fewerNumbers.Count; i++)
            {
                bool currentNumberIsInNumbers = false;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[j] == fewerNumbers[i])
                    {
                        currentNumberIsInNumbers = true;
                    }
                    //else
                    //{
                    //    isInNumbers = false;
                    //}
                    
                }
                if(currentNumberIsInNumbers == true)
                {
                    currentNumberIsInNumbers = false;
                    isInNumbers = true;
                }
                else
                {
                    return false;
                }
            }
            if (sizeIsDifferent == true && isInNumbers == true)
            {
                return true;
            }
            return false;
            //return sizeIsDifferent;
        }

    }

}