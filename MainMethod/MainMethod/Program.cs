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

                string line = Console.ReadLine();
                Data = Int32.Parse(line);

                var mathObjects = new Math();
                var result = mathObjects.MathOperation(Data);
                var result2 = mathObjects.MathOperation(Data);

                Console.WriteLine("Here is the result: " + result2);

                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter a whole number");
                Console.ReadLine();
            }
        }
    }
}
