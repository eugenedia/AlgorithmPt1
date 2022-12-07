using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.Insert(20);
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(6);
            tree.Insert(14);
            tree.Insert(3);
            tree.Insert(8);
            tree.Insert(24);
            tree.Insert(26);

            Console.WriteLine($"Find 3: {tree.Find(3)}" ); 
            Console.WriteLine($"Find 4: {tree.Find(4)}" );

            Console.WriteLine("TraversePreOrder");
            tree.TraversePreOrder();

            Console.WriteLine("TraverseInOrder");
            tree.TraverseInOrder();

            Console.WriteLine("TraversePostOrder");
            tree.TraversePostOrder();

            Console.ReadLine();
        }
    }
}
