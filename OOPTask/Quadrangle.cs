using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Quadrangle : IShape
    {
        public int[] vA { get; set; }
        public int[] vB { get; set; }
        public int[] vC { get; set; }
        public int[] vD { get; set; }
        public void Draw()
        {
            Console.WriteLine("My shape is Quadrangle" );
            Console.WriteLine("Side A has coords: ");
            foreach (var coord in vA){
                Console.Write(coord + " " );
            }
            Console.WriteLine("Side B has coords: ");
            foreach (var coord in vB)
            {
                Console.Write(coord + " ");
            }
            Console.WriteLine("Side C has coords: ");
            foreach (var coord in vC)
            {
                Console.Write(coord + " ");
            }
            Console.WriteLine("Side D has coords: ");
            foreach (var coord in vD)
            {
                Console.Write(coord + " ");
            }

        }

        public Quadrangle(int[]a,int[]b,int[]c,int[] d)
        {
            this.vA = a;
            this.vB = b;
            this.vC = c;
            this.vD = d;

        }



    }
}
