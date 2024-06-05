internal class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        Console.WriteLine($"Unsorted: {string.Join(' ', numbers)}");
        Array.Sort(numbers);
        Console.WriteLine($"sorted: {string.Join(' ', numbers)}");

        Console.WriteLine($"Average: {numbers.Average()}");

        var counts = numbers.GroupBy(x => x).OrderByDescending(group => group.Count()).FirstOrDefault();
        Console.WriteLine($"Mode: {counts?.Key}");

        int middleIndex = numbers.Length / 2;
        double median = numbers.Length % 2 == 0 ?
          (numbers[middleIndex - 1] + numbers[middleIndex]) / 2.0 :
          numbers[middleIndex];

        Console.WriteLine($"Median: {median}");
    }
}