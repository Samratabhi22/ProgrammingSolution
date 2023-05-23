using System;


namespace Programming
{
    public class FirstMaxArray
    {
        static void FirstMax()
        {
            int[] a = { 5, 3, 0, 1, 4 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }

            }
            // Console.WriteLine(a.Max());
            Console.WriteLine(a[0]);



        }
    }
}
