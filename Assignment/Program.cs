using System;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 == 0) return true;
            if (year % 4 == 0 && year % 100 != 0) return true;
            return false;
        }
    }
}
