using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int data1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number, OR leave blank:");
                string data2 = Console.ReadLine();

                var objects = new TwoInts();

                if (data2 == "")
                {
                    var result = objects.twoMaths(data1);
                    Console.WriteLine(result);
                }

                
                else
                {
                    Convert.ToInt32(data2);
                    var result2 = objects.twoMaths(data1, data2);//i dont know why this is wrong
                    Console.WriteLine(result2);
                }

          
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
