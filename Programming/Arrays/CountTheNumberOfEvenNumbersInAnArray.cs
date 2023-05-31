using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class CountTheNumberOfEvenNumbersInAnArray
    {
        static void Mavcin()
        {

            int count = 0;

            int sizeofArray;
            Console.WriteLine("Enter the size of Array : ");
            sizeofArray = int.Parse(Console.ReadLine());
            int[] arr = new int[sizeofArray];
            Console.WriteLine("Enter the Numbers : ");

            for (int i = 0; i < sizeofArray; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine("Total Even Numbers " + count);
            Console.ReadLine();


        }

    }
}
