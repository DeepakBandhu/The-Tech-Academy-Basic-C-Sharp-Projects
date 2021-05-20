using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person // this now has to be used in its inherited class 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        public static Employee operator==(Employee employee, Person person)
        {
            employee.ID.Equals(person);
            return employee;
        }                   // these are the overloaded operators, they needed both to not be an error (==, !=)
        public static Employee operator!=(Employee employee, Person person)
        {
            employee.ID.Equals(person);
            return employee;
        }

    }
}
