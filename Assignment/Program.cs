using System;
using static System.Console;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Enter year:");
            WriteLine(GetLeapYearResponse(ReadLine()));
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 100 == 0 && year % 400 == 0) return true;
            if (year % 4 == 0 && year % 100 != 0) return true;
            return false;
        }

        public static string GetLeapYearResponse(string text)
        {
            int year;
            try
            {
                year = int.Parse(text);
                if (IsLeapYear(year)) return "yay";
                else return "nay";
            }
            catch (Exception)
            {
                return "Please input a valid input";
            }
        }


    }
}
