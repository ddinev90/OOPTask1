using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    public class Node<T>

    {
        public double data;
        public Node<T> left;
        public Node<T> right;
        public Node(double value)
        {
            this.data = value;
            left = null;
            right = null;
        }
    }
}
