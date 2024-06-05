
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var list3 = list.Union(list2);
            var list4 = list.Intersect(list2);
            var list5 = list.Except(list2);
            var list6 = list.Concat(list2);

            Console.WriteLine($"Union: {string.Join(" ", list3)}");
            Console.WriteLine($"Intersect: {string.Join(" ", list4)}");
            Console.WriteLine($"Suptraction: {string.Join(" ", list5)}");
            Console.WriteLine($"Sum: {string.Join(" ", list6)}");
        }
    }
