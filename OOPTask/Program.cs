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
            tree.Search(tree.root, temp);

            FigureFinder finder = new FigureFinder();
            finder.Finder();

        }
    }
}
