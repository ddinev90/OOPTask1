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



            Quadrangle quadrangle = new Quadrangle(4,6,2,3,2,5,3,4);

            

            quadrangle.Draw();

            Elipse elipse = new Elipse(15, 20, 30, 10);

            elipse.Draw();

            Circle circle = new Circle(5,2,3,5);

            circle.Draw();

            elipse.FocalLength();
            circle.SurfaceArea();

            Parallelogram parallelogram = new Parallelogram(4, 3, 2, 4, 5, 6, 0, 0);

            Square square = new Square(3, 4, 5, 6, 7, 8, 0, 0);
            


            Console.ReadKey();
        }
    }
}
