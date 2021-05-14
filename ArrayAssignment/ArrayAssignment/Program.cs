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
            string[] dogsArray = { "Labrador", "German Shepard", "Rotweiler", "Bernese Mountain Dog" };

            int[] numArray = { 5, 4, 2, 3 };

            Console.WriteLine("Pick a dog by typing either 0, 1, 2, or 3.");
            int dogInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dogsArray[dogInput]);


            Console.WriteLine("Now please type either 0, 1, 2, or 3 to be assigned a random amount of " + dogsArray[dogInput] + "s.");
            int dogAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You now have " + numArray[dogAmount] + " of your assigned dog type.");

            List<string> myList = new List<string>();

            //LIST OF STRINGS
            myList.Add("A");
            myList.Add("B");
            myList.Add("C");
            myList.Add("D");
            myList.Add("E");
            myList.Add("F");
            myList.Add("G");
            myList.Add("H");

            if (myList.Contains("A"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("A"));
            }
            else if (myList.Contains("B"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("B"));
            }
            else if (myList.Contains("C"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("C"));
            }
            else if (myList.Contains("D"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("D"));
            }
            else if (myList.Contains("E"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("E"));
            }
            else if (myList.Contains("F"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("F"));
            }
            else if (myList.Contains("G"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("G"));
            }
            else if (myList.Contains("H"))
            {
                Console.WriteLine("Yes, exists at index " + myList.IndexOf("H"));
            }
            else
            {
                Console.WriteLine("No, doesn't exists");
            }

            Console.WriteLine("Choose any letter from \"A-H\"");
            string listItem = Console.ReadLine();
            Console.WriteLine(myList);
                


            Console.ReadLine();

            
            

            
        }
    }
}
