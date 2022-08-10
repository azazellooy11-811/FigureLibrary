using System;
using Library.Figures;
using Library.Interfaces;

namespace FigureLibrary
{
    public class Client : IClient
    {
        public double SquareCircle(double radius)
        {
            var circle = new Circle(radius);
            return CalculateFigure(circle);
        }

        public double SquareTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return CalculateFigure(triangle);
        }

        public double CalculateFigure(IFigure figure) => figure.CalculateFigure();

        public bool IsRightTriangle(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.IsRightAngle;
        }
    }
}

