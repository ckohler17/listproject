using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    public class CustomList<T>
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



    }
}
