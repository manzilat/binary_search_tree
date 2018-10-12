using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{

    public class Node<T> where T : IComparable
    {
        T data;
        Node<T> left = null;
        Node<T> right = null;

        public Node() { }
        public Node(T data) : this(data, null, null) { }
        public Node(T data, Node<T> left, Node<T> right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }

        public Node<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }

        public void Insert(Node<T> node)
        {
            if (Value == null)
            {
                Value = node.data;
                Right = node.Right;
                Left = node.Left;

                return;
            }

            if (node.data.CompareTo(Value) <= 0)
            {
                Left.Insert(node);
                return;
            }

            Right.Insert(node);
        }


    }
}