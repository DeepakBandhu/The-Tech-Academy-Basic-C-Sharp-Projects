using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Operator
    {
        //using double allows the Get functions ot not be classes but im not sure if that is correct
        public double GetAdd(int data)
        {
            int newData = data + 3;
            return (newData);
        }

        public double GetSubtract(int data)
        {
            int newData = data - 3;
            return (newData);
        }

        public double GetDivide(int data)
        {
            int newData = data / 3;
            return (newData);
        }
    }
}
