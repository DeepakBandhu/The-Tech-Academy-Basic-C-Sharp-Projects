using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class sample
    {
        public int Age { get; set; }
        public sample() : this(10)
        {
            // No parameter constructor method.// First Constructor  
        }

        public sample(int Age)
        {
            this.Age = Age;
            // Constructor with one parameter.// Second Constructor}  
        }

    }
}
