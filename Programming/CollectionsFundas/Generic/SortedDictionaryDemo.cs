using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public class SortedDictionaryDemo
    {
        public static void Magin()
        {
            //Creating Generic SortedDictionary Collection with key as integer and value as string
            //Adding Elemenst using Collection Initializer
            SortedDictionary<int, string> genericSortedDictionary = new SortedDictionary<int, string>
            {
                { 1, "One" },
                { 3, "Three" },
                { 5, "Five" },
                { 4, "Four" }
            };
            //Adding Element using Add Method
            genericSortedDictionary.Add(2, "Two");
            
            //Accessing Generic SortedDictionary Collection using For Each loop
            Console.WriteLine("Accessing SortedDictionary using For Each loop");
            foreach (var item in genericSortedDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
