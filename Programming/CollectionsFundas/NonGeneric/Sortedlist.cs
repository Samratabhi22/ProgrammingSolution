﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.NonGeneric
{
    public class Sortedlist
    {
        //How to Create a SortedList and Add Elements and Access Elements
        public static void Mafin(string[] args)
        {
            //Creating sortedList Collection
            SortedList sortedList = new SortedList();
            //Adding Elements to SortedList using Add Method
            //Key type going to be same
            sortedList.Add(1, "One");
            sortedList.Add(5, "Five");
            sortedList.Add(4, "Four");
            sortedList.Add(2, "Two");
           // sortedList.Add("value", "Three");
            //Duplicate Key not allowed
            //System.ArgumentException: 'Item has already been added. Key in dictionary: '4'  Key being added: '4''
            //sortedList.Add(4, "Four");
            //Null value is allwed
            sortedList.Add(6, null);
            //Duplicate Value is allowed
            sortedList.Add(7, "Five");
            //In this case string key is not valid, throw Exception
           // sortedList.Add('j', "Ten");
            //Accessing SortedList using For loop
            Console.WriteLine("Accessing SortedList using For loop");
            for (int x = 0; x < sortedList.Count; x++)
            {
                Console.WriteLine($"Key: {sortedList.GetKey(x)}, Value: {sortedList.GetByIndex(x)}");
            }
            Console.WriteLine("\nAccessing SortedList using For Each loop");
            //Accessing SortedList using For Each loop
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.WriteLine("\nAccessing SortedList using Keys");
            Console.WriteLine($"Key: 1, Value: {sortedList[1]}");
            Console.WriteLine($"Key: 2, Value: {sortedList[2]}");
            Console.WriteLine($"Key: 3, Value: {sortedList[3]}");
            Console.WriteLine("\nAccessing SortedList using Index");
            Console.WriteLine($"Key: 1, Index: 0, Value: {sortedList.GetByIndex(0)}");
            Console.WriteLine($"Key: 2, Index: 1, Value: {sortedList.GetByIndex(1)}");
            Console.WriteLine($"Key: 3, Index: 2, Value: {sortedList.GetByIndex(2)}");
            Console.ReadKey();
        }
    }
    class Sortedlist1
    {
        //Adding Elements to SortedList using Collection Initializer
        public static void Maghgin(string[] args)
        {
            //Creating sortedList using Object Initializer
            SortedList sortedList = new SortedList
            {
                { "Ind", "India" },
                { "USA", "United State of America" },
                { "SA", "South Africa" },
                { "PAK", "Pakistan" }
            };
            Console.WriteLine("SortedList Elements");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadKey();
        }
    }
    class Sortedlist2
    {
        //Remove Elements from a SortedList Collection
        public static void Mazin(string[] args)
        {
            //Creating sortedList object
            SortedList sortedList = new SortedList();
            //Adding Elements to SortedList using Add
            sortedList.Add("Ind", "India");
            sortedList.Add("USA", "United State of America");
            sortedList.Add("SA", "South Africa");
            sortedList.Add("PAK", "Pakistan");
            Console.WriteLine("SortedList Elements");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            // Remove value having key PAK Using Remove() method
            sortedList.Remove("PAK");
            // After Remove() method
            Console.WriteLine("\nSortedList Elements After Remove Method");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            // Remove element at index 1 Using RemoveAt() method
            sortedList.RemoveAt(1);
            Console.WriteLine("\nSortedList Elements After RemoveAT Method");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            // Remove all key/value pairs Using Clear method
            sortedList.Clear();
            Console.WriteLine($"After Clear Method Total Key-Value Pair Present is : {sortedList.Count} ");
            Console.ReadKey();
        }
    }
    class Sortedlist3
    {
        public static void Mavin(string[] args)
        {
            //Creating sortedList using Object Initializer
            SortedList sortedList = new SortedList
            {
                { "Ind", "India" },
                { "USA", "United State of America" },
                { "SA", "South Africa" },
                { "PAK", "Pakistan" }
            };
            //Checking the key using the Contains methid
            Console.WriteLine("Is Ind Key Exists : " + sortedList.Contains("Ind"));
            Console.WriteLine("Is NZ Key Exists : " + sortedList.Contains("NZ"));
            //Checking the key using the ContainsKey methid
            Console.WriteLine("Is Ind Key Exists : " + sortedList.ContainsKey("Ind"));
            Console.WriteLine("Is NZ Key Exists : " + sortedList.ContainsKey("NZ"));
            //Checking the value using the ContainsValue method
            Console.WriteLine("Is India value Exists : " + sortedList.ContainsValue("India"));
            Console.WriteLine("Is Bangladesh value Exists : " + sortedList.ContainsValue("Bangladesh"));
            Console.ReadKey();
        }
    }
    class Sortedlist4
    {
        //How to Clone the Non-Generic SortedList 
        public static void Masin(string[] args)
        {
            //Creating sortedList using Object Initializer
            SortedList sortedList = new SortedList
            {
                { "Ind", "India" },
                { "USA", "United State of America" },
                { "SA", "South Africa" },
                { "PAK", "Pakistan" }
            };
            Console.WriteLine("Sorted List Elements:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.WriteLine("\nCloned Sorted List Elements:");
            //Creating a clone sortedList using Clone method
            SortedList cloneSortedList = (SortedList)sortedList.Clone();
            foreach (DictionaryEntry item in cloneSortedList)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            Console.ReadKey();
        }
    }
    class Sortedlist5
    {
        //use of the CopyTo method of the Non-Generic SortedList Collection Class
        public static void Mtain(string[] args)
        {
            //Creating sortedList using Object Initializer
            SortedList sortedList = new SortedList
            {
                { "Ind", "India" },
                { "USA", "United State of America" },
                { "SA", "South Africa" },
                { "PAK", "Pakistan" }
            };
            Console.WriteLine("Sorted List Elements:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"Key: {item.Key} : Value: {item.Value}");
            }
            DictionaryEntry[] myTargetArray = new DictionaryEntry[5];
            sortedList.CopyTo(myTargetArray, 1);

            Console.WriteLine("\nCopyTo Method to Copy Keys and values:");
            for (int i = 0; i < myTargetArray.Length; i++)
            {
                Console.WriteLine($"{myTargetArray[i].Key} : {myTargetArray[i].Value}");
            }
            object[] myObjArrayKey = new object[5];
            object[] myObjArrayValue = new object[5];
            Console.WriteLine("\nCopyTo Method to Copy Keys:");
            sortedList.Keys.CopyTo(myObjArrayKey, 1);
            foreach (var key in myObjArrayKey)
            {
                Console.WriteLine($"{key} ");
            }
            Console.WriteLine("\nCopyTo Method to Copy Values:");
            sortedList.Values.CopyTo(myObjArrayValue, 1);
            foreach (var key in myObjArrayValue)
            {
                Console.WriteLine($"{key} ");
            }
            Console.ReadKey();
        }
    }
}
