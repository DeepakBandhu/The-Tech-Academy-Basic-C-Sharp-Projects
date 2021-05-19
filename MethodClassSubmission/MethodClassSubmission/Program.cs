using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            //int a = 2;
            //int b = 21;

            Parameters n = new Parameters();
            // i instantiated the object above and now i called a method on the object below.
            Console.WriteLine("Here is the value that was supoposed to be printed to the screen.");
            n.twoMaths(int1: 4, int2: 20);
            Console.ReadLine();
          
        }
    }
}
