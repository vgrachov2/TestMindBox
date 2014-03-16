using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    /// <summary>
    /// Калькулятор площади правильного треугольника
    /// </summary>
    public interface IRightTriangleAreaCalculator
    {
        /// <summary>
        /// Вычисление площади правильного треугольника
        /// </summary>
        /// <param name="a">Сторона треугольника</param>
        /// <param name="b">Сторона треугольника</param>
        /// <param name="c">Сторона треугольника</param>
        /// <returns>Площадь</returns>
        double Calculate(double a, double b, double c);
    }
}
