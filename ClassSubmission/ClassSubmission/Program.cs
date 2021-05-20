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

            Operations operations = new Operations();//instantiated for the non static class
          
            int a = 50;
            Console.WriteLine("Before method call, value of a : {0}", a);
            Other.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);


            Console.WriteLine("Enter a number to be cut in half:");//not instantiating the static class of Other
            int num1 = Convert.ToInt32(Console.ReadLine());
            operations.perform(num1);


            Console.WriteLine("And one to be added onto by two: ");
            string num2 = Console.ReadLine();
            operations.perform(num2);

            Console.WriteLine(operations.StaticMethod());//caling the last method
           

            Console.ReadLine();

        }
    }
}
