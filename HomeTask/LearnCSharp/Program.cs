using System;
using LearnCSharp;

class Program
{
    public static void Main(string[] args)
    {
        Point lefttoppoint = new Point
        {
            X = 10,
            Y = 10
        };
        Point rightbottompoint = new Point
        {
            X = 20,
            Y = 6
        };
            try
            {
                Elipse elipse = new Elipse(lefttoppoint, rightbottompoint);
                double perimeter = elipse.GetPerimeter();
                double square = elipse.GetSquare();
                Console.WriteLine($"Длина дуги Элипса равна = {perimeter}");
                Console.WriteLine($"Площадь эллипса = {square}");
                Console.WriteLine($"Исходные координаты точек: {lefttoppoint.ToString()} {rightbottompoint.ToString()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
    }
}