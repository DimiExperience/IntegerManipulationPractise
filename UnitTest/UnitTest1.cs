using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerManipulationPractise;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListSorter()
        {
            var actual = false;
            var randomList = new List<int>();
            var random = new Random();
            var numberCount = random.Next(100);
            randomList.AddRange(IntegerUtils.GetRandomNumbers(numberCount));
            var sortedList = IntegerUtils.ListSorter(randomList);
            for (var i = 0; i < numberCount - 1; i++)
            {
                if (sortedList[i] < sortedList[i + 1])
                {
                    actual = true;
                }
                else
                {
                    actual = false;
                }
            }
            Assert.IsTrue(actual, "Passed:)");
        }


        [TestMethod]
        public void GetRandomNumbers()
        {
            var actual = false;
            var random = new Random();
            var numOfNumbers = random.Next(500);
            var randomList = new List<int>();
            randomList.AddRange(IntegerUtils.GetRandomNumbers(numOfNumbers));
            if (randomList.Count == numOfNumbers)
            {
                actual = true;
            }
            Assert.IsTrue(actual, "Wrong numbers of numbers");
        }
    }
}
