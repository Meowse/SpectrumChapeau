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

    }
}
