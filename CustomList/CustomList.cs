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
        private int count;
        public int Count { get { return count; } }

        private int capacity;

        public int Capacity { get { return capacity; } }

        private T[] items;

        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }


        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            count++;
            if (count > capacity)
            {
                capacity += 4;
            }
            items[count - 1] = item;
        }

        public void Remove(T item)
        {
            //need to locate item in array first
            //then make spot at that index what index+1 is??

            for (int i = 0; i < count; i++)
            {
                T newItem = items[i];
                if (newItem == item)
                {
                    int index = i;
                    
                }
            }
            count--;
        }
    }
}
