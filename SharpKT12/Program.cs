using SharpKT12;
using System;

namespace StructsAndEnums_Point2D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D(3, 5);
            Console.WriteLine($"new Point2D {{ X = 3, Y = 5 }} -> четверть: {p1.GetQuadrant()}");

            Point2D p2 = new Point2D(-3, 5);
            Console.WriteLine($"new Point2D {{ X = -3, Y = 5 }} -> четверть: {p2.GetQuadrant()}");

            Console.WriteLine();

            Point2D original = new Point2D(3, 5);
            Point2D copy = original;
            copy.X = 10;
            copy.Y = 20;

            Console.WriteLine($"Оригинал: {original}");
            Console.WriteLine($"Копия:    {copy}");

            Console.WriteLine();

            bool success1 = Enum.TryParse<Quadrant>("First", out var q1);
            Console.WriteLine($"Enum.TryParse(\"First\"): {success1.ToString().ToLower()}, q == Quadrant.{q1}");

            bool success2 = Enum.TryParse<Quadrant>("Fifth", out var q2);
            Console.WriteLine($"Enum.TryParse(\"Fifth\"): {success2.ToString().ToLower()}, без исключения");
        }
    }
}