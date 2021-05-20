using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the day of the week.");
                string dayOf = Console.ReadLine();

                Console.WriteLine();

               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            

            Console.ReadLine();

        }

    }
    enum WeekDays
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
}

