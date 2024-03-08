using ConsoleTables;

namespace SearchAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sizeFormatted;
            const int smallSize = 2000000;
            const int medSize = 20000000;
            const int bigSize = 200000000;

            ConsoleTable table = new ConsoleTable("Algorithm", "Array size", "First value", "Last value", "Average");
            // small array test
            long[] linear = Benchmark.RunTests(Search.Search.Linear, smallSize);
            long[] binary = Benchmark.RunTests(Search.Search.Binary, smallSize);
            long[] interpolation = Benchmark.RunTests(Search.Search.Interpolation, smallSize);

            sizeFormatted = smallSize.ToString("#,##0");
            table.AddRow("Linear", sizeFormatted, $"{linear[0]} ms", $"{linear[1]} ms", $"{linear[2]} ms");
            table.AddRow("Binary", sizeFormatted, $"{binary[0]} ms", $"{binary[1]} ms", $"{binary[2]} ms");
            table.AddRow("Interpolation", sizeFormatted, $"{interpolation[0]} ms", $"{interpolation[1]} ms", $"{interpolation[2]} ms");

            // meddium array test
            linear = Benchmark.RunTests(Search.Search.Linear, medSize);
            binary = Benchmark.RunTests(Search.Search.Binary, medSize);
            interpolation = Benchmark.RunTests(Search.Search.Interpolation, medSize);

            sizeFormatted = medSize.ToString("#,##0");
            table.AddRow("Linear", sizeFormatted, $"{linear[0]} ms", $"{linear[1]} ms", $"{linear[2]} ms");
            table.AddRow("Binary", sizeFormatted, $"{binary[0]} ms", $"{binary[1]} ms", $"{binary[2]} ms");
            table.AddRow("Interpolation", sizeFormatted, $"{interpolation[0]} ms", $"{interpolation[1]} ms", $"{interpolation[2]} ms");

            // big array test
            linear = Benchmark.RunTests(Search.Search.Linear, bigSize);
            binary = Benchmark.RunTests(Search.Search.Binary, bigSize);
            interpolation = Benchmark.RunTests(Search.Search.Interpolation, bigSize);

            sizeFormatted = bigSize.ToString("#,##0");
            table.AddRow("Linear", sizeFormatted, $"{linear[0]} ms", $"{linear[1]} ms", $"{linear[2]} ms");
            table.AddRow("Binary", sizeFormatted, $"{binary[0]} ms", $"{binary[1]} ms", $"{binary[2]} ms");
            table.AddRow("Interpolation", sizeFormatted, $"{interpolation[0]} ms", $"{interpolation[1]} ms", $"{interpolation[2]} ms");

            table.Write();
        }
    }
}
