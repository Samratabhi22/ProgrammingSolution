﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class SumOfFirstThreeMaxArray
    {
        static void eain(String[] args)
        {
            int[] a = { 5, 3, 0, 1, 4 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }


            }
            int sum = 0;
            for (int k = 0; k < 3; k++)
            {
                sum = sum + a[k];
            }
            Console.WriteLine(sum + " ");

        }
    }
}
