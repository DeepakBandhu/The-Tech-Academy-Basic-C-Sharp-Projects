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

            List<string> lastName = new List<string>() { "last", "name", "of", "these", "seven", "emnployess", "aadadawdaf" };

            List<int> ID = new List<int>() { 1, 2, 3, 6, 9, 7, 4 };
            List<string> copy = new List<string>() { };
            List<int> numbers = new List<int>() { };

            string names = firstName.Where(x => x == "Joe").ToList(copy);

            int ids = ID.Where(x => x > 5).ToList(numbers);

            //foreach(string name in firstName)
            //{
            //    if(name == "Joe")         // the for loop to complete step 2
            //    {
            //        copy.Add(name);
            //        Console.WriteLine(name);
            //    }
            //}
            Console.ReadLine(ids);
        }
    }
}
