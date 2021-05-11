using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int personAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            bool personDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int personTickets = Convert.ToInt32(Console.ReadLine());

            //this code will see if all of inputs make the person eligible or not
            bool ifEligible = personAge > 15 && personDUI == false && personTickets <= 3;

            Console.WriteLine("Qualified?");
            Console.WriteLine(ifEligible);
            Console.ReadLine();
        }
    }
}
