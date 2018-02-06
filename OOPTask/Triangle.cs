using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Triangle : Vertice, IShape
    {
        private double SideAXCoord { get; set; }
        private double SideBXCoord { get; set; }
        private double SideAYCoord { get; set; }
        private double SideBYCoord { get; set; }
        private double SideCXCoord { get; set; }
        private double SideCYCoord { get; set; }

        

        public void Draw()
        {
            
        }

        public Triangle(double aX, double aY, double bX, double bY, double cX, double cY)
        {
            Vertices VerticeA = new Vertices(SideAXCoord = aX, SideAYCoord = aY);            
            Vertices VerticeB = new Vertices(SideBXCoord = bX, SideBYCoord = bY);
            Vertices VerticeC = new Vertices(SideCXCoord = cX, SideCYCoord = cY);

        }

        public  double  SurfaceArea()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            double area = rand.NextDouble();
            return area;
        }

    }
}
