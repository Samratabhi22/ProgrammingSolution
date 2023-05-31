using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.SanjaySirAssignmentQuestions
{
    internal class Addition_of_first_three_min_of_Array
    {
		static void Mavghin()
		{
			
			int[] a = { 7, -6, 11, 9, 0, 4 };
			int firstMinmun = int.MaxValue;
			int secondMinimun = int.MaxValue;
			int thirdMinimun = int.MaxValue;

			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] < firstMinmun)
				{
					thirdMinimun = secondMinimun;
					secondMinimun = firstMinmun;
					firstMinmun = a[i];
				}
				else if (a[i] < secondMinimun && a[i] > firstMinmun)
				{
					thirdMinimun = secondMinimun;
					secondMinimun = a[i];
				}
				else if (a[i] < thirdMinimun && a[i] > secondMinimun)
				{
					thirdMinimun = a[i];
				}
                int sum = firstMinmun + secondMinimun + thirdMinimun;
                Console.WriteLine(firstMinmun);
                Console.WriteLine(secondMinimun);
                Console.WriteLine(thirdMinimun);
                Console.WriteLine("sum is " + sum);

            }
		}
	}
    }

