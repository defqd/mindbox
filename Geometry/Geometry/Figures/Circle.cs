namespace Geometry.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус Круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор класса Круг
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус меньше или равен 0");

            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга по радиусу
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double Area() => Math.PI * Math.Pow(Radius, 2.0);
    }
}