using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class StringPalindrome
    {
        public static void Marin()
        {
            String s = "madam";
           
            String rev = "";
          

            for (int i = s.Length - 1; i >= 0; i--)
            {
               rev = rev + s[i];
               

            }
           if (rev.Equals(s))
            
            {
                Console.WriteLine("it is a palindrome string");
            }
            else
            {
                Console.WriteLine("it is not a palindrome string");
            }

        }

    }
}
