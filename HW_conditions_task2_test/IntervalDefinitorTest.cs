using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW_conditions_task2;

namespace HW_conditions_task2_test
{
    [TestClass]
    public class IntervalDefinitorTest
    {
        private static List<Interval> BuildTestIntervalsList()
        {
            List<Interval> intervals = new List<Interval>(); 
            intervals.Add(new Interval(0, 14));
            intervals.Add(new Interval(15, 35));
            intervals.Add(new Interval(36, 50));
            intervals.Add(new Interval(50, 100));

            return intervals;
        }

        [TestMethod]
        public void IntervalDefinitor_With_0_14()
        {
            int number = 4;
            List<Interval> actual = (new IntervalDefinitor(BuildTestIntervalsList(), number)).DefineInterval();
            List<Interval> expected = new List<Interval>(1) { new Interval(0, 14) };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntervalDefinitor_With_15_35()
        {
            int number = 15;
            List<Interval> actual = (new IntervalDefinitor(BuildTestIntervalsList(), number)).DefineInterval();
            List<Interval> expected = new List<Interval>(1) { new Interval(15, 35) };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntervalDefinitor_With_36_50()
        {
            int number = 40;
            List<Interval> actual = (new IntervalDefinitor(BuildTestIntervalsList(), number)).DefineInterval();
            List<Interval> expected = new List<Interval>(1) { new Interval(36, 50) };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntervalDefinitor_With_50_100()
        {
            int number = 50;
            List<Interval> actual = (new IntervalDefinitor(BuildTestIntervalsList(), number)).DefineInterval();
            List<Interval> expected = new List<Interval>(2) { new Interval(36, 50), new Interval(50, 100) };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntervalDefinitor_WithOutOfIntervals()
        {
            int number = 1000;
            List<Interval> actual = (new IntervalDefinitor(BuildTestIntervalsList(), number)).DefineInterval();
            List<Interval> expected = new List<Interval>();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
