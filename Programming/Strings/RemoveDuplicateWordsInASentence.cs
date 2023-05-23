using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class RemoveDuplicateWordsInASentence
    {
        static void dain()
        {


            String s = "I am I am a Software Engineer Engineer";
            String []st = s.Split(" ");
            //String s= st.toLowerCase();
            HashSet<String> set = new HashSet<String>();
            for (int i = 0; i < st.Length; i++)
            {
                set.Add(st[i]);

            }
            foreach (String str in set)
            {
                //System.out.println(ch+" ");
                Console.WriteLine(str + " ");





            }

        }
    }
}
