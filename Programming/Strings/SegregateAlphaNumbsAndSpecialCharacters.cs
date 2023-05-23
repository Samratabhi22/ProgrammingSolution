using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class SegregateAlphaNumbsAndSpecialCharacters
    {
        public static void Mfgain()
        {
            String st = "a2B*C5?d";//aBCd 25 ?&

            String alpha = "";
            String num = "";
            String spc = "";
            char[] s = st.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z' || s[i] >= 'A' && s[i] <= 'Z')
                {
                    alpha = alpha + s[i];//aBCd
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    num = num + s[i];//25
                }
                else
                {
                    spc = spc + s[i];//*&
                }

            }
            Console.WriteLine(alpha + " " + num + " " + spc);



        }
    }
}
