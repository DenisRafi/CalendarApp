//-By Denis Rafi

using System;

namespace CalendarApp
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i < 13; i++)
            {
                var month = new DateTime(2010, i, 1);
                var headingSpaces = new string(' ', 16 - month.ToString("MMMM").Length);
                Console.WriteLine($"{month.ToString("MMMM")}{headingSpaces}{month.Year}");
                Console.WriteLine();
                Console.WriteLine(" S  M  T  W  T  F  S ");
                var padLeftDays = (int)month.DayOfWeek;
                var currentDay = month;
                var iterations = DateTime.DaysInMonth(month.Year, month.Month) + padLeftDays;
                for (int j = 0; j < iterations; j++)
                {
                    if (j < padLeftDays)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write($"{currentDay.Day.ToString().PadLeft(2, ' ')} ");

                        if ((j + 1) % 7 == 0)
                        {
                            Console.WriteLine();
                        }
                        currentDay = currentDay.AddDays(1);
                    }
                }
                Console.WriteLine("\n");              
            }
            Console.ReadKey();
        }
    }
}