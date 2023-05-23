using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Strings
{
    internal class RemoveSpaceBtwnString
    {
        static void Mssain()
        {
            //String s = "I am a software engineer";
            //reverse the string and than remove space
            // engineersoftwareaamI

            //        String[] st = s.Split(" ");
            //for (int i = st.Length - 1; i >= 0; i--)
            //{

            //    Console.Write(st[i]);

            //}
            //2nd method
            String s = "I am a software engineer";//Iamasoftwareengineer
            String[] st = s.Split(" ");
            for (int i = 0; i < st.Length; i++)
            {
                Console.Write(st[i]);
            }
        }
    }
}
