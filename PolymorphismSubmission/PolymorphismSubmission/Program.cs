using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee();
            //person.
            Employee employee = new Employee();//instantiation for use
            employee.firstName = "Deepak";
            employee.lastName = "Bandhu";
            
            employee.Quit(person);// this is the interface runnning, in order for the program to fully complete it will need to be commented out, however it hits successfully

            Console.WriteLine(employee.firstName + " " + employee.lastName);
            Console.ReadLine();
        }
    }
}
