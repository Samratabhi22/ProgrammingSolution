using Programming.CSharpFundas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.CollectionsFundas.Generic
{
    public class ListGeneric
    {
        // How to Create a List<T> Collection and Add Elements
        static void Maisn()
        {
            //Creating a Generic List of string type to store string elements
            List<string> countries = new List<string>();
            
            //Adding String Elements to the Generic List using the Add Method
            countries.Add("INDIA");
            countries.Add("USA");
            //The following Two Statements will give compile time error as element is not string type
            //countries.Add(100);
            //countries.Add(true);
            //Creating Another Generic List Collection of String Type
            List<string> newCountries = new List<string>();
            //Adding Elements using Add Method
            newCountries.Add("JAPAN");
            newCountries.Add("UK");
            //Adding the newCountries collection into countries collection using AddRange Method
            countries.AddRange(newCountries);

            //Accessing Generic List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Adding the countries collection into newCountries collection using AddRange Method
            newCountries.AddRange(countries);
            Console.WriteLine("Accessing Generic List Again using For Each Loop");
            foreach (var item in newCountries)
            {
                Console.WriteLine(item);
            }
            //Accessing Generic List Elements using For Loop
            Console.WriteLine("\nAccessing Generic List using For Loop");
            for (int i = 0; i < countries.Count; i++)
            {
                var element = countries[i];
                Console.WriteLine(element);
            }
            //Accessing List Elements by using the Integral Index Position
            Console.WriteLine("\nAccessing Individual List Element by Index Position");
            Console.WriteLine($"First Element: {countries[0]}");
            Console.WriteLine($"Second Element: {countries[1]}");
            Console.WriteLine($"Third Element: {countries[2]}");
            Console.WriteLine($"Fourth Element: {countries[3]}");
            Console.ReadKey();
        }
    }
   class ListGeneric1
    {
        //Add Elements to a List using Collection Initializer 
        static void Mahin()
        {
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK"
            };
            //Accessing List Elements using ForEach Loop
            Console.WriteLine("Accessing Generic List Elemenst using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
    class ListGeneric2
    {
        //Insert Elements at a Specific Position in a Generic List Collection 
        static void Majin()
        {
            //Creating a Generic List of string type
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA"
            };
            Console.WriteLine("Accessing List Elements Before Inserting");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Insert Element at Index Position 1
            countries.Insert(1, "China");
            Console.WriteLine($"\nIndex of China Element in the List : {countries.IndexOf("China")}");
            //Accessing List After Insert Method
            Console.WriteLine("\nAccessing List After Inserting China At Index 1");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Creating Another Generic List Collection of string type
            List<string> newCountries = new List<string>
            {
                "JAPAN",
                "UK"
            };
            //Inserting the newCountries collection into the existing countries list at Index 2 using InsertRange Method
            countries.InsertRange(2, newCountries);
            //Accessing countries List After InsertRange Method
            Console.WriteLine("\nAccessing List After InsertRange At Index 2");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
   class ListGeneric3
    {
        //Check the Availability of an Element in a List Collection
        static void Mawin()
        {
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK"
            };
            //Accessing List Elements using ForEach Loop
            Console.WriteLine("All Generic List Elemenst");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Checking the Item using the Contains method
            Console.WriteLine("\nIs INDIA Exists in List: " + countries.Contains("INDIA"));
            Console.WriteLine("Is NZ Exists in List: " + countries.Contains("NZ"));
            Console.ReadKey();
        }
    }
    class ListGeneric4
    {
        static void Mazzin()
        {
            //Creating a Generic List of string type and adding elements using collection initializer
            List<string> countries = new List<string>
            {
                "INDIA",
                "USA",
                "JAPAN",
                "UK",
                "AUSTRALIA",
                "SRILANKA",
                "BANGLADESG",
                "NEPAL",
                "CHINA",
                "NZ",
                "SOUTH AFRICA"
            };
            Console.WriteLine($"Before Removing Element Count : {countries.Count}");
            //Using Remove method to Remove an Element from the List
            Console.WriteLine($"\nRemoving Element SRILANKA : {countries.Remove("SRILANKA")}");
            Console.WriteLine(countries.Remove("SRILANKA"));
            Console.WriteLine(countries.BinarySearch("NZ"));
            Console.WriteLine($"After Removing SRILANKA Element Count : {countries.Count}");
            //Removing Element using Index Position from the List
            countries.RemoveAt(2);
            Console.WriteLine($"\nAfter Removing Index 2 Element Count : {countries.Count}");
            // Using RemoveAll method to Remove Elements from the List
            // Here, we are removing element whose length is less than 3 i.e. UK and NZ
            //countries.RemoveAll(x => x.Length < 3);
            Console.WriteLine($"\nRemoveAll Method Removes: {countries.RemoveAll(x => x.Length < 3)} Element(s)");
            Console.WriteLine($"After RemoveAll Method Element Count : {countries.Count}");
            //Removing Element using RemoveRange(int index, int count) Method
            //Here, we are removing the first two elements
            countries.RemoveRange(0, 2);
            Console.WriteLine($"\nAfter RemoveRange Method Element Count : {countries.Count}");
            //Removing All Elements using Clear method
            countries.Clear();
            Console.WriteLine($"\nAfter Clear Method Element Count : {countries.Count}");
            Console.ReadKey();
        }
    }
    class ListGeneric5
    {
        //Copy an Array to a List
        static void Maiyn()
        {
            // Create new array with 3 elements.
            string[] array = new string[] { "INDIA", "USA", "UK" };
            // Copy the array to a List.
            List<string> copiedList = new List<string>(array);
            Console.WriteLine("Copied Elements in List");
            foreach (var item in copiedList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
    class ListGeneric6
    {
        //Generic List Collection with Complex Type 
        public static void Macin()
        {
            // Create Employee Objects
            Employee emp1 = new Employee() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee emp2 = new Employee() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee emp3 = new Employee() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };

            // Create a Generic List of type Employee
            List<Employee> listEmployees = new List<Employee>();
            //Adding Employees to the listEmployees collection using Add Method
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            Console.WriteLine("Retrive the First Employee By Index");
            //Retrieving Items from the collection by using Index. 
            //The following line of code will retrieve the employee from the list. 
            //The List index is  0 based.
            Employee FirstEmployee = listEmployees[0]; //Fetch the First Added Employee from the Collection
            Console.WriteLine($"ID = {FirstEmployee.ID}, Name = {FirstEmployee.Name}, Gender = {FirstEmployee.Gender}, Salary = {FirstEmployee.Salary}");
            //Retrieving All Employees of Generic List Collection using For loop
            Console.WriteLine("\nRetrieving All Employees using For Loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //Retrieving All Employees of Generic List Collection using For Each loop
            Console.WriteLine("\nRetrieving All Employees using For Each Loop");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //Inserting an Employee into the Index Position 1.
            Employee emp4 = new Employee() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            listEmployees.Insert(1, emp4);
            //Retrieving the list after inserting the employee in index position 1
            Console.WriteLine("\nRetriving the List After Inserting New Employee in Index 1");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
            }
            //If you want to get the index postion of a specific employee then use Indexof() method as follows
            Console.WriteLine("\nIndex of emp3 object in the List = " + listEmployees.IndexOf(emp3));
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    class ListGeneric7
    {
        //How to Find Element in a Generic List Collection
        public static void Majin()
        {
            // Create Employee Objects
            Employee1 Employee1 = new Employee1() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 };
            Employee1 Employee2 = new Employee1() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 };
            Employee1 Employee3 = new Employee1() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 };
            Employee1 Employee4 = new Employee1() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 };
            //Creating a list of type Employee
            List<Employee1> listEmployees = new List<Employee1>
            {
                Employee1,
                Employee2,
                Employee3,
                Employee4
            };
            // use Contains method to check if an item exists or not in the list 
            Console.WriteLine("Contains Method Check Employee2 Object");
            if (listEmployees.Contains(Employee2))
            {
                Console.WriteLine("Employee2 Object Exists in the List");
            }
            else
            {
                Console.WriteLine("Employee2 Object Does Not Exists in the List");
            }
            // Use Exists method when you want to check if an item exists or not
            // in the list based on a condition
            Console.WriteLine("\nExists Method Name StartsWith P");
            if (listEmployees.Exists(x => x.Name.StartsWith("P")))
            {
                Console.WriteLine("List contains Employees whose Name Starts With P");
            }
            else
            {
                Console.WriteLine("List does not Contain Any Employee whose Name Starts With P");
            }
            // Use Find() method, if you want to return the First Matching Element by a conditions 
            Console.WriteLine("\nFind Method to Return First Matching Employee whose Gender = Male");
            Employee1? emp = listEmployees.Find(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {emp?.ID}, Name = {emp?.Name}, Gender = {emp?.Gender}, Salary = {emp?.Salary}");
            // Use FindLast() method when you want to searche an item by a conditions and returns the Last matching item from the list
            Console.WriteLine("\nFindLast Method to Return Last Matching Employee whose Gender = Male");
            Employee1? lastMatchEmp = listEmployees.FindLast(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {lastMatchEmp?.ID}, Name = {lastMatchEmp?.Name}, Gender = {lastMatchEmp?.Gender}, Salary = {lastMatchEmp?.Salary}");
            // Use FindAll() method when you want to return all the items that matches the conditions
            Console.WriteLine("\nFindAll Method to return All Matching Employees Where Gender = Male");
            List<Employee1> filteredEmployees = listEmployees.FindAll(employee => employee.Gender == "Male");
            foreach (Employee1 femp in filteredEmployees)
            {
                Console.WriteLine($"ID = {femp.ID}, Name = {femp.Name}, Gender = {femp.Gender}, Salary = {femp.Salary}");
            }

            // Use FindIndex() method when you want to return the index of the first item by a condition
            Console.WriteLine($"\nIndex of the First Matching Employee whose Gender is Male = {listEmployees.FindIndex(employee => employee.Gender == "Male")}");

            // Use FindLastIndex() method when you want to return the index of the last item by a condition
            Console.WriteLine($"Index of the Last Matching Employee whose Gender is Male = {listEmployees.FindLastIndex(employee => employee.Gender == "Male")}");
            Console.ReadKey();
        }
    }
    public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    public class ListGeneric8
    {
        public static void Maqin()
        {
            //Creating a list of type Employee
            List<Employee2> listEmployees = new List<Employee2>
            {
                new Employee2() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee2() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee2() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee2() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee2() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };
            //TrueForAll
            Console.WriteLine($"Are all salaries greater than 5000: {listEmployees.TrueForAll(x => x.Salary > 5000)}");

            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Employee2> readOnlyEmployees = listEmployees.AsReadOnly();
            Console.WriteLine($"\nTotal Items in ReadOnlyCollection: {readOnlyEmployees.Count}");
            // listEmployees list is created with an initial capacity of 8
            // but only 5 items are in the list. The filled percentage is less than 90 percent threshold.
            Console.WriteLine($"\nList Capacity Before invoking TrimExcess: {listEmployees.Capacity}");
            // Invoke TrimExcess() to set the capacity to the actual number of elements in the List
            listEmployees.TrimExcess();
            Console.WriteLine($"\nList Capacity After invoking TrimExcess: {listEmployees.Capacity} ");
            Console.ReadKey();
        }
    }
    public class Employee2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
    class ListGeneric9
    {
        //How to Sort a List of Simple Types
        public static void Marrrin()
        {
            List<int> numbersList = new List<int> { 1, 8, 7, 5, 2 };
            Console.WriteLine("Numbers Before Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }
            // The Sort() of List Collection class will sort the data in ascending order 
            numbersList.Sort();
            Console.WriteLine("\n\nNumbers After Sorting");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }
            // If you want to  to retrieve data in descending order then use the Reverse() method
            numbersList.Reverse();
            Console.WriteLine("\n\nNumbers in Descending order");
            foreach (int i in numbersList)
            {
                Console.Write($"{i} ");
            }
            //Another Example of Sorting String
            List<string> names = new List<string>() { "Pranaya", "Anurag", "Sambit", "Hina", "Rakesh" };
            Console.WriteLine("\n\nNames Before Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Sort();
            Console.WriteLine("\nNames After Sorting");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Reverse();
            Console.WriteLine("\nNames in Descending Order");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
    class ListGeneric10
    {
        public static void Macin()
        {
            //Creating a list of type Employee
            List<Employee3> listEmployees = new List<Employee3>
            {
                new Employee3() { ID = 101, Name = "Pranaya", Gender = "Male", Salary = 5000 },
                new Employee3() { ID = 102, Name = "Priyanka", Gender = "Female", Salary = 7000 },
                new Employee3() { ID = 103, Name = "Anurag", Gender = "Male", Salary = 5500 },
                new Employee3() { ID = 104, Name = "Sambit", Gender = "Male", Salary = 6500 },
                new Employee3() { ID = 105, Name = "Hina", Gender = "Female", Salary = 6500 }
            };
            listEmployees.Sort();
            Console.ReadKey();
        }
    }
    public class Employee3
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}

