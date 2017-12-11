using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST myBinarySearchTree = new BST();
            myBinarySearchTree.Add(8);
            myBinarySearchTree.Add(10);
            myBinarySearchTree.Add(6);
            myBinarySearchTree.Add(8);
            myBinarySearchTree.Add(3);
            myBinarySearchTree.Add(12);
            myBinarySearchTree.Add(99);
            myBinarySearchTree.Add(467);
            myBinarySearchTree.Add(64);
            myBinarySearchTree.Add(11);

            Console.WriteLine( myBinarySearchTree.Search(8) );
            Console.ReadKey();
        }
    }
}
