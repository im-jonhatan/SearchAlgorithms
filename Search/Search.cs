namespace Search
{
    /// <summary>
    /// Provides static methods for searching elements in an integer array using various search algorithms.
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Performs a linear search on the array to find the index of the specified value.
        /// </summary>
        /// <param name="array">The array to be searched.</param>
        /// <param name="value">The value to be searched for.</param>
        /// <returns>The index of the first occurrence of the value in the array, or -1 if not found.</returns>
        public static int Linear(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Performs a binary search on the sorted array to find the index of the specified value.
        /// </summary>
        /// <param name="array">The sorted array to be searched.</param>
        /// <param name="value">The value to be searched for.</param>
        /// <returns>The index of the value in the sorted array, or -1 if not found.</returns>
        public static int Binary(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == value)
                    return middle;
                else if (array[middle] > value)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }

        /// <summary>
        /// Performs an interpolation search on the array to find the index of the specified value.
        /// </summary>
        /// <param name="array">The sorted array to be searched.</param>
        /// <param name="value">The value to be searched for.</param>
        /// <returns>The index of the value in the sorted array, or -1 if not found.</returns>
        public static int Interpolation(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right && value >= array[left] && value <= array[right])
            {
                if (array[right] - array[left] == 0)
                {
                    if (array[left] == value)
                        return left;
                    else
                        return -1; // Avoid division by zero
                }

                // interpolation formula with floating-point division
                int position = left + (int)(((double)(right - left) / (array[right] - array[left])) * (value - array[left]));

                if (position < 0 || position >= array.Length)
                    return -1; // Check if position is within array bounds

                if (array[position] == value)
                    return position;

                if (array[position] < value)
                    left = position + 1;
                else
                    right = position - 1;
            }

            return -1;
        }

    }
}