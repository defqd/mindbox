using Geometry.Figures;

namespace Geometry.Tests
{
    [TestFixture]
    public class CircleTests
    {
        /// <summary>
        /// ���� ���������� ������� �����
        /// </summary>
        /// <param name="radius">������ �����</param>
        /// <param name="expected">��������� ��������</param>
        [TestCase(1, Math.PI)]
        [TestCase(20, 1256.6370614359173d)]
        public void CircleSquareTest(double radius, double expected)
        {
            Assert.That(new Circle(radius).Area(), Is.EqualTo(expected));
        }

        /// <summary>
        /// ���� �� ������ ������ 0 ��� �������������� ��������
        /// </summary>
        /// <param name="radius">������ �����</param>
        [TestCase(0)]
        [TestCase(-1)]
        public void CircleIncorrectRadiusTest(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}