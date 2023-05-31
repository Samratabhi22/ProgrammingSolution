using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CSharpFundas
{
    public interface IEmployee
    {
        public void Project();
        void Manager()
        {

        }
        public  static string Name = "abhishek";
        //interface cannot contain non static fields but we can use static variables 
    }
    public abstract class Employee
    {
        public Employee() 
        {
        
        }
        public string _name ="abhi";
        public abstract void Project();
         public abstract void Manager();

         internal void Role()
        {

        }
    }
}
