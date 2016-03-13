using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegerManipulationPractise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many lists?");
            int numOfLists = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many numbers per list?");
            var userCount = Convert.ToInt32(Console.ReadLine());
            var startTime = DateTime.UtcNow;
            var testList = new List<int>();
            for (var i = 0; i < numOfLists; i++)
            {

                var randomList = new List<int>();
                randomList.AddRange(IntegerUtils.GetRandomNumbers(userCount));
                while (randomList.SequenceEqual(testList))  //dva puna dana sam se mucio oko ovoga dok nisam shvatio da .equals i == ne poredi liste clan po clan.........
                {
                    randomList.Clear();
                    randomList.AddRange(IntegerUtils.GetRandomNumbers(userCount));
                }
                testList.Clear();
                testList.AddRange(randomList);

                Console.WriteLine("\nUnsorted list No.{0}: ", i+1);
                foreach (var num in randomList)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("\nSorted List No.{0}: ", i+1);

                var sortedList = IntegerUtils.ListSorter(randomList);

                foreach (var num in sortedList)
                {
                    Console.Write(num + " ");
                }
            }
            var endTime = DateTime.UtcNow;
            var timeElapsed = endTime - startTime; //ne znam odakle da pocnem, ali sada cu da probam da izbrojim BIG O :)
            Console.WriteLine("\n" + timeElapsed);

        }
    }
}