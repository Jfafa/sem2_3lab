using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(170, 40);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "SimpleTitle";
            Console.Beep();


            Console.WriteLine("Input your name: ");
            string s = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", s);
            DateTime dt = DateTime.Now;
            Console.WriteLine("Today is {0}. {1:D2}.{2:D2}.{3:D2}", dt.DayOfWeek, dt.Day, dt.Month, dt.Year);
            Console.WriteLine("Current time is: {0}:{1}", dt.Hour, dt.Minute);
            Console.WriteLine("Days to new year: {0}", 365-dt.DayOfYear);

        }
    }
}
