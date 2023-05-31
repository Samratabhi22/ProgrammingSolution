using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Push_Key_Index_value_To_Last
    {

        public static void Masgiin(String[] args)
        {
            Console.WriteLine("15--> push_Key_Index_value_To_Last");
            int[] a = { 5, 1, 2, 3, 4 };
            int key = 2;
            for (int i = 0; i < key; i++)
            {
                int first = a[0];
                for (int j = 0; j < a.Length - 1; j++)
                {
                    a[j] = a[j + 1];
                }
                a[a.Length - 1] = first;
            }

            Console.Write("Expected The Array ---> [ ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("]");

        }
    }
}
