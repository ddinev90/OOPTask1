using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Rhombus : Parallelogram, IShape
    {
        public Rhombus(double aX, double aY, double bX, double bY, double cX, double cY, double dX, double dY) : base(aX, aY, bX, bY, cX, cY, dX, dY)
        {
        }
    }
}
