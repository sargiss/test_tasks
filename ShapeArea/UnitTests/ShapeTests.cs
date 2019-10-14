using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeArea;

namespace UnitTests
{
    [TestClass]
    public class ShapeTests
    {
        double precision = Triangle.Precision;

        [TestMethod]
        public void CheckDefaultPrecision()
        {
            Assert.AreEqual(0.0000001, precision);
        }

        [TestMethod]
        public void CircleArea()
        {
            IShape circle = new Circle(10);
            Assert.IsTrue(Math.Abs(314.15926535 - circle.Area()) < precision);
        }

        [TestMethod]
        public void TriangleArea()
        {
            IShape t = new Triangle(5,4,3);
            Assert.IsTrue(Math.Abs(6 - t.Area()) < precision, "area = ", t.Area());
        }

        [TestMethod]
        public void IsRightTrianglePositive()
        {
            var t = new Triangle(5,4,3);
            Assert.IsTrue(t.IsRightTriangle);
        }

        [TestMethod]
        public void IsRightTriangleNegative()
        {
            var t = new Triangle(5, 4, 7.55);
            Assert.IsFalse(t.IsRightTriangle);
        }

        [TestMethod]
        public void ArbitraryShapeArea()
        {
            IShape s = new GeneralShape(_ => 11);
            Assert.AreEqual(11, s.Area());
        }
    }
}
