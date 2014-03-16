using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox.Test
{
    [TestClass]
    public class RightTriangleAreaCalculatorTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionIfNegativeTriangleSide()
        {
            var calculator = new RightTriangleAreaCalculator();
            calculator.Calculate(-1, -1, 23);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionIfZeroTriangleSide()
        {
            var calculator = new RightTriangleAreaCalculator();
            calculator.Calculate(150, 10, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void ExceptionIfTriangleIsNotRight()
        {
            var calculator = new RightTriangleAreaCalculator();
            calculator.Calculate(150, 10, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void CalculateAreaTest()
        {
            var calculator = new RightTriangleAreaCalculator();
            var result = calculator.Calculate(1, 1, 2);
            Assert.AreEqual(result, 1);
        }
    }
}
