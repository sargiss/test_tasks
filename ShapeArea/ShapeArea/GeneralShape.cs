using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class GeneralShape: IShape
    {
        Func<GeneralShape, double> _areaFunc;

        public GeneralShape(Func<GeneralShape, double> areaFunc)
        {
            _areaFunc = areaFunc;
        }

        public double Area()
        {
            return _areaFunc(this);
        }
    }
}
