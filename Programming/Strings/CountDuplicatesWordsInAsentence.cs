using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class CountDuplicatesWordsInAsentence
    {
        public static void Main()
        {
            
            String s = "I am I am a software engineer doing engineer I am software";
            // s= s.ToLower();
            s = s.ToLower();


            String [] words = s.Split();

            Console.WriteLine("Duplicate words in a given string : ");
            int count;
            for (int i = 0; i < words.Length; i++)
            {
                count = 0;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        //Set words[j] to 0 to avoid printing visited word    
                        words[j] = "0";
                    }
                }
                //Displays the duplicate word if count is greater than 1    
                if (count > 0 && words[i] != "0")
                    Console.Write(words[i] + " ");


            }
        }
    }
}
