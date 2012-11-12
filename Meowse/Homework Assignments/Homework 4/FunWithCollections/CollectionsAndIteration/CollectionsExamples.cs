using System;
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

        public int GetSmallest(List<int> numbers)
        {
//            int currentSmallest = numbers[0];
//            foreach (int number in numbers)
//            {
//                if (number < currentSmallest)
//                {
//                    currentSmallest = number;
//                }
//            }
//            return currentSmallest;
            return numbers.Min();
        }

        public int[] GetBiggestMagnitude(List<int> numbers)
        {
            int biggestMagnitude = numbers[0];
            bool biggestMagnitudeIsTwin = false;

            foreach (int number in numbers)
            {
                if (Math.Abs(number) > Math.Abs(biggestMagnitude))
                {
                    biggestMagnitude = number;
                    biggestMagnitudeIsTwin = false;
                }
                else if (Math.Abs(number) == Math.Abs(biggestMagnitude))
                {
                    bool numberIsPositive = number > 0;
                    bool biggestMagnitudeIsPositive = biggestMagnitude > 0;
                    if (numberIsPositive != biggestMagnitudeIsPositive)
                    {
                        biggestMagnitudeIsTwin = true;
                    }
                }
            }

            return biggestMagnitudeIsTwin
                ? new List<int> {Math.Abs(biggestMagnitude), -Math.Abs(biggestMagnitude)}.ToArray()
                : new List<int> {biggestMagnitude}.ToArray();
        }
    }
}
