using Geometry.Figures;

namespace Geometry.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [TestCase(1, Math.PI), Description("Тест вычисления площади круга")]
        [TestCase(20, 1256.6370614359173d)]
        public void CircleAreaTest(double radius, double expected)
        {
            var circle = new Circle(radius);

            double result = circle.Area();

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0), Description("Тест на радиус равный 0 или отрицательному значению")]
        [TestCase(-1)]
        public void CircleIncorrectRadiusTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}