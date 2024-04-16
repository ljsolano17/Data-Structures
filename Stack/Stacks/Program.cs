using Stacks;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        StackStructure<int> stack = new StackStructure<int>(10);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine(stack.Count());

        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());

        Console.WriteLine("peek: "+stack.Peek());

        StackStructure<Person> people = new StackStructure<Person>(5);

        Person person = new Person();
        person.Name = "Test";
        person.LastName = "Test";
        person.Age = 15;
        person.Id = 1;
        person.Identification = Guid.NewGuid().ToString();

        people.Push(person);

        Console.WriteLine("Stack People: "+ people.Pop().Name);

        //Word
        Console.WriteLine("Add word to stack with enter");
        Console.WriteLine("remove word with cntrl+z");

        StackStructure<string> stackStructure = new StackStructure<string>(10);

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if(keyInfo.Modifiers == ConsoleModifiers.Control && keyInfo.Key == ConsoleKey.Z)
            {
                if(stackStructure.Count() > 0)
                {
                    string undoWord = stackStructure.Pop();
                    Console.WriteLine("Undo last word: "+undoWord);
                }
                else
                {
                    Console.WriteLine("No more words in stack");
                }

            }else if(keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\nAdd a word");
                string word = Console.ReadLine();
                stackStructure.Push(word);
                Console.WriteLine("Word has been added successfully!");
            }else if(keyInfo.Key == ConsoleKey.C)
            {
                Console.WriteLine(stackStructure.Peek());
            }
        }

    }
}