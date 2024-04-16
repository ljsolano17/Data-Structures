using Queue;
using System;
public class Program
{
    public static void Main(string[] args)
    {
       /* QueueStructure<int> queueStructure = new QueueStructure<int>(10);
        queueStructure.Enqueue(1);
        queueStructure.Enqueue(5);
        queueStructure.Enqueue(2);
        queueStructure.Enqueue(3);
        queueStructure.Enqueue(4);
        

        Console.WriteLine("Dequeue: "+ queueStructure.Dequeue());
        Console.WriteLine("Dequeue: " + queueStructure.Dequeue());
        Console.WriteLine("Dequeue: " + queueStructure.Dequeue());
        Console.WriteLine("Dequeue: " + queueStructure.Dequeue());
        */
       Printer printer = new Printer();
        printer.Print(2);
    }
}
