﻿using System;
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
                // make a new, bigger array
                T[] newArray = new T[capacity];
                // fill up new array with values from the original (loop?)
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                // have 'items' member variable point to this new array
                items = newArray;
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            bool itemHasBeenRemoved = false;
            // make a new array
            T[] newArray = new T[capacity];
            // use a loop to "fill up" the new array...
            // if the item we're on is NOT the item to remove, and we haven't removed anything yet...
            // otherwise if the item we're on is NOT the item to remove, but we HAVE removed the "item to remove"...
            // otherwise if the item we're on IS the item to remove...
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item) && itemHasBeenRemoved == false)
                {
                    itemHasBeenRemoved = true;
                }
                //else if (items[1].Equals(item) && itemHasBeenRemoved == true)
                //{
                //    newArray[i - 1] = items[i];
                //}
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

        // take first list, cycle through it and add every value to a new list
        // take second list, do the same but add after
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
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

        public static CustomList<T> ZipList(CustomList<T> zippedList)
        {
            CustomList<T> list = new CustomList<T>();
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                T value = list[i];
                newList.Add(value);
                T value2 = zippedList[i];
                newList.Add(value2);
            }
            return newList;
        }
    }
}
