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
            
            if (count == 0)
            {
                array[0] = e;
                count++;
                return;
            }
                

            for(int i = count-1; i >= 0; i--)
            {
                if (array[i] > e)
                {
                    array[i + 1] = array[i];
                    if (i == 0)
                        array[0] = e;
                }

                else
                {
                    array[i + 1] = e;
                    break;
                }
                    
            }
            count++;
        }

        public override string ToString()
        {
            return String.Join(",", array);
        }
    }
}
