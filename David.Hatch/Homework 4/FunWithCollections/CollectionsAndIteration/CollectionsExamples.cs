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

        public int GetSmallest(List<int> numbers)
        {
            int currentSmallest = numbers[0];

            return numbers.Concat(new[] {currentSmallest}).Min();

        }

        public int[] GetMostExtreme(List<int> numbers)
        {
            int currentLargest = numbers[0];
            int previousLargest = numbers[0];
            var mostExtreme = new List<int>();
            foreach(int number in numbers)
            {
                if (System.Math.Abs(number) >= System.Math.Abs(currentLargest))
                {
                    previousLargest = currentLargest;
                    currentLargest = number;
                }

            }

            if (System.Math.Abs(currentLargest) == System.Math.Abs(previousLargest))
            {
                mostExtreme.Add(currentLargest);
                mostExtreme.Add(previousLargest);
            }
            else
            {
                mostExtreme.Add(currentLargest);
                //mostExtreme.Remove(previousLargest);

            }
            
            return mostExtreme.ToArray();
        }

        public int GetNthLargest(List<int> numbers,int NthNumber)
        {
            int SecondLargestNumber = 0;
            int SortSequence = 0;
            
            numbers.Sort();
            numbers.Reverse();
            var uninumber = numbers.Distinct();
            
            foreach(int number in uninumber)
            {
                SortSequence = SortSequence + 1;
                System.Console.Write(number.ToString());
                if(SortSequence == NthNumber)
                {
                    SecondLargestNumber = number;
                }

            }

            return SecondLargestNumber;

        }

        public int[] Doubled(List<int> numbers)
        {
            var doublelist = new List<int>();

       

            foreach(int number in numbers)

            {
                doublelist.Add(number+number);
            }

            return doublelist.ToArray();
        }

        public int[] DoubledInPlace(List<int> numbers)
        {
            // dsh comment - the only diff in this  and the above is it will return the same list instead of a new one
            // and the test will not know the difference
            int tempvar = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                tempvar = numbers[i] + numbers[i];
                numbers[i] = tempvar;
            }

            //dsh is there a way to print the list at once?
            //System.Console.Write(numbers.ToArray());

            return numbers.ToArray();

        }

        public int[] MultipliedByIndex(List<int> numbers)
        {
            var newlist = new List<int>();
            int tempvar = 0;


            for (int i = 0; i < numbers.Count; i++)
            {
                tempvar = i*numbers[i];
                newlist.Add(tempvar);
            }

            return newlist.ToArray();

        }

        public int[] MultipliedByIndexInPlace(List<int> numbers)
        {
            int tempvar = 0;

            for (int i=0; i < numbers.Count; i++)
            {
                tempvar = i*numbers[i];
                numbers[i] = tempvar;
            }

            return numbers.ToArray();

        }

        public int[] OddBits(List<int> numbers)
        {
            var OddBitList = new List<int>();
            int tempvar = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    OddBitList.Add(numbers[i]);
                }
                else
                {
                    //tempvar = numbers[i];
                    tempvar = getEven(numbers[i]);
                    OddBitList.Add(tempvar);
                }
                    
            }

            return OddBitList.ToArray();
        }

        public int getEven(int checknum)
        {
            do
            {
                checknum = checknum/2;

            } while (checknum%2==0);

            return checknum;
        }

        public bool ContainsNumber(List<int> numbers, int testNumber)
        {
            foreach(int number in numbers)
            {
                if (number == testNumber)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasNoDuplicates(List<int> numbers)
        {
            var checklist = new List<int>();
            foreach(int number in numbers)
            {
                if(!checklist.Contains(number))
                {
                    checklist.Add(number);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsProperSubset(List<int> numbers, List<int> list2)
        {
            foreach (int xnumber in list2)
            {
                if(!numbers.Contains(xnumber))
                {
                    return false;
                }
            }

            return true;

        }


    
    
    
    
    
    
    }
}
