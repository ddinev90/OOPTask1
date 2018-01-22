using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Triangle : IShape
    {
        public int[] vA { get; set; }
        public int[] vB { get; set; }
        public int[] vC { get; set; }


        public void Draw()
        {
            Console.WriteLine("My shape is Triangle");
        }

        public Triangle(int[] a, int[] b, int[] c)
        {
            this.vA = a;
            this.vB = b;
            this.vC = c;
        }
    }
}
