using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Reverse_the_word_In_Sentence
    {
        


        static void Madcvbgfin()
        {
            string sentence = "my name is ok";
            //output -->   ym eman si ko
            string reversedSentence = null ;
           
       
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);
                words[i] = new string(wordChars);
            }

             reversedSentence = string.Join(" ", words);

            Console.WriteLine(reversedSentence);
        }
    }

}

