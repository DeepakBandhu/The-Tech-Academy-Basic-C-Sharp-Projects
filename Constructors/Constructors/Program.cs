﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Deepak";

            var date = DateTime.Now;

            sample stuff = new sample();

            Console.WriteLine("Their age is {0}, my name is {1}, and it is {2}.", stuff.Age, name, date );
            Console.ReadLine();
        }
    }
}
