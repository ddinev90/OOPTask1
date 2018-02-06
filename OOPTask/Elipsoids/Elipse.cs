using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Elipse : IShape
    {

        private double PointAXCoord { get; set; }
        private double PointBXCoord { get; set; }
        private double PointAYCoord { get; set; }
        private double PointBYCoord { get; set; }

        

        public struct FocalPoints
        {
            double x;
            double y;
            public FocalPoints(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }



        public Elipse(double aX, double aY, double bX, double bY)
        {
            FocalPoints focalPointA = new FocalPoints(PointAXCoord = aX, PointAYCoord = aY);
            FocalPoints focalPointB = new FocalPoints(PointBXCoord = bX, PointBYCoord = bY);


        }


        public virtual double SurfaceArea()
        {

            
            return 5;
        }

        public void Draw()
        {
            Console.WriteLine("My shape is {0}", this.GetType().Name);
        }

        public void FocalLength()
        {
            double focalLength = Math.Sqrt(Math.Abs((Math.Pow(PointAXCoord, 2) - Math.Pow(PointBXCoord, 2)) + (Math.Pow(PointAYCoord, 2) - Math.Pow(PointBYCoord, 2))));
            Console.WriteLine("Focal length is: {0}", focalLength);
        }
    }
}
