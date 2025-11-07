using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstract
{
    public class Employee<T> : Person, IQuittable
    {
        //Create an Employee class with Id.
        public T Id { get; set; }

        // Creating a property of Employee class 'things' which is a generic list of type T
        public List<T> Things { get; set; } = new List<T>();

        //implementing the abstract method
        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override void SayName()
        {
            //Printing the employee details
            Console.WriteLine("Employee Details:");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Things: ");
                {
                //Iterating through the Things list and printing each item
                foreach (T thing in Things)
                    {
                        Console.WriteLine("- " + thing);
                    }
            }
            

        }
        //Implementing the Quit method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quitted.");
        }

        //Overloading the == operator to compare two Employee objects based on their Id property
        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
        {
            // Check for comparison of Employee ids
            if (ReferenceEquals(employee1, employee2)) return true;
            if(employee1 is null || employee2 is null) return false;

            return EqualityComparer<T>.Default.Equals(employee1.Id, employee2.Id);
        }
        //Overloading the != operator to compare two Employee objects based on their Id property
        public static bool operator !=(Employee<T>? employee1, Employee<T>? employee2)
        {
            return !(employee1 == employee2);
        }
            public override bool Equals(object? obj)
        {
            return obj is Employee<T> employee && this == employee;
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Id);
        }



    }
}
