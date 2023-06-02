using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public class HashSetDemo
    {
        static void Mwxain()
        {
            //Creating HashSet
            HashSet<string> hashSetCountries = new HashSet<string>();
            //Adding Elements to HashSet using Add Method
            hashSetCountries.Add("INDIA");
            hashSetCountries.Add("USA");
            hashSetCountries.Add("UK");
            
            //Adding Duplicate Elements will not give compile time error
            //But duplicate elements are simply ignored and will not be added into the collection
            hashSetCountries.Add("UK");
            hashSetCountries.Add("INDIA");
            
            Console.WriteLine($"Elements Count: {hashSetCountries.Count}");
            //Accessing HashSet collection using For Each Loop
            //Here, you can observe UK and INDIA are printed once
            Console.WriteLine($"Accessing HashSet Elements:");
            foreach (var item in hashSetCountries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
