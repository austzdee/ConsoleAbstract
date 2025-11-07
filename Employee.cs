using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstract
{
    public class Employee : Person, IQuittable
    {
        //implementing the abstract method

        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quitted.");
        }

    }
}
