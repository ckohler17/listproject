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

                //create a for loop to put values from items into temp
                //for loop over the items count

            }
          
            items[count] = item;
            //items = temp;
            //items equal to temp
            count++;
        }

    }
}
