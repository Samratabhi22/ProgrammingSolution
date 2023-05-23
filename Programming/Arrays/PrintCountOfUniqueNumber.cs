using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class PrintCountOfUniqueNumber
    {
        static void jain()
        {
            int[] a = { 4, 5, 4, 1, 2, 3, 5 };
             HashSet<int> set = new HashSet<int>();
           // SortedSet<int> set = new SortedSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                set.Add(a[i]);

            }
            foreach (int e in set)
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (e == a[i])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(e + " is unique ");
                }

            }

        }
    }
}
