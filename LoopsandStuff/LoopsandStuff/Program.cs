using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsandStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my age.");
            int age = Convert.ToInt32(Console.ReadLine());

            bool ageGuessed = age == 21;

            do
            {
                switch (age)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Too high, try again.");
                        Console.WriteLine("Guess my age");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Very close, stay in the 20's, try again.");
                        Console.WriteLine("Guess my age");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 21:
                        Console.WriteLine("Good job, I am indeed 21 years old.");
                        ageGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess my age");
                        age = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!ageGuessed);

            Console.Read();
        }
    }
}
