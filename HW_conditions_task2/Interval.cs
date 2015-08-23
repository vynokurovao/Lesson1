using System;

namespace HW_conditions_task2
{
    public struct Interval
    {
        private int _begin;
        private int _end;

        public int Begin
        {
            get { return _begin;}
            set { _begin = value;}
        }

        public int End
        {
            get { return _end;}
            set { _end = value;}
        }

        public Interval(int begin, int end)
        {
            _begin = begin;
            _end = end;
        }
    }
}
