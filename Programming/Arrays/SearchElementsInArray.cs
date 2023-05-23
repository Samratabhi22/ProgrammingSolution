using System;



namespace Programming
{
    internal class SearchElementsInArray
    {
        static void searchElements()
        {
            
            int sizeofArray, n;
            int count = 0;
            Console.WriteLine("Enter the size of an Array : ");
            sizeofArray = int.Parse(Console.ReadLine());
            int[] arr = new int[sizeofArray];
            Console.WriteLine("Enter the Array Elements : ");
            for (int i = 0; i < sizeofArray; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the Elements to Search");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < sizeofArray; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                    Console.WriteLine("Number " + n + " found at position " + (i + 1));
                    // break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine(" Number not found in the Array " + n);
            }

            Console.ReadLine();

        }
    }
}
