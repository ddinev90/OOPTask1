using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Parallelogram : Quadrangle, IShape
    {

        public Parallelogram(double aX, double aY, double bX, double bY, double cX, double cY, double dX, double dY) : base(aX, aY, bX, bY, cX, cY, dX, dY)
        {
            dX = cX - bX + aX;
            dY = cY - bY + aY;
            Console.Write("The missing vertice X coord is {0}" + " and the missing Y coord is {1} ",dX,dY, Environment.NewLine);
            
        }
    }
}
