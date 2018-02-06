using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Quadrangle : Vertice, IShape
    {

        private double SideAXCoord { get; set; }
        private double SideBXCoord { get; set; }
        private double SideAYCoord { get; set; }
        private double SideBYCoord { get; set; }
        private double SideCXCoord { get; set; }
        private double SideDXCoord { get; set; }
        private double SideCYCoord { get; set; }
        private double SideDYCoord { get; set; }


        public  void Draw()
        {
            Console.WriteLine("My shape is {0}", this.GetType().Name);
        }

        public virtual double SurfaceArea()
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            double area = rand.NextDouble();
            return area;
        }

        public Quadrangle(double aX, double aY, double bX, double bY, double cX, double cY, double dX, double dY)  
        {
            Vertices VerticeA = new Vertices(SideAXCoord = aX, SideAYCoord = aY);
            Vertices VerticeB = new Vertices(SideBXCoord = bX, SideBYCoord = bY);
            Vertices VerticeC = new Vertices(SideCXCoord = cX, SideCYCoord = cY);
            Vertices VerticeD = new Vertices(SideDXCoord = dX, SideDYCoord = dY);

        }
        public Quadrangle(double aX, double aY, double bX, double bY, double cX, double cY)
        {
            Vertices VerticeA = new Vertices(SideAXCoord = aX, SideAYCoord = aY);
            Vertices VerticeB = new Vertices(SideBXCoord = bX, SideBYCoord = bY);
            Vertices VerticeC = new Vertices(SideCXCoord = cX, SideCYCoord = cY);
            

        }

        

    }
}
