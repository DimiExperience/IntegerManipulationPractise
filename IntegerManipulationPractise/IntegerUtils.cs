using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManipulationPractise
{
    public class IntegerUtils
    {
        public static List<int> ListSorter(List<int> list)
        {
            var givenNumbers = list;

            var sortedNumbers = new List<int> {givenNumbers[0]};
            givenNumbers.RemoveAt(0);

            foreach (var number in givenNumbers)
            {
                var foundNumber = false;
                for (var i = sortedNumbers.Count; i > 0; i--)
                {
                    if (number > sortedNumbers[i - 1])
                    {
                        foundNumber = true;
                        sortedNumbers.Insert(i, number);
                        break;
                    }
                }
                if (!foundNumber)
                {
                    sortedNumbers.Insert(0, number);
                }
            }
            return sortedNumbers;
        }

        public static List<int> GetRandomNumbers()
        {
            var count = 10;
            var random = new Random();
            var randomNumbers = new List<int>();

            for (var i = 0; i < count; i++)
            {
                int number;

                do number = random.Next(100); while (randomNumbers.Contains(number));

                randomNumbers.Add(number);
            }

            return randomNumbers;
        }
    }
}