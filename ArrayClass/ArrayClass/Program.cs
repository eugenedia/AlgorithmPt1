using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    /// <summary>
    /// Реализация динамического массива
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            numbers.Insert(20);
            numbers.Insert(30);
            numbers.Insert(50);
            numbers.Insert(60);

            numbers.Print();

            Console.WriteLine(numbers.IndexOf(60));

            numbers.RemoveAt(2);
            numbers.Print();
            numbers.RemoveAt(0);
            numbers.Print();

            Console.WriteLine(numbers.IndexOf(60));
        }
    }
}
