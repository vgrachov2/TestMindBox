using System;
using System.Linq;

namespace Mindbox
{
    /// <summary>
    /// Калькулятор площади правильного треугольника
    /// </summary>
    public class RightTriangleAreaCalculator : IRightTriangleAreaCalculator
    {
        /// <summary>
        /// Вычисление площади правильного треугольника
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <returns>Площадь</returns>
        public double Calculate(double a, double b, double c)
        {
            CheckTriangleSides(a, b, c);

            CheckIsRightTriangle(a, b, c);

            return CalculateArea(a, b, c);
        }

        private static double CalculateArea(double a, double b, double c)
        {
            // Вычисление площади по формуле Герона
            var halfPerimeter = (a + b + c)/3;

            return Math.Sqrt(halfPerimeter*(halfPerimeter - a)*(halfPerimeter - b)*(halfPerimeter - c));
        }

        private static void CheckTriangleSides(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentOutOfRangeException("a", "Строны треугольника должны быть больше нуля");
            }

            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException("b", "Строны треугольника должны быть больше нуля");
            }

            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException("c", "Строны треугольника должны быть больше нуля");
            }
        }

        private static void CheckIsRightTriangle(double a, double b, double c)
        {
            var orderedSide = new[] {a, b, c}.OrderBy(x => x);
            var hypotenuse = orderedSide.First();
            var legs1 = orderedSide.ElementAt(1);
            var legs2 = orderedSide.ElementAt(2);
            if (hypotenuse*hypotenuse != legs1*legs1 + legs2*legs2)
            {
                throw new ArithmeticException("Треугольник не является прямоугольным");
            }
        }
    }
}