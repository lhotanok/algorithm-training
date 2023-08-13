namespace AlgoTraining
{
    public class BinarySearch
    {
        /// <summary>
        /// Performs a binary search on a collection of numbers sorted in an ascending order.
        /// </summary>
        /// <param name="sortedNumbers">A collection of numbers sorted in an ascending order</param>
        /// <param name="searchedValue">Value that should be searched against the <paramref name="sortedNumbers"/></param>
        /// <returns>An index of the searched element.
        /// Returns -1 if the element was not found.</returns>
        public static int Find(IList<int> sortedNumbers, int searchedValue)
        {
            int i = 0;
            int j = sortedNumbers.Count;

            while (i < j)
            {
                int pivot = GetPivot(i, j);

                int value = sortedNumbers[pivot];

                if (value == searchedValue)
                {
                    return pivot;
                }

                if (value > searchedValue)
                { 
                    j = pivot;
                }
                else
                {
                    i = pivot + 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Performs a binary search on a collection of numbers sorted in an ascending order.
        /// </summary>
        /// <param name="sortedNumbers">A collection of numbers sorted in an ascending order</param>
        /// <param name="searchedValue">Value that should be searched against the <paramref name="sortedNumbers"/></param>
        /// <returns>An index of the searched element.
        /// Returns -1 if the element was not found.</returns>
        public static int Find(int[] sortedNumbers, int searchedValue) => Find(sortedNumbers.ToList(), searchedValue);

        private static int GetPivot(int i, int j)
        {
            return i + ((j - i) / 2);
        }
    }
}
