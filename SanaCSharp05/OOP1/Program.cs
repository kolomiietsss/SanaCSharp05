using ClassLibrary;
using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var date = new Date(2022, 12, 12, 12, 0);
            var date2 = new Date(date);
            Console.WriteLine(date2 == date);
            var air = new Airplane("w", "t", new Date(2022, 12, 12, 12, 0), new Date(2022, 12, 12, 13, 0));
            Console.WriteLine(air.IsArrivingToday());
            Console.WriteLine(air.GetTotalTime());

        }
    }
}
