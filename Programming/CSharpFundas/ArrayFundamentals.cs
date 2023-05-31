using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CSharpFundas
{
    internal class ArrayFundamentals
    {
        static void Maicn()
        {
            int[] a = {10,20,30,40,50};
            Array.Resize(ref a, 10);
            a[6] = 70;
            a[7] = 80;
            a[8] = 90;
            a[9] = 100;
            a[11] = 110;

            Console.WriteLine(a[7]);
        }
    }
}
