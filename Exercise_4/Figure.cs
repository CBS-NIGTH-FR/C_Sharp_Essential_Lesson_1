using System;


namespace Exercise_4
{
    class Figure
    {
        Point[] points;
        string figure_name;
        public string FigureName
        {
            get
            {
                return figure_name;
            }
        }
                      
        public Figure(Point A, Point B, Point C)
        {
            points = new Point[3];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            figure_name = "Треугольник";
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            points = new Point[4];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            figure_name = "Четырехугольник";
        }

        public Figure(Point A, Point B, Point C, Point D, Point F)
        {
            points = new Point[5];
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            points[4] = F;
            figure_name = "Пятиугольник";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimetr = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimetr += LengthSide(points[i], points[i + 1]);
            }
            perimetr += LengthSide(points[points.Length - 1], points[0]);
            Console.WriteLine(Math.Round(perimetr, 2));
        }

    }
}
