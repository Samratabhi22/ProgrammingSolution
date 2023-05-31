using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CSharpFundas
{
    public class FbApp
    {
        public void login(long contact)
        {
            Console.WriteLine("from login contact  "+contact);

        }
        public void login(string mail)
        {
            Console.WriteLine("from login mail "+mail);
        }
    }
    class Driver1
    {
        public static void Mzsain() 
        {
          FbApp obj = new FbApp();
            obj.login(9874563210);
            obj.login("abc@gmail.com");
        }
    }
}
