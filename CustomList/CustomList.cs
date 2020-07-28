using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

        // throw an exception if the index is out of range
        public T this[int i]
        {
            get
            {
                if (i > 0 && i < count)
                {
                    return items[i];
                }
                else 
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (i > 0 && i < count)
                {
                    items[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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
                // make a new, bigger array
                T[] biggerArray = new T[capacity];
                // fill up new array with values from the original (loop?)

                // have 'items' member variable point to this new array
                items = biggerArray;
            }
            items[count - 1] = item;
        }

        public void Remove(T item)
        {
            bool itemHasBeenRemoved = false;
            // make a new array

            // use a loop to "fill up" the new array...
                // if the item we're on is NOT the item to remove, and we haven't removed anything yet...
                // otherwise if the item we're on is NOT the item to remove, but we HAVE removed the "item to remove"...
                // otherwise if the item we're on IS the item to remove...
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {

                    T newItem = items[i];

                }
            }

            // items = // your new array from above

            // only decrement count if you actually removed something
            count--;
        }
    }
}
