using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public static class Operator
    {
        //using double allows the Get functions ot not be classes but im not sure if that is correct
        public static double GetAdd(int data)
        {
            int newData = data + 3;
            return (newData);
        }

        public static double GetSubtract(int data)// making the class static required everything else to be static
        {
            int newData = data - 3;
            return (newData);
        }

        public static double GetDivide(int data)
        {
            int newData = data / 3;
            return (newData);
        }
    }
}
