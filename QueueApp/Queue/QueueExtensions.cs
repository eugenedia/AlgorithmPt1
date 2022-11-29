using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public static class QueueExtensions
    {
        public static void Print(this Queue<int> queue)
        {
            Console.WriteLine(string.Join(",", queue.ToArray()));
        }
    }
}
