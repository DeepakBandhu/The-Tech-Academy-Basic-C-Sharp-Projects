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
            decimal newData = Convert.ToInt32(Console.ReadLine());
            int newMath = newData - data;
            return (newMath);
        }

        internal string MathOperation(string data)
        {
            data = Console.ReadLine();
            int myVal = Convert.ToInt32(data);
            return data;
        }

    }
}
