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
            Employee<string> employee = new Employee<string>()
            {
                Id = "E001",
                FirstName = "John",
                LastName = "Doe",
                Things = new List<string> { "Laptop", "Notebook", "Pen" }
            };
           
            employee.SayName();

            Employee<int> employeeInt = new Employee<int>()
            {
                Id = 1001,
                FirstName = "Alice",
                LastName = "Smith",
                Things = new List<int> { 10, 20, 30 }
            };
            employeeInt.SayName();

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