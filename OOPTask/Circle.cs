using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Circle : IShape
    {

        public double[] Radius { get; set; } 

        public double [] Center { get; set; }

        public void Draw()
        {
            Console.WriteLine("A circle has been drawn");
        }

        public Circle(double [] radius, double[] center)
        {
            Radius = radius;
            Center=center;

        }

        public void SurfaceArea()
        {
            double area =  Math.PI * Math.Pow( Math.Sqrt(Math.Pow(Radius[0],2)+ Math.Pow(Radius[1],2)),2);
            
            Console.WriteLine("The circle surface area is {0}",area);
        }

    }
}
