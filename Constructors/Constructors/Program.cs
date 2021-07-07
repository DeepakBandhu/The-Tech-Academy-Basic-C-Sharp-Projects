using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Bandhu";

            var date = DateTime.Now;

            sample myName = new sample();

            Console.WriteLine("My name is {0}, my last name is {1}, and it is {2}.", myName.personName, name, date );
            Console.ReadLine();
        }
    }
}
