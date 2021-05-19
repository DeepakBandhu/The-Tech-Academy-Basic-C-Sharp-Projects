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
                int data2 = Convert.ToInt32(Console.ReadLine());

                if (data2 == null)
                {
                    data2 = 5;
                }

                var objects = new TwoInts();
                var result = objects.twoMaths(data1, data2);

                Console.WriteLine(result);
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
