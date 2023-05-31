using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class CountDuplicatesInArray
    {
        static void Mabgin()
        {
          
            int[] a = { 4, 5, 4, 1, 5, 2, 3, 0, 0 };



            

            // HashSet<int> set	=new HashSet<int>();//remove duplicates and no order is maintained
            SortedSet<int> set = new SortedSet<int>();//remove duplicates and maintain ascending order
            


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
                if (count > 1)
                {
                    Console.WriteLine(e + " count : " + count);
                }

            }

        }
    }
}
