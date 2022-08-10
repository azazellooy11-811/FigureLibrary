using System;
namespace Library.Interfaces
{
    public interface IClient
    {
        double SquareCircle(double radius);

        double SquareTriangle(double a, double b, double c);

        double CalculateFigure(IFigure figure);

        bool IsRightTriangle(double a, double b, double c);
    }
}

