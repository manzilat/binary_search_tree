using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinaryTree<T> where T : IComparable
    {
        Node<T> root;
        public BinaryTree()
        {
            root = null;
        }
        public Node<T> Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }

        }
        public virtual void Clear()
        {
            root = null;
        }

        public void Insert(T value)
        {
            var Node = new Node<T>(value);
            Insert(Node);
        }
        public void Insert(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                return;
            }

            // Insert(node, Root);
        }

    }
}
