using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public class StackDemo
    {
        public static void Maihn()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            
            //Adding Duplicate
            stack.Push(30);
            //As int is not a Reference type so null can not be accepted by this stack
            //stack.Push(null); //Compile-Time Error
            //As the stack is integer type, so string values can not be accepted
            //stack.Push("Hell0"); //Compile-Time Error
            Console.WriteLine("Generic Stack Elements");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
