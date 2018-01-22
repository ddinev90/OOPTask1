using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Program
    {
        static void Main(string[] args)
        {

            Quadrangle quadrangle = new Quadrangle(
                new int[] { 15, 20 },
                new int[] { 30, 40 },
                new int[] { 3, 20 },
                new int[] { 10, 15 });

            quadrangle.Draw();

            Elipse elise = new Elipse(
                new int[] { 6, 5 },
                new int[] { 2, 2 });

            elise.Draw();

            

            Console.ReadKey();
        }
    }
}
