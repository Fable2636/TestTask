using TestTask.Interfaces;
using TestTask.Models;

namespace TestTask.Services
{
    public static class FigureFactory
    {
        public static IFigure CreateFigure(string type, params object[] parameters)
        {
            switch (type)
            {
                case "Circle":
                    return new Circle((double)parameters[0]);
                case "Triangle":
                    return new Triangle((double)parameters[0], (double)parameters[1], (double)parameters[2]);
                default:
                    throw new ArgumentException("Unsupported figure type");
            }
        }
    }
}
