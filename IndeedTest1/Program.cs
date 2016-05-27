using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndeedTest1
{
    class Program
    {
        class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int newData)
            {
                data = newData;
            }
        }
        static void Main(string[] args)
        {
            Node tree = new Node(20);
            tree.left = new Node(10);
            tree.left.left = new Node(8);
            tree.left.right = new Node(12);
            tree.right = new Node(30);
            tree.right.left = new Node(25);
            tree.right.right = new Node(40);


        }

        static int IsPresent(Node root, int testNum)
        {
            //search breadth
            /*check root;
             * if root.left not null
             *  check root.left
             * if root.right not null
             *  check root.right
             *  
             * loop while testNode has child
             *  set child to testNode.Left if not null
             *  
             */
            return 0;

        }
    }
}
