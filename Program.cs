using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction x = new Fraction(12, 31);
            Fraction y = new Fraction(6, -9);
            Fraction z = new Fraction(2, 18);

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"z = {z}");

            Fraction xy = x * y;

            Console.WriteLine($"xy = {xy}");

            Fraction[] tab = new Fraction[] { x, y, z, xy };
            Array.Sort(tab);

            string sorted = String.Join<Fraction>(" < ", tab);
            Console.WriteLine($"Sorted: {sorted}");

        }
    }
}
