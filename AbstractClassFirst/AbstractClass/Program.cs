using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Worker = new Employee();//instantiated Employee
            Worker.firstName = "Sample";
            Worker.lastName = "Student";
            Worker.SayName();// this is called from Employee
            Console.ReadLine();
        }
    }
}
