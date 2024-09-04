using TestTask.Interfaces;

namespace TestTask.Models
{
    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            var semiPerimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
        }

        public bool IsRightTriangle()
        {
            var sides = new[] { _side1, _side2, _side3 };
            Array.Sort(sides);
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-10;
        }
    }
}
