using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Operations
    {
        public void perform(int data)
        {
            int newData = data / 2;
            Console.WriteLine(newData);
        }
        public void perform(string data)
        {
            int newData = int.Parse(data);
            int result = newData + 2;
            Console.WriteLine(result.ToString());
        }

        public int StaticMethod() { return 42; }
    }
}
