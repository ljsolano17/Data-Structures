using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SortedLinkedList
    {
        private NodeIG head;
        public SortedLinkedList()
        {
            head = null;
        }

        public void InsertList(IGPost post)
        {
            NodeIG newNode = new NodeIG(post);
            if (head == null || newNode.value.timestamp <= head.value.timestamp)
            {
                newNode.next = head;
                head = newNode;

            }
            else
            {
                NodeIG actualNode = head;
                while(actualNode.next != null && actualNode.next.value.timestamp<newNode.value.timestamp)
                {
                    actualNode = actualNode.next;


                }
                newNode.next = actualNode.next;
                actualNode.next = newNode;
            }
        }
        public void InsertListSortedByLikes(IGPost post)
        {
            NodeIG newNode = new NodeIG(post);
            if (head == null || newNode.value.likes <= head.value.likes)
            {
                newNode.next = head;
                head = newNode;

            }
            else
            {
                NodeIG actualNode = head;
                while (actualNode.next != null && actualNode.next.value.likes < newNode.value.likes)
                {
                    actualNode = actualNode.next;


                }
                newNode.next = actualNode.next;
                actualNode.next = newNode;
            }
        }
        public void printList()
        {
            NodeIG actualNode = head;
            while(actualNode!= null)
            {
                Console.WriteLine(actualNode.value+" ");
                actualNode = actualNode.next;
            }
            Console.WriteLine();
        }

    }
}
