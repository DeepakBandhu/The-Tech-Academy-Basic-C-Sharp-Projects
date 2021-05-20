using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations math = new Operations();

            int a = 50;
            Console.WriteLine("Before method call, value of a : {0}", a);
            math.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);


            Console.WriteLine("Enter a number to be cut in half:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            math.perform(num1);


            Console.WriteLine("And one to be added onto by two: ");
            string num2 = Console.ReadLine();
            math.perform(num2);

            Operations instance = new Operations();
            Console.WriteLine(Operations.StaticMethod());
           

            Console.ReadLine();

        }
    }
}
