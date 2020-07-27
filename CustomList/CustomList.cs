using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public int count;
        public int capacity;

        private T[] items;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            items[0] = item;
            count++;
            capacity = 
        }

        public void Remove(T item)
        {
            count--;
            capacity = 4 * ((count / 4) + 1);
        }
    }
}
