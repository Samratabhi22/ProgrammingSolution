using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Check_for_anagram_for_2_string
    {
        public static void Mbbain(String[] args)
        {
            Console.WriteLine("18--> check_for_anagram_for_2_string");
            String str1 = "Listen";
            str1 = str1.ToLower();
            String str2 = "Silent";
            str2 = str2.ToLower();

            if (str1.Length == str2.Length)
            {
                int sum1 = 0;
                int sum2 = 0;
                for (int i = 0; i < str1.Length; i++)
                {
                    int asc1 = str1[i];
                    int asc2 = str2[i];
                    sum1 = sum1 + asc1;
                    sum2 = sum2 + asc2;
                }
                if (sum1 == sum2)
                {
                    Console.WriteLine("Given '" + str1 + "' and '" + str2 + "' are anagram words");
                }
                else
                {
                    Console.WriteLine("Strings are not anagram");
                }
            }
            else
            {
                Console.WriteLine("Strings are not anagram");
            }

        }
    }
}
