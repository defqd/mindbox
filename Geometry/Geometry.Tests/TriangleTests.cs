using Geometry.Figures;

namespace Geometry.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(1, 3, 3, 1.479019945774904d), Description("Тест вычисления площади треугольника")]
        [TestCase(20, 10, 20, 96.824583655185421d)]
        [TestCase(54, 12, 60, 294.53522709516432d)]
        public void TriangleAreaTest(double firstSide, double secondSide, double thirdSide, double expected)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            double result = triangle.Area();

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(-1,-1,-1), Description("Некорректные стороны треугольника")]
        [TestCase(0, 0, 0)]
        [TestCase(3,2,1)]
        [TestCase(56,8,7)]
        public void IncorrectTriangleSidesTest(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [TestCase(24, 7, 25, true), Description("Тест прямоугольний треугольник")]
        [TestCase(24, 7, 26, false)]
        public void IsRightTriangleTest(double firstSide, double secondSide, double thirdSide, bool expected)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            bool result = triangle.IsRight();

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}