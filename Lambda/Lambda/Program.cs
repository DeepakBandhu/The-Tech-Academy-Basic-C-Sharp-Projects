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
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {ID = 1, firstname = "Joe", lastname = "Person"},
                new Employee() {ID = 6, firstname = "Joe", lastname = "People"},
                new Employee() {ID = 8, firstname = "Deepak", lastname = "Bandhu"},
                new Employee() {ID = 2, firstname = "Jack", lastname = "Jill"},
                new Employee() {ID = 5, firstname = "Rachel", lastname = "Brooks"},
                new Employee() {ID = 4, firstname = "Tessa", lastname = "Lamb"},
                new Employee() {ID = 10, firstname = "Mike", lastname = "Pablo"},
                new Employee() {ID = 20, firstname = "Ashely", lastname = "Anotherone1"},
                new Employee() {ID = 3, firstname = "Name", lastname = "Lastname"},
            };

            List<Employee> dupes = new List<Employee>();

            foreach (var name in employees)
            {// foreach loop for finding Joe
                if (name.firstname == "Joe")
                {
                    dupes.Add(name);
                    Console.WriteLine("{0}", name.firstname);
                }

            }

            var newdupes = employees.Select(x => x.firstname);

            foreach (var joes in newdupes)//lambda for joe
            {
                if (joes == "Joe")
                {
                    Console.WriteLine("\n{0}", joes);
                }
            }



            var ids = employees.Select(x => x.ID);
            foreach(var newid in ids)
            {
                if (newid > 5)
                {
                    Console.WriteLine("\n{0}", newid);
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
