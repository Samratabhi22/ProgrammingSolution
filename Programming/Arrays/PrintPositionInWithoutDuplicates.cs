using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class PrintPositionInWithoutDuplicates
    {
        static void iain(String[] args)
        {
            int[] a = { 4, 5, 4, 1, 2, 3, 5 };
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                set.Add(a[i]);

            }
            foreach (int e in set)
            {

                for (int i = 0; i < a.Length; i++)
                {
                    if (e == a[i])
                    {
                        Console.WriteLine(e + " position is  " + (i + 1));
                        break;
                    }
                }

            }

        }
    }
}
