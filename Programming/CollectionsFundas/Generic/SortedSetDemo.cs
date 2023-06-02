using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public  class SortedSetDemo
    {
        static void Mavin()
        {
            //Creating an Instance of SortedSet class to store Integer values
            SortedSet<int> sortedSetNumbers = new SortedSet<int>();
            //Adding Elements to SortedSet using Add Method
            sortedSetNumbers.Add(10);
            sortedSetNumbers.Add(5);
            sortedSetNumbers.Add(50);
            sortedSetNumbers.Add(37);
            sortedSetNumbers.Add(18);
            sortedSetNumbers.Add(37);
            //Accessing the SortedSet Elements using For Each Loop
            Console.WriteLine("SortedSet Elements");
            foreach (var item in sortedSetNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
