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
          
            int a = 50;
            Console.WriteLine("Before method call, value of a : {0}", a);
            Operations.getValue(out a);//removed the instantiation

            Console.WriteLine("After method call, value of a : {0}", a);


            Console.WriteLine("Enter a number to be cut in half:");//instead of instantiating the class, I can just use it directly since it is now static
            int num1 = Convert.ToInt32(Console.ReadLine());
            Operations.perform(num1);


            Console.WriteLine("And one to be added onto by two: ");
            string num2 = Console.ReadLine();
            Operations.perform(num2);

            Console.WriteLine(Operations.StaticMethod());//caling the last method
           

            Console.ReadLine();

        }
    }
}
