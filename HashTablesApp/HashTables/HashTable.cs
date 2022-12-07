using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    //Реализация HashTable
  public class HashTable
    {
        private LinkedList<Entry> [] entries;

        public HashTable(int size)
        {
            entries = new LinkedList<Entry>[size];
        }

        private class Entry
        {
            public int key;
            public  string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }


        public void Put(int key, string value)
        {
            int bucket = key % entries.Length;

            if (entries[bucket] == null)
                entries[bucket] = new LinkedList<Entry>();

            else                
             foreach (var entry in entries[bucket])
                {
                    if(entry.key == key)
                    {
                        entry.value = value;
                        return;
                    }
                }

            entries[bucket].AddLast(new Entry(key, value));
        }

        public string Get(int key)
        {
            int bucket = key % entries.Length;

            if (entries[bucket] == null)
                throw new KeyNotFoundException();

            foreach (var entry in entries[bucket])
            {
                if (entry.key == key)
                    return entry.value;
            }

            throw new KeyNotFoundException();
        }


        public void Remove(int key)
        {
            int bucket = key % entries.Length;

            if (entries[bucket] == null)
                throw new KeyNotFoundException();

            foreach (var entry in entries[bucket])
            {
                if (entry.key == key)
                {
                    entries[bucket].Remove(entry);
                    return;
                }
            }
        }
    }
}
