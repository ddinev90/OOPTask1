using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Elipse : IShape
    {
        public int[] fA { get; set; }
        public int[] fB { get; set; }
        public double[] focalLength { get; set; }
       

        public void Draw()
        {
            Console.WriteLine("My shape is Elipse");

            

        }

        public Elipse(int[] a, int[] b)
        {
            this.fA = a;
            this.fB = b;
            

        }

        public void FocalLength()
        {
            focalLength = fA.Select((x, index) => Math.Sqrt(Math.Pow(x, 2) - Math.Pow(fB[index], 2))).ToArray();
            double length = 0;
            for (int i = 0; i < focalLength.Length; i++)
            {
                length += focalLength[i];


            }

            Console.WriteLine("Distance between foci is: {0}", length);

        }

    }
}
