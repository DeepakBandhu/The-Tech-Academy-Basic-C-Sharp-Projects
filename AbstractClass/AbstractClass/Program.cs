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
            Employee employee = new Employee();
            employee.ID = "Joe";
            //Person person = new Employee();
            employee.ID = "Deepak";

            employee.ID == employee.ID;

            Console.WriteLine();

            Console.ReadLine();

            //Employee Worker = new Employee();//instantiated Employee
            //Worker.firstName = "Deepak";
            //Worker.lastName = "Bandhu";
            //Worker.SayName();// this is called from Employee

        }
    }
}
