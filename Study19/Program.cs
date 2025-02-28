using System;
using System.Data;

namespace Study19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");

            TimeSpan duration = new TimeSpan(1,30,0);
            Console.WriteLine($"Duration : {duration}");
        }
    }
}