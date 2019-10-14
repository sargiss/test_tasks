using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Triangle : IShape
    {
        public static double Precision = 0.0000001;

        double[] _legs;
        double? _area;

        public Triangle(double a, double b, double c)
        {
            _legs = new double[] { a, b, c };
            Array.Sort(_legs);

            if (_legs[0] <= 0)
                throw new ArgumentException("expected all legs > 0");
            if (_legs[0] + _legs[1] <= _legs[2])
                throw new Exception("not triangle");
        }

        public double Area()
        {
            if (!_area.HasValue)
            {
                var p = _legs.Sum() / 2;
                _area = Math.Sqrt(p * (p - _legs[0]) * (p - _legs[1]) * (p - _legs[2]));
            }
            return _area.Value;
        }

        public bool IsRightTriangle => Math.Abs(Area() - (_legs[0] * _legs[1] / 2)) < Precision;
    }
}
