using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Occurance_of_word
    {
        static void Masdin()
        {
            
            String str = "the trouble can't trouble me because i trouble the trouble";
            String[] strArr = str.Split(" ");
            HashSet<String> set = new HashSet<String>();
            for (int i= 0;i < strArr.Length;i++)
            {
                set.Add(strArr[i]);
            }

            foreach (String s in set)
            {
                int count = 0;
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (s.Equals(strArr[i]))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {
                    Console.WriteLine(s + " is occuring " + count + " times");
                }
            }

        }
    }
}
