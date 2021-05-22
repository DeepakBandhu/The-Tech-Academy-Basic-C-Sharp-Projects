using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            List<string> firstName = new List<string>() { "dadadad", "fadaw", "feawq", "vvrgg", "Joe", "Joe", "geafes" };

            foreach (var name in firstName)
            {// foreach loop for finding Joe
                if (name == "Joe")
                {
                    Console.WriteLine(name);
                }
               
            }

            List<string> first = firstName.FindAll(x => x =="Joe" );
            foreach(var firsts in first)//lambda for joe
            {
                Console.Write(" {0} ", firsts);
            }



            List<int> employeeID = new List<int>() { 1, 2, 3, 6, 9, 7, 4 };
            List<int> ids = employeeID.FindAll(x => x > 5);
            //lambda for finding ids > 5
            foreach (var id in ids)
            {
                Console.Write(" {0} ", id);
            }

            Console.WriteLine();
            Console.Read();
        }

    }
}
