using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTUC1
{
    public class BinarySearchTree<T> where T : IComparable<T>

    {
        public T data;
        public BinarySearchTree<T> left;
        public BinarySearchTree<T> right;
        public BinarySearchTree(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        int leftIndex = 0, rightIndex = 0;
        public void AddNode(T Value)
        {
            T NodeValue = this.data;
            if(NodeValue.CompareTo(Value) >  0 )
            {
                if (this.left != null)
                    this.left = new BinarySearchTree<T>(Value);
                else
                    this.left.AddNode(Value);
            }
            else
            {
                if (this.right == null)
                    this.right = new BinarySearchTree<T>(Value);
                else
                    this.right.AddNode(Value);
            }
        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftIndex++;
                this.left.Display();
            }
            Console.WriteLine(this.data);
            if(this.right != null)
            {
                this.rightIndex++;
                this.right.Display();
            }
        }
    }
}
