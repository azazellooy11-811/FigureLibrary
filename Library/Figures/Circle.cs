using System;
using Library.Interfaces;

namespace Library.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public  Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля", nameof(radius));
            }

            _radius = radius;
        }

        public double CalculateFigure() => Math.PI * _radius * _radius;
    }
}

