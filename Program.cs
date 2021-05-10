using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1(Please Enter the Corresponding Information:");
            Console.WriteLine("Hourly Rate");
            decimal personOneRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Hours Worked Per Week");
            int personOneHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2(Please Enter the Corresponding Information:");
            Console.WriteLine("Hourly Rate");
            decimal personTwoRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Hours Worked Per Week");
            int personTwoHours = Convert.ToInt32(Console.ReadLine());

            int oneSalary = personOneHours * (Int32)personOneRate;
            //52 Working weeks in a year
            int oneFinalSalary = oneSalary * 52;
            Console.WriteLine("Person 1's annual salary: " + oneFinalSalary);

            int twoSalary = personTwoHours * (Int32)personTwoRate;
            int twoFinalSalary = twoSalary * 52;
            Console.WriteLine("Person 2's annual salary: " + twoFinalSalary);

            bool greaterSalary = oneFinalSalary > twoFinalSalary;
            Console.WriteLine("Does Person 1 make more money than Person 2?\r\n" + greaterSalary);
            Console.ReadLine();
        }
    }
}
