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
            employee.ID = 2;
            //Person person = new Employee();
            employee.ID = 1;

            //employee.ID == employee.ID;
            //employee.ID != employee.ID;

            Console.WriteLine(employee.ID == employee.ID);
            Console.WriteLine(employee.ID != employee.ID);


            Console.ReadLine();

            //Employee Worker = new Employee();//instantiated Employee
            //Worker.firstName = "Deepak";
            //Worker.lastName = "Bandhu";
            //Worker.SayName();// this is called from Employee

        }
    }
}
