using System;

namespace Day14Queue_usingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region QueueUsingLikedList
            Linked_List_Queue linkedListQueue = new Linked_List_Queue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            Console.WriteLine("------------------------------------------");
            #endregion

            #region QueueUsingLikedList
            Linked_List_Queue linkedListQueue1 = new Linked_List_Queue();
            linkedListQueue1.Enqueue(56);
            linkedListQueue1.Enqueue(30);
            linkedListQueue1.Enqueue(70);
            linkedListQueue1.Display();
            linkedListQueue1.Deque();
            Console.WriteLine("After removing first element Queue is :");
            linkedListQueue1.Display();
            #endregion
        }

    }
}
