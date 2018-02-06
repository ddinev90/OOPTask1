using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class FigureFinder : Vertice
    {
        public void Finder()
        {

          
            double pointAx, pointAy, pointBx, pointBy, pointCx, pointCy, pointDx, pointDy;
            Console.WriteLine("Enter the X and Y of the points defining a quadrangle :");

            pointAy = double.Parse(Console.ReadLine().ToString());
            pointBx = double.Parse(Console.ReadLine().ToString());
            pointAx = double.Parse(Console.ReadLine().ToString());
            pointBy = double.Parse(Console.ReadLine().ToString());
            pointCx = double.Parse(Console.ReadLine().ToString());
            pointCy = double.Parse(Console.ReadLine().ToString());
            pointDx = double.Parse(Console.ReadLine().ToString());
            pointDy = double.Parse(Console.ReadLine().ToString());

            double slopeAB = (pointBy - pointAy) / (pointBx - pointAx);
            double slopeCD = (pointDy - pointCy) / (pointDx - pointCx);
            double slopeAD = (pointDy - pointAy) / (pointDx - pointAx);
            double slopeBC = (pointCy - pointBy) / (pointCx - pointBx);
            double slopeAC = (pointCy - pointAy) / (pointCx - pointAx);
            double slopeBD = (pointDy - pointBy) / (pointDx - pointBx);
            double diagonalACLength = Math.Sqrt(Math.Pow((pointBx - pointAx), 2) + Math.Pow((pointCy - pointAy), 2));
            double diagonalBDLength = Math.Sqrt(Math.Pow((pointDx - pointBx), 2) + Math.Pow((pointDy - pointBy), 2));

            if (slopeAB == slopeCD && slopeAD == slopeBC) //parallelogram
            {

                if (slopeAB == slopeCD && slopeAD == slopeBC && slopeAB * slopeAD == -1) // rectangle
                {
                    if (slopeAB == slopeCD && slopeAD == slopeBC && slopeAB * slopeAD == -1 && slopeAC * slopeBD == -1) //square
                    {
                        Square squicky = new Square(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy);
                        squicky.Draw();
                        return;
                    }
                    Rectangle rect = new Rectangle(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy);
                    rect.Draw();
                    return;

                }

                if (slopeAB == slopeCD && slopeAD == slopeBC && slopeAC * slopeBD == -1) // rhombus
                {
                    if (diagonalACLength == diagonalBDLength) //square
                    {
                        Square squicky = new Square(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy);
                        squicky.Draw();
                        return;
                    }
                    Rhombus rhom = new Rhombus(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy);
                    rhom.Draw();
                    return;
                }
                Parallelogram para = new Parallelogram(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy);
                para.Draw();
                return;

            }
            else// random quadrangle
            {
                Quadrangle quady = new Quadrangle(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy, pointDx, pointDy);
                quady.Draw();
            }


        }
    }
}
