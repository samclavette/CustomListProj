using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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
                if (i >= 0 && i < count)
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
                if (i >= 0 && i < count)
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
            if (count == capacity)
            {
                capacity += 4;
                
                T[] newArray = new T[capacity];
                
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }                
                items = newArray;
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            bool itemHasBeenRemoved = false;
            
            T[] newArray = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item) && itemHasBeenRemoved == false)
                {
                    itemHasBeenRemoved = true;
                }
                else if (items[i].Equals(item) == false && itemHasBeenRemoved == false)
                {
                    newArray[i] = items[i];
                }
                else if (itemHasBeenRemoved == true)
                {
                    newArray[i - 1] = items[i];
                }
            }
            if (itemHasBeenRemoved == true)
            {
                count--;
            }
            items = newArray;
        }

        public override string ToString()
        {
            string newString = "";

            for (int i = 0; i < count; i++)
            {
                T value = items[i];
                newString += value;
            }
            return newString;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> list = new CustomList<T>();
            //foreach (T item in listOne)
            //{
            //    list.Add(item);
            //}
            for (int i = 0; i < listOne.Count; i++)
            {
                T value = listOne[i];
                list.Add(value);
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                T value = listTwo[i];
                list.Add(value);
            }
            return list;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                T value = listOne[i];
                list.Add(value);
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                T value = listTwo[i];
                list.Remove(value);
            }
            return list;
        }

        public CustomList<T> ZipList(CustomList<T> zippedList)
        {
            CustomList<T> newList = new CustomList<T>();
            int iterationNumber = 0;
            if (count >= zippedList.Count)
            {
                iterationNumber = count;
            }
            else
            {
                iterationNumber = zippedList.Count;
            }
            for (int i = 0; i < iterationNumber; i++)
            {
                if (i < count)
                {
                    T value = items[i];
                    newList.Add(value);
                }
                
                if (i < newList.count)
                {
                    T value2 = zippedList[i];
                    newList.Add(value2);
                }
            }
            return newList;
        }
    }
}
