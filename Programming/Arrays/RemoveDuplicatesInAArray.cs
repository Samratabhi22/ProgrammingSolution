using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class RemoveDuplicatesInAArray
    {
        public static void ghain()
        {
            int[] a = { 4, 5, 4, 1, 5, 2, 3 };
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                set.Add(a[i]);

            }
            foreach (int e in set)
            {
                Console.Write(e + " ");
            }

        }

    }
}
