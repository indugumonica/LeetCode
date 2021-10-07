using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class MyQueue<T>
    {
        private T[] data;
        private  int tail =0;
        private int head = 0;
        private int count = 0;
        private int[] input;

        public MyQueue(T[] input)
        {
            data = new T[4];
            for(int i = 0; i < input.Length; i++)
            {
                data[i] = input[i];
                count++;

            }
            tail = input.Length;
            
        }

        public MyQueue()
        {
            data = new T[4];

        }

        private void  GrowArray()
        {
            T[] NewArray = new T[data.Length * 2];
            int iter = 0;
            for(int index = head; index < data.Length; index++)
            {
                NewArray[iter] = data[index];
                iter++;
            }
            if (head <= tail)
            {
                for (int index = 0; index < tail; index++)
                {
                    NewArray[iter] = data[index];
                    iter++;
                }

            }
            
            tail = data.Length;
            head = 0;
            data = NewArray;
            
        }
        
        public void Enqueue(T item)
        {
            if (count == data.Length)
            {
                GrowArray();
            }
            if (tail < data.Length)
            {
                data[tail] = item;
                tail = tail + 1 % data.Length;
                count++;
            }
            else
            {
                tail = 0;
                data[tail] = item;
                tail = tail + 1 % data.Length;
                count++;
            }
            
        }

        public T DeQueue()
        {
            
            if (tail == 0)
            {
                throw new Exception ("there is no data to Dequeue") ;
            }
            T dequeuedElement = data[head];
            data[head] = default(T);
            head=head+1%data.Length;
            count--;
            return dequeuedElement;

        }


    }
}