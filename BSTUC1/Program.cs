using System;

namespace BSTUC1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.Display();
        }
    }
}