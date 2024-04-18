using LinkedList;
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //Simulating social network feed
        IGPost iGPost = new IGPost()
        {
            id = 1,
            author = "Luis",
            caption = "caption example...",
            image = "image1",
            likes = 4555,
            timestamp = DateTime.Now.AddMonths(1)
        };
        IGPost iGPost2 = new IGPost()
        {
            id = 2,
            author = "Carlos",
            caption = "caption example...",
            image = "image2",
            likes = 250,
            timestamp = DateTime.Now.AddDays(5)
        };
        IGPost iGPost3 = new IGPost()
        {
            id = 3,
            author = "Esteban",
            caption = "caption example...",
            image = "image3",
            likes = 266,
            timestamp = DateTime.Today.AddDays(1)
        };

        /*

        LinkedListStructure<IGPost> list = new LinkedListStructure<IGPost>();

        list.insertAtStart(iGPost);
        list.insertAtStart(iGPost2);
        list.insertAtEnd(iGPost3);


        list.printList();
        Console.WriteLine("---");
        list.printVisualList();
        Console.WriteLine("--Delete--");
        
        //list.deleteListNode(iGPost2);
        list.printVisualList();*/

        /*  LinkedListStructure<int> list2 = new LinkedListStructure<int>();

          list2.insertAtStart(2);
          list2.insertAtStart(3);
          list2.insertAtStart(4);


          list2.printList();*/
        //Sorted List

        SortedLinkedList sortedLinkedList = new SortedLinkedList();
        sortedLinkedList.InsertListSortedByLikes(iGPost);
        sortedLinkedList.InsertListSortedByLikes(iGPost2);
        sortedLinkedList.InsertListSortedByLikes(iGPost3);
        sortedLinkedList.printList(); 
    }
}