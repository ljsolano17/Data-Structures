using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListStructure<T>
    {
        private Node<T> head;

        public LinkedListStructure()
        {
            this.head = null;
        }
        public void insertAtStart(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.next = head;
            head = newNode;
        }

        public void insertAtEnd(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> actualNode = head;
                while (actualNode.next != null)
                {
                    actualNode = actualNode.next;
                }
                actualNode.next = newNode;
            }
        }
        public void deleteListNode(T value)
        {
            if(head != null)
            {
                if(head.value.Equals(value))
                {
                    head = head.next;
                }
                else
                {
                    Node<T> actualNode = head;
                    while (!actualNode.next.value .Equals(value)) 
                    {
                        actualNode.next = actualNode.next.next;
                        break;
                    }
                    actualNode = actualNode.next;
                }
            }
        }

        public void printList()
        {
            Node<T> actualNode = head;
            while (actualNode != null)
            {
                T value = actualNode.value;
                Console.WriteLine(value.ToString());

                actualNode = actualNode.next;
            }
            Console.WriteLine();
        }
        public void printVisualList()
        {
            Node<T> actualNode = head;
            while (actualNode != null)
            {
                Console.Write(actualNode.value.ToString());
                if (actualNode.next != null)
                {
                    Console.Write(" -> ");
                }
                actualNode = actualNode.next;
            }
            Console.WriteLine();
        }


    }
}
