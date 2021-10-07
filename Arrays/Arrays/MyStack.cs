using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MyStack<T>
    {
        private T[] data;
        private int index;
        

        public MyStack()
        {
            data = new T[10];
        }

        public MyStack(T[] input)
        {
            data = new T[10];
            for(int i = 0; i < input.Length; i++)
            {
                data[i] = input[i];
            }
            index = input.Length;
        }

        private void GrowArray()
        {
            T[] newArray = new T[data.Length * 2];
            for(int iter = 0; iter < data.Length; iter++)
            {
                newArray[iter] = data[iter];
            }
            index = data.Length;
            data = newArray;
            
        }
        public void push(T item)
        {
            if (index >= data.Length)
            {
                GrowArray();
            }
            data[index] = item;
            index = index + 1;
        }

        public T pop()
        {
            if (index == 0)
            {
                throw new Exception("there are no elements to pop");
            }

            T output = data[index - 1];
            index = index - 1;
            return output;
        }
    }
}
