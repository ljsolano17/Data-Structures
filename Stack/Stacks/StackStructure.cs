using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class StackStructure<T> 
    {
        private T[] elements;
        private int top;
        public StackStructure(int size) 
        { 
            elements = new T[size];//define the size of the stack
            top = -1;//Cause as soon as first item is inserted in the stack this one goes to 0, which is the first position of the stack
        
        }
        /// <summary>
        /// push a new item inside the stack
        /// </summary>
        /// <param name="item">can be any class</param>
        public void Push(T item)
        {
            try
            {
                if (top == elements.Length)
                {
                    Console.WriteLine("The stack is full");
                }
                top++;
                elements[top] = item;
                //Console.WriteLine($"The element {item} has been pushed into the stack");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            

        }
        /// <summary>
        /// Pops the last item out of the stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if(top == -1 )
            {
                Console.WriteLine("The stack is empty");
            }
            T item = elements[top];//asign the tiem inside the stack to a new item which its datatype is T, any class
            top--;//reduce the stack size, making now the top item the one b4 the returned
            return item;
        }
        /// <summary>
        /// returns the last item, but doesnt takes  it away of the stack, just prints it
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("The stack is empty");
                return default(T);
            }
            else
            {
                T item = elements[top];
                return item;
            }
            
            

        }
        /// <summary>
        /// Count the amount of items inside the stack
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return top + 1;
        }
    }
}
