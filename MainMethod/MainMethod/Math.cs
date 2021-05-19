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
        {//int input
            int newData = data + 5;
            return (newData);
        }

        public decimal MathOperation(decimal data)
        {//decimal input
            int newData = decimal.ToInt32(data);
            int result = (int)(newData + 2.2m);
            return (result);
        }

        public string MathOperation(string data)
        {//string input
            int newData = int.Parse(data);
            int result = newData - 2;
            return result.ToString();
           
        }

    }
}
