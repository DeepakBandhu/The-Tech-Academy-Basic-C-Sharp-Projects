using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()// this is usiung the abstract class
        {
            Console.WriteLine("Name:");
            base.SayName();
        }
        public void Quit(Person person)
        {
            Console.WriteLine("I quit.");
        }
    }
}
