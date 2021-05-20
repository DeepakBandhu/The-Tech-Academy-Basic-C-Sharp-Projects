using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        public override void SayName()// this is usiung the abstract class
        {
            Console.WriteLine("Name:");
            base.SayName();
        }
    }
}
