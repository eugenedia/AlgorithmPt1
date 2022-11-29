using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Node node1 = new Node();
            node1.value = 1;

            Node node2 = new Node();
            node2.value = 2;

            Node node3 = new Node();
            node3.value = 3;

            Node node4 = new Node();
            node4.value = 4;

            list.AddFirst(node1);
            list.AddFirst(node2);
            list.AddFirst(node3);
            list.AddLast(node4);

            list.Print();
            
            list.DeleteFirst();
            list.Print();

            Node node5 = new Node();
            node5.value = 5;
            list.AddLast(node5);
            list.Print();

            list.DeleteLast();
            list.Print();

            Console.WriteLine("Does list contains 4 " + list.Contains(4));

            int element = 3;

            list.AddLast(node3);

            list.Print();

            var array = list.ToArray();

            Console.WriteLine($"Index of {element} is {list.IndexOf(element)}");

            //list.Reverse();
            //list.Print();

            list.Reverse2();
            
            list.Print();

            Console.WriteLine($"Nth node from end = {list.NthNodeFromEnd(1)}");

            LinkedList list1 = new LinkedList();
            list1.NthNodeFromEnd(10);
        }
    }
}
