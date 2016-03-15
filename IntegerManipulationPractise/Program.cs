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
            Console.WriteLine("How many lists?(less or equal than 10)");
            int numOfLists;
            var numOfListsInput = Console.ReadLine();
            while (!int.TryParse(numOfListsInput, out numOfLists) || Convert.ToInt32(numOfLists) > 10)
            {
                Console.WriteLine("Not a valid number, try again.");
                numOfListsInput = Console.ReadLine();
            }

            Console.WriteLine("How many numbers per list?(less or equal than 10)");
            int numOfElements;
            var elementCountInput = Console.ReadLine();
            while (!int.TryParse(elementCountInput, out numOfElements) || Convert.ToInt32(numOfElements) > 10)
            {
                Console.WriteLine("Not a valid number, try again.");
                elementCountInput = Console.ReadLine();
            }

            Console.WriteLine("How many shuffles?");
            int numOfShuffles;
            var numOfShufflesInput = Console.ReadLine();
            while (!int.TryParse(numOfShufflesInput, out numOfShuffles))
            {
                Console.WriteLine("Not a valid number, try again.");
                numOfShufflesInput = Console.ReadLine();
            }

            var generatedSortedSet = new SortedSet<int>();
            var random = new Random();
            var totalElements = numOfLists*numOfElements;
            for (int i = 0; i < totalElements; i = generatedSortedSet.Count)
            {
                generatedSortedSet.Add(random.Next(0, 101));
            } //do sada radi, izgenerise listu sa numOfLists*elementCount elemenata...

            var generatedList = generatedSortedSet.ToList();

            //Console.WriteLine("\n");
            //foreach (var element in generatedList)
            //{
            //    Console.Write("{0}, ", element);
            //}
            //Console.WriteLine("\n");


            //foreach (var element in shuffledList)
            //{
            //    Console.Write("{0}, ", element);
            //}

            var shuffledList = Shuffle.ShuffleListRandomInsert(generatedList);
                //ako ne napravim novu listu ovde, nece da mi prikaze shuffle-ovano, ZASTO?


            for (int i = 0; i < numOfLists; i++)
            {
                Console.Write("\nList no. {0}:\t", i + 1);
                for (int j = 0; j < numOfElements; j++)
                {
                    Console.Write("{0}, ", shuffledList[(i + 1)*(j + 1) - 1]);
                }
            }
        }
    }
}