using System;
using System.Linq;
using Library.Interfaces;

namespace Library.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        private readonly double _p;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля", nameof(a));
            }

            if (b <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля", nameof(b));
            }

            if (c <= 0)
            {
                throw new ArgumentException("Сторона должна быть больше нуля", nameof(c));
            }

            if ((a + b > c && b + c > a && c + a > b) == false)
            {
                throw new InvalidOperationException("Невозможно посттроить треугольник");
            }

            _a = a;
            _b = b;
            _c = c;
            _p = (a + b + c) / 2;
        }

        public bool IsRightAngle => HasRightAngle();

        public double CalculateFigure() => Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));

        private bool HasRightAngle() => HasRightAngle(_a, _b, _c);

        private static bool HasRightAngle(params double[] numbers)
        {
            double accumulator = 0;

            double max = numbers.Aggregate((a, b) =>
            {
                if (a > b)
                {
                    accumulator += b * b;
                    return a;
                }

                accumulator += a * a;
                return b;
            });

            return Math.Abs(accumulator - max * max) < double.Epsilon;
        }
    }

}

