using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }// these two are properties

        public void SayName()
        {
            Console.WriteLine("Name:" + FirstName + " " + LastName);
        }
    }
}
