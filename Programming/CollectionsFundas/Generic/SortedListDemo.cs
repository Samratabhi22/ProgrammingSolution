using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public class SortedListDemo
    {
        static void Maererein()
        {
            //Creating Generic SortedList Collection
            SortedList<int, string> genericSortedList = new SortedList<int, string>();
            //Adding Elements to SortedList Collection using Add Method in Random Order
            genericSortedList.Add(1, "One");
            genericSortedList.Add(5, "Five");
            genericSortedList.Add(4, "Four");
            genericSortedList.Add(2, "Two");
            genericSortedList.Add(3, "Three");
           
            //You cannot pass null as a key
            //genericSortedList.Add(null, "Ten"); //Compile-Time Error
            //Duplicate Key not allowed
            //System.ArgumentException: 'An entry with the same key already exists.'
            //genericSortedList.Add(2, "Any Value");
            //Accessing Generic SortedList Collection using For loop
            Console.WriteLine("Accessing Generic SortedList using For loop");
            for (int i = 0; i < genericSortedList.Count; i++)
            {
                Console.WriteLine("Keys : " + genericSortedList.Keys[i] + "\tValues : " + genericSortedList.Values[i]);
            }
            //Accessing Generic SortedList Collection using For Each loop
            Console.WriteLine("\nAccessing SortedList using For Each loop");
            foreach (KeyValuePair<int, string> item in genericSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Accessing Generic SortedList Individual Elements using Keys
            Console.WriteLine("\nAccessing SortedList Individual Elements using Keys");
            Console.WriteLine($"Key: 1, Value: {genericSortedList[1]}");
            Console.WriteLine($"Key: 2, Value: {genericSortedList[2]}");
            Console.WriteLine($"Key: 3, Value: {genericSortedList[3]}");
            Console.ReadKey();
        }
    }
}
