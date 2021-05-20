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

    }
}
