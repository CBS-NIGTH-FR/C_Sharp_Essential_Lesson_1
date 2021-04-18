using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1-ю сторону");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2-ю сторону");
            double b = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(a, b);
            Console.WriteLine($"Площадь прямоугольника = {rectangle.Area}\nПериметр прямоугольника = {rectangle.Perimeter}");
            Console.ReadKey();
        }
    }
}
