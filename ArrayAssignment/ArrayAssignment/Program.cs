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
            try
            {
                string[] dogsArray = { "Labrador", "German Shepard", "Rotweiler", "Bernese Mountain Dog" };

                int[] numArray = { 5, 4, 2, 3 };

                Console.WriteLine("Pick a dog by typing either 0, 1, 2, or 3.");
                int dogInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dogsArray[dogInput]);
                //all 3 of the sections here works the same essentially, it asks for the index by typing a number
                Console.WriteLine("Now please type either 0, 1, 2, or 3 to be assigned a random amount of " + dogsArray[dogInput] + "s.");
                int dogAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You now have " + numArray[dogAmount] + " of your assigned dog type.");

                Console.WriteLine("Now please type either 0, 1, 2, or 3 to receive a fruit for your troubles.");
                int fruitSearch = Convert.ToInt32(Console.ReadLine());

                List<string> fruits = new List<string>() { "Apple", "Orange", "Dragon Fruit", "Kiwi" };
                Console.WriteLine(fruits[fruitSearch]);

            }//this section will look for any improper inputs in the program and let the user know what went wrong
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter one of the proper number options.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter one of the proper number options.");
            }



            Console.ReadLine();


        }
    }
}
