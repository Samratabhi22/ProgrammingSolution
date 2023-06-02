using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    internal class LinkedListDemo
    {
        public static void Madddin()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("India");
            
            linkedList.AddLast("USA");
            linkedList.AddLast("Srilanka");
            linkedList.AddLast("UK");
            linkedList.AddLast("Japan");
           
            Console.WriteLine("LinkedList Elements");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(linkedList.Find("Srilanka"));
            Console.ReadKey();
        }
    }
}
