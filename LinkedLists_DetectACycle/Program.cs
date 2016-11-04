using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists_DetectACycle
{
/*
A linked list is said to contain a cycle if any node is visited more than once 
while traversing the list.

Complete the function provided in the editor below. It has one parameter: a pointer to a 
Node object named that points to the head of a linked list. Your function must return a 
boolean denoting whether or not there is a cycle in the list. If there is a cycle, 
return true; otherwise, return false.
*/

    class Node
    {
        public Node next = null;
        public int data = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node one = new Node() {data = 1};
            Node two = new Node() { data = 2 };
            Node three = new Node() { data = 3 };


            Console.WriteLine(IsCycle(one));
            Node cycleHead = one;
            cycleHead.next = two;
            cycleHead.next.next = three;
            cycleHead.next.next.next = cycleHead.next;

            Console.WriteLine(IsCycle(cycleHead));


            Console.ReadKey();
        }

        static bool IsCycle(Node head)
        {
            //add nodes to a list to be searched as you walk list
            List<Node> visited = new List<Node>() {head};
            //if you hit null, can't be circular
            while (head.next != null)
            {
                head = head.next;
                //if circular would be infinite loop so verify haven't
                //visited node
                if (visited.Contains(head))
                {
                    return true;
                }
                else
                {
                    visited.Add(head);
                }
            }
            return false;
        }
    }
}
