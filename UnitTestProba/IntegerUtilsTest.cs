using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntegerManipulationPractise;
using System.Collections.Generic;

namespace UnitTestProba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListSorter()
        {
            var actual = false;
            var random = new Random();
            var numberCount = random.Next(100);
            var randomList = new List<int>(IntegerUtils.GetRandomNumbers(numberCount));
            var sortedList = IntegerUtils.ListSorter(randomList);
            for (var i = 0; i < numberCount - 1; i++)
            {
                actual = sortedList[i] < sortedList[i + 1];
                if (!actual) break;
            }
            Assert.IsTrue(actual, "Wrong sorting");
        }


        [TestMethod]
        public void GetRandomNumbers()
        {
            var actual = false;
            var random = new Random();
            var numOfNumbers = random.Next(100);
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
