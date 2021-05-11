using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.\r\nStudent Daily Report");
            //user name(string)
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            //what course are they on(string)
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            //page number(int)
            Console.WriteLine("What page number are you on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            //any help(string)
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool anyHelp = Convert.ToBoolean(Console.ReadLine());
            //feedback(string)
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string anyExperience = Console.ReadLine();
            //hours of study today(int)
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            //Outro Message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
