using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Input: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                //i used my own input because i didnt know how to set up the readline
                decimal num2 = Convert.ToDecimal(20.0543m);

                Console.WriteLine("Enter 3rd Input: ");
                string num3 = Console.ReadLine();

                var mathObjects = new Math();
                var result = mathObjects.MathOperation(num1);
                var result2 = mathObjects.MathOperation(num2);
                var result3 = mathObjects.MathOperation(num3);

                Console.WriteLine("First: " + result + "\nSecond: " + result2 + "\nThird: " + result3);

                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
