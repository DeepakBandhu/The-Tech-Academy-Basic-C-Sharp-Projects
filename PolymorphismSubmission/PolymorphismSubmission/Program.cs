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
            IQuittable object1 = new Employee();
            //person.
            Employee employee = new Employee();//instantiation for use
            employee.firstName = "Deepak";
            employee.lastName = "Bandhu";

            object1.Quit(employee);
            Console.WriteLine(employee.firstName + " " + employee.lastName);
            Console.ReadLine();
        }
    }
}
