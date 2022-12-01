namespace Geometry.Figures
{
    /// <summary>
    /// Класс Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Конструктор класса Треугольник
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Сторона не может быть меньше или равна 0");

            if (!(firstSide < secondSide + thirdSide && secondSide < firstSide + thirdSide && thirdSide < secondSide + firstSide))
                throw new ArgumentException("Треугольник не существует");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по трём сторонам
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double Area()
        {
            double semiPerimetr = (FirstSide + SecondSide + ThirdSide) / 2.0;

            return Math.Sqrt(semiPerimetr * (semiPerimetr - FirstSide) * (semiPerimetr - SecondSide) * (semiPerimetr - ThirdSide));
        }

        /// <summary>
        /// Проверка являеться ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            var maxSides = new[] { FirstSide, SecondSide, ThirdSide }.Max();

            return Math.Pow(maxSides, 2) * 2 == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2);
        }
    }
}