using System;
using System.Collections.Generic;

namespace HW_conditions_task2
{
    public class IntervalDefinitor
    {
        private List<Interval> _intervals = new List<Interval>();
        private int _number;

        public int Number
        {
            get { return _number; }
        }

        public IntervalDefinitor(List<Interval> intervals, int number)
        {
            _intervals = intervals;
            _number = number;
        }

        public List<Interval> DefineInterval()
        {
            List<Interval> intervalsContainNumber = new List<Interval>();
            foreach (Interval interval in _intervals)
            {
                if (_number >= interval.Begin && _number <= interval.End)
                {
                    intervalsContainNumber.Add(interval);
                }

            }
            return intervalsContainNumber;
        }
    }
}