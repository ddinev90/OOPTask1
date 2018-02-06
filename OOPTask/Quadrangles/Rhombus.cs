using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Rhombus : Parallelogram, IShape
    {
        public Rhombus(double aX, double aY, double bX, double bY, double cX, double cY) : base(aX, aY, bX, bY, cX, cY)
        {
            double dX = cX - bX + aX;
            double dY = cY - bY + aY;
            Console.Write("The missing vertice X coord is {0}" + " and the missing Y coord is {1} ", dX, dY, Environment.NewLine);

        }
        public override double SurfaceArea()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            double area = rand.NextDouble();
            return area;
        }
    }
}
