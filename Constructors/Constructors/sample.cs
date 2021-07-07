using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class sample
    {
        public string personName;

        public sample() : this("Deepak")
        {

        }

        public sample(string name)
        {
            personName = name;
        }
    }
}
