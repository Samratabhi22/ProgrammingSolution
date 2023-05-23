using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class AppendZerosINTheLast
    {
        static void yain()
        {


            int []a = { 0, 4, 45, 25, 0, 2, 0, 87 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == 0)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }


                }
                Console.Write(a[i] + " ");

            }
        }
    }
}
