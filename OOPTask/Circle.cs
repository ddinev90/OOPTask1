using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Circle : Elipse, IShape
    {

        public double RadiusXCoord { get; set; }
        public double RadiusYCoord { get; set; }
        public double CenterXCoord { get; set; }
        public double CenterYCoord { get; set; }

        public Circle(double aX, double aY, double bX, double bY) : base(aX, aY, bX, bY)
        {

            RadiusXCoord = aX;
            RadiusYCoord = aY;
            CenterXCoord = bX;
            CenterYCoord = bY;

        }

        public override double  SurfaceArea()
        {
            double radiusLength = Math.Sqrt(Math.Abs((Math.Pow(RadiusXCoord, 2) - Math.Pow(CenterXCoord, 2)) + (Math.Pow(RadiusYCoord, 2) - Math.Pow(CenterYCoord, 2))));
            double area = Math.PI * Math.Pow(radiusLength, 2);
            return area;
        }
    }
}
