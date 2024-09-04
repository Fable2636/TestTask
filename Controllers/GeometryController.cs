using Microsoft.AspNetCore.Mvc;
using TestTask.Models;
using TestTask.Services;

namespace TestTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GeometryController : ControllerBase
    {
        [HttpGet("circle/area")]
        public ActionResult<double> GetCircleArea(double radius)
        {
            var circle = FigureFactory.CreateFigure("Circle", radius);
            return circle.CalculateArea();
        }

        [HttpGet("triangle/area")]
        public ActionResult<double> GetTriangleArea(double side1, double side2, double side3)
        {
            var triangle = FigureFactory.CreateFigure("Triangle", side1, side2, side3);
            return triangle.CalculateArea();
        }

        [HttpGet("triangle/right")]
        public ActionResult<bool> IsRightTriangle(double side1, double side2, double side3)
        {
            var triangle = FigureFactory.CreateFigure("Triangle", side1, side2, side3) as Triangle;
            return triangle?.IsRightTriangle() ?? false;
        }
    }
}
