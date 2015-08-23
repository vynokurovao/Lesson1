using System;
using System.Collections.Generic;

namespace HW_conditions_task2
{
    class Program
    {
        static void DisplayInformation(IntervalDefinitor id)
        {
            List<Interval> intervals = id.DefineInterval();
            if (intervals.Count == 0)
            {
                Console.WriteLine(string.Format("The {0} does not belong to any interval", id.Number));
            }
            else
            {
                foreach (Interval interval in intervals)
                {
                    Console.WriteLine(String.Format("The {0} belongs to [{1} - {2}] interval", id.Number, interval.Begin, interval.End));
                }
            }
        }

        static void Main(string[] args)
        {
            List<Interval> intervals = new List<Interval>(); 
            intervals.Add(new Interval(0, 14));
            intervals.Add(new Interval(15, 35));
            intervals.Add(new Interval(36, 50));
            intervals.Add(new Interval(50, 100));

            Console.WriteLine("Please, enter the integer number from interval 0 .. 100");
            int number = Convert.ToInt32(Console.ReadLine());

            IntervalDefinitor id = new IntervalDefinitor(intervals, number);
            DisplayInformation(id);
            Console.ReadKey();
        }
    }
}
