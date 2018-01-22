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
        public int[] sumFoci { get; set; }
       

        public void Draw()
        {
            Console.WriteLine("My shape is Elipse");
            Console.WriteLine("Distance between foci is:");

            foreach (var item in sumFoci)
            {
                Console.WriteLine(item);
            }
            
            
        }

        public Elipse(int[] a, int[] b)
        {
            this.fA = a;
            this.fB = b;
            sumFoci = a.Select((x, index) => x + b[index]).ToArray();

        }
    }
}
