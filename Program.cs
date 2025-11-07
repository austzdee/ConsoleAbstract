using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleAbstract
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating an instance of Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();

            // using Polymorphism to create an object of IQuittable interface
            IQuittable quittableEmployee = new Employee();
            //calling the Quit method
            quittableEmployee.Quit();

        }
    }
}