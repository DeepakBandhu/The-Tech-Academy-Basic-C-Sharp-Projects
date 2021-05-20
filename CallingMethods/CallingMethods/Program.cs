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

            int Data = Convert.ToInt32(Console.ReadLine());// changed the input to a readline instead of a parse due to an error
            //Data = Int32.Parse(line);

            //call the 3 methods to produce the results
            var result = Operator.GetAdd(Data);
            var result2 = Operator.GetDivide(Data);//instead of having to instantiate, I was able to just use the class itself
            var result3 = Operator.GetSubtract(Data);
            Console.WriteLine("Here is result 1: " + result + "\nHere is result 2: " + result2 + "\nand finally result 3: " + result3);


            Console.ReadLine();
        }
    }
}
