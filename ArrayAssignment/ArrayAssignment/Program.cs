using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] dogsArray = { "Labrador", "German Shepard", "Rotweiler", "Bernese Mountain Dog" };

            //int[] numArray = { 5, 4, 2, 3 };

            //Console.WriteLine("Pick a dog by typing either 0, 1, 2, or 3.");
            //int dogInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(dogsArray[dogInput]);


            //Console.WriteLine("Now please type either 0, 1, 2, or 3 to be assigned a random amount of " + dogsArray[dogInput] + "s.");
            //int dogAmount = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You now have " + numArray[dogAmount] + " of your assigned dog type.");


            Console.WriteLine("Now please type either 0, 1, 2, or 3 to receive a fruit.");
            int fruitSearch = Convert.ToInt32(Console.ReadLine());

            List<string> fruits = new List<string>() { "Apple", "Orange", "Dragon Fruit", "Kiwi" };
            bool matchFound = false;

            foreach (string fruit in fruits)
            {

                if (fruitSearch == fruits) 
                {
                    matchFound = true;
                    Console.WriteLine();
                    break;
                }

            }
            if (matchFound == false)
            {
                Console.WriteLine("No match, try again.");
            }
            Console.ReadLine();


        }
    }
}
