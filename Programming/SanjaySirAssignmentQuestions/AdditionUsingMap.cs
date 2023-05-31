using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class AdditionUsingMap
    {
		static void Majkin()
		{
            Console.WriteLine("addition_09_using_hashMap");

            int[] a = { 7, 2, 12, 15 }; //o\p=9
			Dictionary<int, int> map = new Dictionary<int, int>();
			for (int i = 0; i < a.Length; i++) {
				map.Add(i, a[i]);

			}
			int indexI = 0;
			int indexJ = 0;

			for (int i = 0; i < a.Length; i++) {
				for (int j = i + 1; j < a.Length; j++) {
					if (a[i] + a[j] == 9) {
						indexI = i;
						indexJ = j;
					}
				}
			}

            //	gets the value at particular index 
            Console.WriteLine("result >> " + (map[indexI] + map[indexJ]));
			Console.ReadLine();
        }
	}
}

