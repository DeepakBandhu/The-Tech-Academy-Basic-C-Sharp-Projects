using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);//current time when ran

            Console.WriteLine("Number plz:");
            int num = Convert.ToInt32(Console.ReadLine());

            DateTime future = DateTime.Now.AddHours(num);//add hours allows time to be added onto the Now method
            Console.WriteLine(future);
            Console.ReadLine();
        }
    }
}
