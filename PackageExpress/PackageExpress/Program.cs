using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int productPackage = (packageHeight * packageWidth * packageLength) * packageWeight;

            decimal totalCost = productPackage / 100;

            if (packageWeight > 50 || packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via package express.");
                return;
            }
            else if (packageWeight <= 50)
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + totalCost + ".00" + "\r\nThank you for your patronage!");
            }

            Console.ReadLine();
        }
    }
}
