using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch(FormatException ex)
            {//this will run if a string is entered
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch(DivideByZeroException ex)
            {//this will run if a 0 is entered
                Console.WriteLine("Please don't divide by zero.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally//this will always run, I chose not to add a database log to it
            {
                Console.ReadLine();
            }
        }
    }
}
