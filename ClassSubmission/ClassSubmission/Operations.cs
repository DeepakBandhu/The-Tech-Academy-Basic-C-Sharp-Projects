using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public static class Operations
    {
        public static void perform(int data)
        {
            int newData = data / 2;
            Console.WriteLine(newData);
        }
        public static void perform(string data)//making the class static requires everything to be static
        {
            int newData = int.Parse(data);
            int result = newData + 2;
            Console.WriteLine(result.ToString());
        }
        public static void getValue(out int x)
        {
            int temp = 5 * 2;
            x = temp;
        }

        public static int StaticMethod() { return 42; }
    }
}
