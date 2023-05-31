using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Remove_duplicate_words_from_2_strings
    {
        public static void cfain(String[] args)
        {
            Console.WriteLine("13--> remove_duplicate_words_from_2_strings");
            String str1 = "This is fun show";
            String[] str1Arr = str1.Split(" ");
            String str2 = "fun tv show";
            String[] str2Arr = str2.Split(" ");

            HashSet<String> set1 = new HashSet<String>();
            for (int i = 0; i < str1Arr.Length; i++)
            {
                set1.Add(str1Arr[i]);
            }
            for (int i = 0; i < str2Arr.Length; i++)
            {
                if (set1.Contains(str2Arr[i]))
                {
                    set1.Remove(str2Arr[i]);
                }
                else
                {
                    set1.Add(str2Arr[i]);
                }
            }

            foreach (String strg in set1)
            {
                Console.Write(strg + " ");
            }
            Console.WriteLine(); 

        }
    }
}
