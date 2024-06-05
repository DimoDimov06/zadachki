using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Въведи колко вектора искаш!
            int N = int.Parse(Console.ReadLine());

            List<(double x, double y, double z)> vectors = new List<(double x, double y, double z)>();

            for (int i = 0; i < N; i++)
            {
                // Въведи коринатите с интервал.
                Console.Write($"Vectors {i + 1} (x y z): ");
                string[] parts = Console.ReadLine().Split();
                double x = double.Parse(parts[0]);
                double y = double.Parse(parts[1]);
                double z = double.Parse(parts[2]);
                vectors.Add((x, y, z));
            }
                
            double VectorLength((double x, double y, double z) vector)
            {
                return Math.Sqrt(vector.x * vector.x + vector.y * vector.y + vector.z * vector.z);
            }

            double minLength = vectors.Min(VectorLength);

            Console.WriteLine(minLength);
        }
    }
}