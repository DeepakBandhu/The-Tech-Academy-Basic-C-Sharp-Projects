using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input:");

            string line = Console.ReadLine();
            Data = Int32.Parse(line);

            var operatorObject = new Operator();
            //call the 3 methods to produce the results
            var result = operatorObject.GetAdd(Data);
            var result2 = operatorObject.GetDivide(Data);
            var result3 = operatorObject.GetSubtract(Data);
            Console.WriteLine("Here is result 1" + result + "\nHere is result 2" + result2 + "\nand finally result 3" + result3);


            Console.ReadLine();
        }
    }
}
