using System;


namespace Exercise_2
{
    class Rectangle
    {
        double side1, side2;
        public double Area { get; }
        public double Perimeter { get; }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            Area = AreaCalculator();
            Perimeter = PerimeterCalculator();
        }

        private double AreaCalculator()
        {
            double S = side1 * side2;
            return S;
        }

        private double PerimeterCalculator()
        {
            double P = side1 * 2 + side2 * 2;
            return P;
        }
    }
}
