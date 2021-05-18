using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Math
    {
        public int MathOperation(int data)
        {
            int newData = data + 5;
            return (newData);
        }

        public decimal MathOperation(decimal data)
        {
            decimal newData = 20.5m - data;
            return (newData);
        }

        public static string MathOperation(string data)
        {
            Console.WriteLine("Enter a number");
            data = Console.ReadLine();
            int newData = Convert.ToInt32(data);
            return newData;
        }
    }
}
