using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleAbstract
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating an instance of Employee in string
            List<Employee<string>> employees = new List<Employee<string>>
            {
               new Employee<string> { Id = "E001", FirstName = "Joe", LastName = "Anderson", Things = new List<string> { "Laptop" } },
               new Employee<string> { Id = "E002", FirstName = "Joe", LastName = "Brown", Things = new List<string> { "Notebook" } },
               new Employee<string> { Id = "E003", FirstName = "Alice", LastName = "Smith", Things = new List<string> { "Pen" } },
               new Employee<string> { Id = "E004", FirstName = "Bob", LastName = "Taylor", Things = new List<string> { "Tablet" } },
               new Employee<string> { Id = "E005", FirstName = "Carol", LastName = "White", Things = new List<string> { "Phone" } },
               new Employee<string> { Id = "E006", FirstName = "David", LastName = "Green", Things = new List<string> { "Charger" } },
               new Employee<string> { Id = "E007", FirstName = "Eve", LastName = "Black", Things = new List<string> { "Mouse" } },
               new Employee<string> { Id = "E008", FirstName = "Frank", LastName = "Gray", Things = new List<string> { "Keyboard" } },
               new Employee<string> { Id = "E009", FirstName = "Grace", LastName = "Stone", Things = new List<string> { "Monitor" } },
               new Employee<string> { Id = "E010", FirstName = "Hank", LastName = "Wood", Things = new List<string> { "Desk" } }
                
               // Using a foreach loop, create a new list of all employees with the first name “Joe”.

            };


            foreach (Employee<string> emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    Console.WriteLine($"Employee ID: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
                }
            };






            //employee.SayName();



            //// using Polymorphism to create an object of IQuittable interface
            //IQuittable quittableEmployee = new Employee<int>();
            //Employee<int> employee1 = new Employee<int>() { Id = 1, FirstName = "John", LastName = "Doe" };
            //Employee<int> employee2 = new Employee<int>() { Id = 1, FirstName = "Jane", LastName = "Smith" };

            ////Comparing two Employee objects using overloaded == operator
            //bool areEqual = employee1 == employee2;
            //Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);
            ////calling the Quit method
            //quittableEmployee.Quit();

        }
    }
}