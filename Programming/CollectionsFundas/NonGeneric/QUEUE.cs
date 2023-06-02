using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.NonGeneric
{
    public class QUEUE
    {
        // How to Create a Queue and Add Elements 
        static void Mawin(string[] args)
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            //Printing the queue items using foreach loop
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
    class QUEUE1
    {
        //How to Remove Elements from the Queue Collection
        static void Majin(string[] args)
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            //Printing the queue items using foreach loop
            Console.WriteLine($"All Queue Elements: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            //Removing and Returning an item from the queue using the Dequeue method
            Console.WriteLine($"\n\nDeleted Element: {queue.Dequeue()}");
            //Printing item after removing the first added item
            Console.WriteLine($"\nAll Queue Elements After Deletion: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            //Printing Items After Clearing the Queue
            queue.Clear();
            Console.WriteLine($"\n\nQueue Elements After Clear Operation: Count {queue.Count}");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
    class QUEUE2
    {
        //How to get the First Element of the Queue Collection
        static void Maixn(string[] args)
        {
            // Creating a Queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            // Fetch First Element of Queue Using Dequeue method
            Console.WriteLine($"First Element of Queue is {queue.Dequeue()}");
            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            // Fetch the topmost element from Queue Using Peek method
            Console.WriteLine($"First Element of Queue is {queue.Peek()}");
            Console.WriteLine($"Total Elements present in Queue : {queue.Count}");
            Console.ReadKey();
        }
    }
    class QUEUE3
    {
        //How to Check Whether an Element Exists or not in the Queue Collection
        static void Mafyin(string[] args)
        {
            // Creating a Queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            queue.Enqueue('A');
            Console.WriteLine("All Elements of Queue");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nChecking if the element Hello is present in the queue or not");
            // Checking if the element Hello is present in the Stack or not
            if (queue.Contains("Hello"))
            {
                Console.WriteLine("Element Hello is found");
            }
            else
            {
                Console.WriteLine("Element Hello is not found");
            }
            if (queue.Contains("World"))
            {
                Console.WriteLine("Element World is found");
            }
            else
            {
                Console.WriteLine("Element World is not found");
            }
            Console.ReadKey();
        }
    }
    class QUEUE4
    {
        static void Maiun(string[] args)
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Creating a clone queue using Clone method
            Queue cloneQueue = (Queue)queue.Clone();
            Console.WriteLine("\nCloned Queue Elements:");
            foreach (var item in cloneQueue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class QUEUE5
    {
        //How to copy a queue to an existing array
        static void Masin(string[] args)
        {
            //Creating a queue collection
            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(101);
            queue.Enqueue("Hello");
            queue.Enqueue(3.14f);
            queue.Enqueue(true);
            queue.Enqueue(67.8);
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Queue Elements:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            //Copying the queue to an object array
            object[] queueCopy = new object[5];
            queue.CopyTo(queueCopy, 0);
            Console.WriteLine("\nQueue Copy Array Elements:");
            foreach (var item in queueCopy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
