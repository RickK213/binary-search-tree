﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BST
    {
        //member variables
        Node head = null;

        //constructor
        public BST()
        {

        }

        //member methods
        public void Add(int item)
        {
            Node node = new Node(item);
            if (head == null)
            {
                head = node;
                return;
            }
            Node current = head;
            bool nodeAdded = false;
            while ( !nodeAdded )
            {
                if (item < current.data)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current.left = node;
                        nodeAdded = true;
                    }
                }
                else if (item > current.data)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                    }
                    else
                    {
                        current.right = node;
                        nodeAdded = true;
                    }
                }
                else
                {
                    nodeAdded = true;
                }
            }
        }

        public string Search(int searchItem)
        {
            if ( searchItem == head.data )
            {
                return "Head";
            }
            string searchPath = "";
            Node current = head;
            bool nodeFound = false;
            while (!nodeFound)
            {
                if (searchItem < current.data)
                {
                    searchPath += "Left ";
                    if (current.left != null)
                    {
                        current = current.left;
                    }
                    else
                    {
                        if (searchItem != current.data)
                        {
                            return "Not found";
                        }
                        nodeFound = true;
                    }
                }
                else if (searchItem > current.data)
                {
                    searchPath += "Right ";
                    if (current.right != null)
                    {
                        current = current.right;
                    }
                    else
                    {
                        if (searchItem != current.data)
                        {
                            return "Not found";
                        }
                        nodeFound = true;
                    }
                }
                else
                {
                    nodeFound = true;
                }
            }
            return searchPath;
        }
    }
}
