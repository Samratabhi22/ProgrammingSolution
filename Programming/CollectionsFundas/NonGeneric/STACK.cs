using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.NonGeneric
{
    public class STACK
    {
        //How to Create a Stack and Add Elements
        static void Maifn(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            //Printing the stack items using foreach loop
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class STACK1
    {
        //Remove Elements from a Non-Generic Stack Collection

        static void Marrin(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            //Printing the stack items using foreach loop
            Console.WriteLine($"All Stack Elements: Count {stack.Count}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            //Removing and Returning an item from the stack using the pop method
            Console.WriteLine($"\n\nDeleted Element: {stack.Pop()}");
            //Printing item after removing the last added item
            Console.WriteLine($"\nAll Stack Elements After Deletion: Count {stack.Count}");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
    class STACK2
    {
        //How to get the topmost element of a Stack
        static void Masin(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            Console.WriteLine($"Total elements present in stack : {stack.Count}");
            // Fetch the topmost element of stack Using Pop method
            Console.WriteLine($"Topmost element of stack is {stack.Pop()}");
            Console.WriteLine($"Total elements present in stack : {stack.Count}");
            // Fetch the topmost element from Stacj Using Peek method
            Console.WriteLine($"Topmost element of Stack is {stack.Peek()}");
            Console.WriteLine($"Total elements present in stack : {stack.Count}");
            Console.ReadKey();
        }
    }
    class STACK3
    {
        //How to check whether an element exists or not in the stack
        static void Madin(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            stack.Push('A');
            // Checking if the element Hello is present in the Stack or not
            if (stack.Contains("Hello"))
            {
                Console.WriteLine("Element Hello is found");
            }
            else
            {
                Console.WriteLine("Element Hello is not found");
            }
            // Checking if the element Hello is present in the Stack or not
            if (stack.Contains("World"))
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
    class STACK4
    {
        static void Maicn(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(67.8);
            //Printing All Stack Elements using For Each Loop
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Creating a clone queue using Clone method
            Stack cloneStack = (Stack)stack.Clone();
            Console.WriteLine("\nCloned Stack Elements:");
            foreach (var item in cloneStack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class STACK5
    {
        //How to copy a stack to an existing array
        static void Mafin(string[] args)
        {
            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(10);
            stack.Push("Hello");
            stack.Push(3.14f);
            stack.Push(true);
            stack.Push(67.8);
            //Printing All Queue Elements using For Each Loop
            Console.WriteLine("Stack Elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            //Copying the queue to an object array
            object[] stackCopy = new object[5];
            stack.CopyTo(stackCopy, 0);
            Console.WriteLine("\nStack Copy Array Elements:");
            foreach (var item in stackCopy)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}



