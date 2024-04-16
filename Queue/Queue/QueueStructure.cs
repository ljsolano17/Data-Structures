using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueStructure<T>
    {
        private T[] elements;
        private int front;
        private int rear;
        private int size;
        private int capacity;


        public QueueStructure(int capacity) 
        { 
            elements = new T[capacity];
            front = 0;
            rear = -1;
            size = 0;
            this.capacity = capacity;
        }
        public bool isFull()
        {
            return size == capacity;
        }
        public bool isEmpty()
        {
            return size == 0;
        }
        public void Enqueue(T elements)
        {
            if (isFull())
            {
                Console.WriteLine("No space in queue!");
            }
          
            rear++;
            this.elements[rear] = elements;
            size++;

        }
        public T Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            T elements = this.elements[front];

            front++;
            size--;

            return elements;
        }
        /*
        public void Clear() 
        { 
        
        }

        public T Contains()
        {
         
        }*/

    }
}
