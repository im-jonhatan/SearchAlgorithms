using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SearchAlgorithms
{
    /// <summary>
    /// Provides methods for benchmarking and testing search algorithms.
    /// </summary>
    internal class Benchmark
    {
        /// <summary>
        /// Executes a specified algorithm on an array with a target value and measures the elapsed time.
        /// </summary>
        /// <param name="algorithm">The algorithm to be executed, represented as a function.</param>
        /// <param name="array">The array on which the algorithm will be applied.</param>
        /// <param name="value">The target value used as a parameter for the algorithm.</param>
        /// <returns>The elapsed time in milliseconds taken to execute the algorithm on the array.</returns>
        public static long Run(Func<int[], int, int> algorithm, int[] array, int value)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            algorithm(array, value);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Calculates the average execution time of a specified algorithm on an array with a random target value.
        /// </summary>
        /// <param name="algorithm">The algorithm to be executed, represented as a function.</param>
        /// <param name="array">The array on which the algorithm will be applied.</param>
        /// <returns>The average elapsed time in milliseconds taken to execute the algorithm on the array with random target values.</returns>
        public static long Average(Func<int[], int, int> algorithm, int[] array)
        {
            const int numberOfMeasurements = 100;
            long totalElapsedTime = 0;
            Random random = new Random();

            for (int i = 0; i < numberOfMeasurements; i++)
            {
                int randomInt = random.Next(array.Length);
                long elapsedTime = Run(algorithm, array, randomInt);

            }

            return totalElapsedTime / numberOfMeasurements;
        }

        /// <summary>
        /// Runs tests on a specified algorithm with different scenarios and returns the results.
        /// </summary>
        /// <param name="algorithm">The algorithm to be tested, represented as a function.</param>
        /// <param name="size">The size of the array used in the tests.</param>
        /// <returns>An array of three long values representing the elapsed time for the algorithm in different scenarios:
        /// [0] Elapsed time with the minimum value in the array.
        /// [1] Elapsed time with the maximum value in the array.
        /// [2] Average elapsed time with random values in the array.</returns>
        public static long[] RunTests(Func<int[], int, int> algorithm, int size)
        {
            long[] response = new long[3];

            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            int minValue = array[0];
            int maxValue = array[array.Length - 1];

            response[0] = Run(algorithm, array, minValue);
            response[1] = Run(algorithm, array, maxValue);
            response[2] = Average(algorithm, array);

            return response;
        }
    }
}
