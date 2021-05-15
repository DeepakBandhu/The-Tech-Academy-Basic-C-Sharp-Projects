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
                List<int> intList = new List<int>();
                intList.Add(5);
                intList.Add(10);
                intList.Add(15);
                intList.Add(20);
                intList.Add(25);

                Console.WriteLine("Pick a number to divide a list of numbers one by one.");
                int numberOne = Convert.ToInt32(Console.ReadLine());

                foreach (int item in intList)
                    Console.WriteLine("Here is the output of one of the items divided:\n " + item / numberOne);


                //Console.WriteLine("Dividing the two...");
                //int numberThree = numberOne / numberTwo;
                //Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
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
