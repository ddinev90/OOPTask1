using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    public class Tree<T> where T : IShape
    {
        
        public Node<double> root;
        static int count;
        public Tree()
        {
            root = null;
        }
        public Node<double> AddNode(IShape shape)
        {
            Node<double> temp = new Node<double>(shape.SurfaceArea());
            if (root == null)
                root = temp;
            count++;
            return temp;
            
        }

        public void Insert(Node<double> root, Node<double> newNode)
        {
            while (root != null)
            {
                if (newNode.data > root.data)
                {
                    if (root.right == null)
                    {
                        root.right = newNode;
                        break;
                    }
                    root = root.right;
                }
                else
                {
                    if (root.left == null)
                    {
                        root.left = newNode;
                        break;
                    }
                    root = root.left;
                }
            }
        }

       
        public void InOrder(Node<double> root)
        {
            if (root != null)
            {
                InOrder(root.left);
                Console.Write(root.data  + " ");
                InOrder(root.right);
            }

        }

        public void Search(Node<double> root, double temp)
        {
            
            if (root != null)
            {
                Search(root.left,temp);
                if (Math.Round(root.data) == Math.Round(temp))
                {
                    Console.WriteLine("Success"); 
                }
                Search(root.right,temp);
            }

        }

    }
    
}
