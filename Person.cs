using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstract
{
    //createing an abstract class Person
    public abstract class Person
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        //abstract method
        public abstract void SayName();
    }
}
