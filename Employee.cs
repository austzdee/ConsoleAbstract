using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstract
{
    public class Employee : Person, IQuittable
    {
        //Create an Employee class with Id.

        public int Id { get; set; }

        //implementing the abstract method
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }
        //Implementing the Quit method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quitted.");
        }

        //Overloading the == operator to compare two Employee objects based on their Id property
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check for null to avoid NullReferenceException
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("Both employees have the same ID.");
            }
            else
            {
                Console.WriteLine("Employees have different IDs.");
            }
            return employee1.Id == employee2.Id;
        }
        //Overloading the != operator to compare two Employee objects based on their Id property
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Check for null to avoid NullReferenceException
            if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("Employees have different IDs.");
            }
            else
            {
                Console.WriteLine("Both employees have the same ID.");
            }
            // Return the comparison result
            return employee1.Id != employee2.Id;
        }


    }
}
