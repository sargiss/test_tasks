using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class Circle : IShape
    {
        double _r;

        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentException(nameof(r), "expected r > 0");
            _r = r;
        }

        public double Area()
        {
            return Math.PI * _r * _r;
        }
    }
}
