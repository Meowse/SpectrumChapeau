using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsAndIteration
{
    public class CollectionsExamples
    {

        public int GetBiggest(List<int> numbers)
        {
            return numbers.Max();
        }
        public int GetSmallest(List<int> numbers)
        {
            return numbers.Min();
        }

        public int[] GetGreatestAbsolute(List<int> numbers)
        {
            int biggestAbsolute = numbers[0];
            bool biggestAbsoluteIsDuplicate = false;

            foreach (int number in numbers)
            {
                if (Math.Abs(number) > Math.Abs(biggestAbsolute))
                {
                    biggestAbsolute = number;
                    biggestAbsoluteIsDuplicate = false;
                }
                else if (Math.Abs(number) == Math.Abs(biggestAbsolute))
                {
                    bool numberIsPositive = number > 0;
                    bool biggestMagnitudeIsPositive = biggestAbsolute > 0;
                    if (numberIsPositive != biggestMagnitudeIsPositive)
                    {
                        biggestAbsoluteIsDuplicate = true;
                    }
                }
            }

            return biggestAbsoluteIsDuplicate
                ? new List<int> { Math.Abs(biggestAbsolute), -Math.Abs(biggestAbsolute) }.ToArray()
                : new List<int> { biggestAbsolute }.ToArray();
        }
    }
}

 