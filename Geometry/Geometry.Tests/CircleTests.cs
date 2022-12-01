using Geometry.Figures;

namespace Geometry.Tests
{
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// Тест вычисления площади круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <param name="expected">Ожидаемое значение</param>
        [TestCase(1, Math.PI)]
        [TestCase(20, 1256.6370614359173d)]
        public void CircleSquareTest(double radius, double expected)
        {
            Assert.That(new Circle(radius).Area(), Is.EqualTo(expected));
        }

        /// <summary>
        /// Тест на радиус равный 0 или отрицательному значению
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        [TestCase(0)]
        [TestCase(-1)]
        public void CircleIncorrectRadiusTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}