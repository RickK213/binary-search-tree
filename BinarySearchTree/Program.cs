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

            Console.WriteLine( myBinarySearchTree.Search(6) );
            Console.ReadKey();
        }
    }
}
