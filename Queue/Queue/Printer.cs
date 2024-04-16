using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public  class Printer
    {
        public Printer() { }
        public void Print(int pagesQuantity) 
        {
            QueueStructure<string> queueStructure = new QueueStructure<string> (pagesQuantity);
            Console.WriteLine("Reading document...");
            Console.WriteLine("...");

            Console.WriteLine("Detecting pages");
            for (int i = 1; i<=pagesQuantity; i++)
            {
                Console.WriteLine($"Page {i}");
                queueStructure.Enqueue(("Page "+i).ToString());
            }
            Console.WriteLine("...");
            Console.WriteLine("Printing");
            for(int j = 0;j<pagesQuantity; j++)
            {
                Console.WriteLine(queueStructure.Dequeue());

            }
        }
    }
}
