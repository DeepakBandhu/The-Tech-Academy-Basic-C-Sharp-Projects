using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 15;
            //int num2 = 20;

            //string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            //Console.WriteLine(result);
            //Console.ReadLine();

            int roomTemp = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if(currentTemp > roomTemp)
                {
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (roomTemp > currentTemp)
            {
                Console.WriteLine("It is colder than room temperature");
            }
            else
            {
                Console.WriteLine("Teeheeehehehhe");
            }
            Console.ReadLine();
        }
    }
}
