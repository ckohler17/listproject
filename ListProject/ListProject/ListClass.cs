using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ListProject 
{
    public class CustomList<T> :  IEnumerable
    {
        private int count;
        private int capacity;
        private T[] items;        

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        } 
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
            capacity = 4;
            count = 0;
            items = new T[capacity];

        }
        public void Add(T item)
        {
            T[] temp = null;
            if (count == capacity)
            {
                capacity *= 2;
                temp = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            T[] temp;
            temp = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (item.Equals(items[i]))
                {
                    j--;
                }
                else
                {
                    temp[j] = items[i];
                }
            }
            items = temp;
            count--;
        }
        public override string ToString()
        {
            string value = "";
            for (int i = 0; i < count; i++)
            {
                value += items[i].ToString();
            }
            return value;
        }

        public IEnumerator GetEnumerator()
        {
            for( int index = 0; index < items.Length; index++)
            {
                yield return items[index];
            }
            yield return "No more items.";
        }

        public static CustomList<T> operator + (CustomList<T>list1, CustomList<T>list2)
        {
            CustomList<T> list3 = new CustomList<T>();
            for (int i = 0; i < list1.count; i++){
                list3.Add(list1[i]);
            }
            for (int i =0; i < list2.count; i++)
            {
                list3.Add(list2[i]);
            }
            return list3;
        }
        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {            
            CustomList<T> list3 = new CustomList<T>();            
            for (int i = 0; i < list1.count; i++)
            {
                bool isEqual = false;
                for (int j = 0; j < list2.count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        isEqual = true;
                    } else if( isEqual == false && j == list2.count-1)
                    {
                        list3.Add(list1[i]);
                    }
                }            
            }            
            return list3;
        }

    }
}
