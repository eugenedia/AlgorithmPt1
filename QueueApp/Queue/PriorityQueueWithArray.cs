using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    //Реализация PriorityQueue c помощью массива
    
    public class PriorityQueueWithArray
    {
        private int[] array;

        private int count = 0;

        public PriorityQueueWithArray(int size)
        {
            array = new int[size];
        }


        public void Enqueue(int e)
        {
            if (count == array.Length)
                throw new InvalidOperationException();
            

            int i;

            for(i = count-1; i >= 0; i--)
            {
                if (array[i] > e)
                {
                    array[i + 1] = array[i];
                }

                else
                    break;
                
                    
            }
            array[i + 1] = e;
            count++;
        }

        public override string ToString()
        {
            return String.Join(",", array);
        }
    }
}
