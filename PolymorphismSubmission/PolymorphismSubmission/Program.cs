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
            
            employee.Quit(person);

            Console.WriteLine(employee.firstName + " " + employee.lastName);
            Console.ReadLine();
        }
    }
}
