namespace KH_CS_Uke4;
class Program
{
    static void Main(string[] args)
    {
        Algorithms algorithms = new Algorithms();
        int[] sampleArray = {1,10,9,82, 24, 28, 16, 1028, 512, 256};
        algorithms.BubbleSort(sampleArray);
        Console.WriteLine("Bubble sort output: ");
        Console.WriteLine("[{0}]", string.Join(" ", sampleArray));
    }
}
