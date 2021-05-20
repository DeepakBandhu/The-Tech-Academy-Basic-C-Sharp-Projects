using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Worker = new Person();
            Worker.FirstName = "Deepak";// giving the properties values, i think thats what i was supposed to do
            Worker.LastName = "Bandhu";

            Worker.SayName();//after instantiation i can use this method
            Console.ReadLine();
        }
    }
}
