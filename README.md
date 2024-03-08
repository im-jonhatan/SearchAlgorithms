# SearchAlgorithms Library

## Overview

The **SearchAlgorithms** library is a comprehensive collection of commonly used searching algorithms implemented in C#. This library provides efficient and versatile algorithms for searching elements in arrays, catering to diverse scenarios.

## Key Features

- **Algorithm Variety:** The library includes implementations of three major searching algorithms:
  - **Linear Search:** A straightforward algorithm that iterates through each element until a match is found.
  - **Binary Search:** A logarithmic search algorithm effective on sorted arrays, dividing the search space in half with each iteration.
  - **Interpolation Search:** An interpolation-based search suitable for uniformly distributed values, providing faster convergence to the target.

- **Benchmarking Utilities:** The library offers benchmarking utilities to assess the performance of the searching algorithms under different conditions.
  - **Execution Time Measurement:** Utilizing the `Stopwatch` class, the library accurately measures the elapsed time for executing specified algorithms on arrays with various parameters.
  - **Average Time Calculation:** The library provides a method to calculate the average execution time of an algorithm over multiple iterations with random target values.

## Usage

Developers can integrate the **SearchAlgorithms** library into their C# projects to leverage efficient and tested searching algorithms. The provided benchmarking utilities allow for performance analysis, aiding in the selection of the most suitable algorithm for specific use cases.

## Example Usage

```csharp
// Instantiate the library
using SearchAlgorithms;

// Create an array for testing
int[] testArray = { /* populate with data */ };

// Run specific algorithm with target value
long elapsedTime = Benchmark.Run(Search.Linear, testArray, targetValue);

// Run tests on various scenarios
long[] testResults = Benchmark.RunTests(Search.Binary, testArray.Length);
```

## Contributions
This open-source library welcomes contributions from the developer community. Feel free to enhance existing algorithms, propose new ones, or improve the benchmarking utilities. Your contributions can make searching algorithms more accessible and efficient for a wide range of applications.
