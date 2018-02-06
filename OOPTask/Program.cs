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



            Square alpha = new Square(5, 4, 3, 2, 1, 9);
            Circle bravo = new Circle(2, 4, 6, 7);
            Triangle delta = new Triangle(1, 3, 4, 5, 7, 2);
            Elipse gamma = new Elipse(12, 3, 4, 1);

            Square ypsilon = new Square(5, 3, 2, 1, 5, 6);



            Tree<IShape> tree = new Tree<IShape>();
            tree.Insert(tree.root, tree.AddNode(alpha));
            tree.Insert(tree.root, tree.AddNode(bravo));
            tree.Insert(tree.root, tree.AddNode(delta));
            tree.Insert(tree.root, tree.AddNode(gamma));
            tree.Insert(tree.root, tree.AddNode(ypsilon));
            tree.InOrder(tree.root);
            double temp = double.Parse(Console.ReadLine());
            tree.Search(tree.root,temp);
           



            

                double pointAx, pointAy, pointBx, pointBy, pointCx, pointCy, pointDx, pointDy;

                Console.WriteLine("Enter the X and Y of the points defining a quadrangle :");

                pointAx = double.Parse(Console.ReadLine().ToString());
                pointAy = double.Parse(Console.ReadLine().ToString());
                pointBx = double.Parse(Console.ReadLine().ToString());
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
                 double diagonalACLength = Math.Sqrt(Math.Pow((pointBx-pointAx),2) + Math.Pow((pointCy-pointAy),2));
                 double diagonalBDLength = Math.Sqrt(Math.Pow((pointDx - pointBx), 2) + Math.Pow((pointDy - pointBy), 2));

                if(slopeAB==slopeCD && slopeAD==slopeBC) //parallelogram
                 {

                    if(slopeAB == slopeCD && slopeAD == slopeBC && slopeAB * slopeAD == -1) // rectangle
                    {
                        if(slopeAB == slopeCD && slopeAD == slopeBC && slopeAB * slopeAD == -1 && slopeAC * slopeBD == -1) //square
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
                        if (diagonalACLength==diagonalBDLength) //square
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

                } else// random quadrangle
                 {
                     Quadrangle quady = new Quadrangle(pointAx, pointAy, pointBx, pointBy, pointCx, pointCy, pointDx, pointDy);
                     quady.Draw();
                 }
    

        }
    }
}
