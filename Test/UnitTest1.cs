using Library.Figures;

namespace Test
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-1)]
        public void InstantiationFailedTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, Math.PI * 4)]
        public void CalculateAreaTest(double radius, double result)
        {
            var circle = new Circle(radius);

            double actual = circle.CalculateFigure();

            Assert.Equal(result, actual);
        }
    }
}