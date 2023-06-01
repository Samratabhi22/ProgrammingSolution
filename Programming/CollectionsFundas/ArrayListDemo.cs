using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas
{
    public class ArrayListDemo
    {
        //Adding Elements in ArrayList
        public static void Maain()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add("James"); //Adding Duplicate Value
            arrayList1.Add(" "); //Adding Empty
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            arrayList1.Add(null); //Adding null
            
            foreach (object item in arrayList1)
            {
                Console.WriteLine(item);
            }
            //Adding Elements to ArrayList using object initializer syntax
            ArrayList arrayList2 = new ArrayList()
            {
                102, "Smith", "Smith", true, 15.6
            };
            foreach (object item in arrayList2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo2
    {
        //Access ArrayList in C#
        public static void Mafgin()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            //Accessing individual elements from ArrayList using Indexer
            int firstElement = (int)arrayList1[0]; //returns 101
            string secondElement = (string)arrayList1[1]; //returns "James"
            //int secondElement = (int) arrayList1[1]; //Error: cannot cover string to int
            Console.WriteLine($"First Element: {firstElement}, Second Element: {secondElement}");
            //Using var keyword without explicit casting
            var firsItem = arrayList1[0]; //returns 101
            var secondItem = arrayList1[1]; //returns "James"
            //var fifthElement = arrayList1[5]; //Error: Index out of range
            Console.WriteLine($"First Item: {firsItem}, Second Item: {secondItem}");
            //update elements
            arrayList1[0] = "Smith";
            arrayList1[1] = 1010;
            //arrayList1[5] = 500; //Error: Index out of range
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo3
    {//Iterate and Count of  an ArrayList
        public static void Marin()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            Console.WriteLine("Count of ArrayList is "+arrayList1.Count);
            //Iterating through foreach loop
            Console.WriteLine("\nUsing ForEach Loop");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            //Iterating through for loop
            Console.WriteLine("\n\nUsing For Loop");
            for (int i = 0; i < arrayList1.Count; i++)
            {
                Console.Write($"{arrayList1[i]} ");
            }
            Console.WriteLine("\n\nAgain Count of ArrayList is " + arrayList1.Count);
            Console.ReadKey();
        }
    }
    public class ArrayListDemo4
    {//Inserting an Element in ArrayList in the Middle without changing the previous ArrayList
        public static void Mavin()
        {
            ArrayList arrayList = new ArrayList()
            {
                    101,
                    "James",
                    true,
                    10.20
            };

            //Insert "First Element" at First Position i.e. Index 0
            arrayList.Insert(0, "First Element");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList.Insert(2, "Third Element");
            //Iterating through foreach loop
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo5
    {//Insert one collection into another Collection
        public static void Mazin()
        {
            ArrayList arrayList1 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                   // null,//accepted
                    "Nepal"
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            ArrayList arrayList2 = new ArrayList()
            {
                    "Srilanka",
                    "Japan",
                   //   null,//accepted
                    "Britain"
            };
            arrayList1.InsertRange(2, arrayList2);

            Console.WriteLine("\n\nArray List Elements After InsertRange");
            foreach (var item in arrayList1)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo6
    {//Remove Elements from ArrayList 
        //Remove(object? obj)
        //RemoveAt(int index)
        //RemoveRange(int index, int count)
        public static void Madin()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal",
                    "HongKong",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.Remove("HongKong"); //Removes first occurance of Honkong
            Console.WriteLine("\n\nArray List Elements After Removing First Occurances of HongKong");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveAt(3); //Removes element at index postion 3, it is 0 based index
            Console.WriteLine("\n\nArray List1 Elements After Removing Element from Index 3");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            arrayList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            Console.WriteLine("\n\nArray List Elements After Removing First Two Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo7
    {//Remove all the elements from the ArrayList 
        //Clear()
        //capacity 0,4,8,16
        public static void Maddin()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
                   
            };
            int totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items: {totalItems}, Capacity: {arrayList.Capacity}"));
            //Remove all items from the Array list             
            arrayList.Clear();
            totalItems = arrayList.Count;
            Console.WriteLine(string.Format($"Total Items After Clear(): {totalItems}, Capacity: {arrayList.Capacity}"));
            Console.ReadKey();
        }
    }
    public class ArrayListDemo8
    {//Contains
        public static void Mangin()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "UK",
                    "Nepal",
                    101
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nIs ArrayList Contains India: {arrayList.Contains("India")}"); // true
            Console.WriteLine($"Is ArrayList Contains USA: {arrayList.Contains("USA")}"); // false
            Console.WriteLine($"Is ArrayList Contains 101: {arrayList.Contains(101)}"); // true
            Console.WriteLine($"Is ArrayList Contains 10.5: {arrayList.Contains(10.5)}"); // false
            Console.ReadKey();
        }
    }
    public class ArrayListDemo9
    {// Check whether an Element exists in ArrayList or not
        //bool Contains(object? item)
        public static void fded()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "UK",
                    "Nepal",
                    101
            };
            Console.WriteLine("Array List Elements");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nIs ArrayList Contains India: {arrayList.Contains("India")}"); // true
            Console.WriteLine($"Is ArrayList Contains USA: {arrayList.Contains("USA")}"); // false
            Console.WriteLine($"Is ArrayList Contains 101: {arrayList.Contains(101)}"); // true
            Console.WriteLine($"Is ArrayList Contains 10.5: {arrayList.Contains(10.5)}"); // false
            Console.ReadKey();
        }
    }
    public class ArrayListDemo10
    {//copy an ArrayList to an existing array

        public static void Maddain()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            //Copying the arrayList to an object array
            object[] arrayListCopy = new object[arrayList.Count];
            arrayList.CopyTo(arrayListCopy);
            Console.WriteLine("\nArrayList Copy Array Elements:");
            foreach (var item in arrayListCopy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo11
    {//Sorting
        public static void Maifen()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "Nepal",
                    "HongKong",
                    "Austrailla",
                    "Srilanka",
                    "Japan",
                    "Britem",
                    "Brazil",
            };
            Console.WriteLine("Array List Elements Before Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            // Sorting the elements of  ArrayList Using sort() method
            arrayList.Sort();
            Console.WriteLine("\n\nArray List Elements After Sorting");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
    public class ArrayListDemo12
    {
        //Cloning
        public static void Martin()
        {
            ArrayList arrayList = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Denmark",
                    "HongKong",
            };
            Console.WriteLine("Array List Elements:");
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item} ");
            }
            //Creating a clone of the arrayList using Clone method
            ArrayList cloneArrayList = (ArrayList)arrayList.Clone();
            Console.WriteLine("\nCloned ArrayList Elements:");
            foreach (var item in cloneArrayList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();
        }
    }
}


