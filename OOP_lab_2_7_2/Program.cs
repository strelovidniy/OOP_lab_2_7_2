using System;

namespace OOP_lab_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = -1 * Math.PI / 2; x < 3 * Math.PI / 2; x += Math.PI / 3)
            {
                double y = Math.Cos(x) * Math.Cos(x) + 3 * Math.Sin(x);
                Console.WriteLine("x = {0:f4} y = {1:f4}", x, y);
            }
        }
    }
}
