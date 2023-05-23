using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Programming.Strings
{
    internal class ReverseString
    {
        static void Mtain()
        {
            //Inbuilt 1st method
            String str = "abhishek";
            //String str3 = new String(str.ToCharArray().Reverse().ToArray()); //using Linq
            //Console.Write(str3);

            //inbuilt 2nd method
            //char[] ch = str.ToCharArray();
            //Array.Reverse(ch);
            //Console.Write(new string(ch));

            //  //String rev = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //  //  // rev = rev + str[i]
            //   Console.Write(str[i]);
            //}

            //Console.WriteLine(rev);

            //2nd method
            //char[] str1 = str.ToCharArray();
            ////int count=0;
            //for (int i = str.Length - 1; i >= 0; i--)
            //{

            //    Console.Write(str1[i]);
            //}
            // 3rd method using toCharArray
            //char[] str1 = str.ToCharArray();
            //for (int i = str1.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str1[i]);
            //}


            // //4th method
            //char[] str2 = str.ToCharArray();
            //int count = 0;
            //foreach (char c in str2)
            //{
            //    count++;
            //}
            //for (int i = count - 1; i >= 0; i--)
            //{
            //    Console.Write(str2[i]);

            //}

            // 5 using String builder

            //StringBuilder build = new StringBuilder(str);

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    // build.
            //    Console.Write(build.Append( str[i]));
            //    break;
            //}
            //string newName = build.ToString();

            //Console.WriteLine(newName);


            Console.ReadLine(); 

        }
    }
}
