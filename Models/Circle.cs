using TestTask.Interfaces;

namespace TestTask.Models
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public bool IsRightTriangle()
        {
            return false;
        }
    }
}
