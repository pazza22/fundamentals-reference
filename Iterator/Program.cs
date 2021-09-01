using Iterator.Blueprint.DaysInMonth;
using System;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Iterator for a linear structure
            DaysInMonthCollection collection = new DaysInMonthCollection();
            foreach (MonthWithDays monthWithDays in collection)
            {
                Console.WriteLine($"Days in {monthWithDays.Date} - {monthWithDays.Days}");
            }

            //To do: Tree structure
        }
    }
}
