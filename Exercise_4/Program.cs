using System;


namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(2, 5, "A"), new Point(8, 15, "B"), new Point(20, 38, "C"));
            Console.WriteLine(figure.FigureName);
            figure.PerimeterCalculator();
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Figure figure1 = new Figure(new Point(20, 5, "A"), new Point(38, 15, "B"), new Point(45, 38, "C"), new Point(56, 78, "D"));
            Console.WriteLine(figure1.FigureName);
            figure1.PerimeterCalculator();
            Console.WriteLine();
            Console.WriteLine(new string('-', 50));
            Figure figure2 = new Figure(new Point(20, 5, "A"), new Point(38, 15, "B"), new Point(45, 38, "C"), new Point(56, 78, "D"), new Point(80, 98, "F"));
            Console.WriteLine(figure2.FigureName);
            figure2.PerimeterCalculator();
            Console.ReadKey();
        }
    }
}
