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
            //Employee employee = new Employee();
            //employee.ID = "Joe";
            //employee.ID = "Frazier";  // scrapped this idea
            //employee ==

            

            Employee Worker = new Employee();//instantiated Employee
            Worker.firstName = "Deepak";
            Worker.lastName = "Bandhu";
            Worker.SayName();// this is called from Employee
            Console.ReadLine();
        }
    }
}
