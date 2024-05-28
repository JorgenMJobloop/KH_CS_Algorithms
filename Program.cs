using System.Diagnostics;

namespace KH_CS_Uke4;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        
        

        Algorithms algorithms = new Algorithms();
        int[] sampleArray = {1,10,9,82, 24, 28, 16, 1028, 512, 256};
        algorithms.BubbleSort(sampleArray);
        Console.WriteLine("Bubble sort output: ");
        Console.WriteLine(string.Join(" ", sampleArray));

        stopwatch.Stop();
        Console.WriteLine($"Bubblesort ran for: {stopwatch.ElapsedMilliseconds} milliseconds");

        stopwatch.Start();

        int[] secondSample = {25, 150, 250, 10, 82, 7, 9, 3, 1};
        algorithms.Quicksort(secondSample, 0, secondSample.Length - 1);
        Console.WriteLine("Sorted array using Quicksort: ");
        Console.WriteLine(string.Join(" ", secondSample));

        stopwatch.Stop();

        Console.WriteLine($"Quicksort ran for: {stopwatch.ElapsedMilliseconds} milliseconds");

    }
}
