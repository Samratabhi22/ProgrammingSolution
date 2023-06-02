using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public class QueueDemo
    {
        public static void Main()
        {
            //Creating a Queue to Store Integer Values
            Queue<int> queue = new Queue<int>();
            //Adding Elements to the Queue using Enqueue Method
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            
            //Adding Duplicate
            queue.Enqueue(30);
            //As int is not a Reference type so null can not be accepted by this queue
            //queue.Enqueue(null); //Compile-Time Error
            //As the queue is integer type, so string values can not be accepted
            //queue.Enqueue("Hell0"); //Compile-Time Error
            //Accesing all the Elements of the Queue using For Each Loop
            Console.WriteLine("Generic Queue Elements");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
