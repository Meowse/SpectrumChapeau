using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndIteration
{
    public class CollectionsExamples
    {

        public int GetBiggest(List<int> numbers)
        {
            int[] arr = numbers.ToArray();
            return arr.Max();
            //int currentLargest = numbers[0];

            //return numbers.Concat(new[] {currentLargest}).Max();
        }

        public int GetSmallest(List<int> numbers)
        {
            int[] arr = numbers.ToArray();
            return arr.Min();



            //int currentsmallest = numbers[0];

            //return numbers.Concat(new[] {currentsmallest}).Min();
        }
        public List<int> ReturnListOfDoubledNumbers(List<int> numbers)
        {
            List<int> number = new List<int>();

            foreach (int n in number)
            {
                number.Add(n*2);
            }
            return number;
        }
        public List<int> GetEachNumberMultipliedByIndex(List<int> numbers)
        {
            List<int> number = new List<int>();         //In this step we are getting object of a class
            for (int i = 0; i < number.Count; i++)
            {
                number.Add(numbers.ElementAt(i));
            }
            return number;
        }
        public int ReturnFarthestFromZero(List<int> numbers)
        {
            int temp = 0;
            foreach (int n in numbers)
            {
                if(System.Math.Abs(n) > System.Math.Abs(temp))
                {
                    temp = n;
                }
            }
            return temp;
        }




        //TODO: needs add'l comparison- currently finds 1, 2-largest Mags
        public int[] GetBiggestMagnitude(List<int> numbers)
        {
            //List<int> returnValue = new List<int>();
            //int[] arr = numbers.ToArray();
            //int max = numbers.Max();
            //int min = numbers.Min();
            //if (System.Math.Abs(min) == System.Math.Abs(max))
            //{
            //    returnValue.Add(min);
            //    returnValue.Add(max);
            //    return returnValue.ToArray();
            //}
        

            //if (System.Math.Abs(min) > System.Math.Abs(max))
            //    returnValue.Add(min);
            //else
            //{
            //    returnValue.Add(max);
            //}

            //return returnValue.ToArray();
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

    }
}
