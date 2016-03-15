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
            var numOfLists = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many numbers per list?(less or equal than 10)");
            var elementCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many shuffles?");
            var numOfShuffles = Convert.ToInt32(Console.ReadLine());
            var generatedSortedSet = new SortedSet<int>();
            var random = new Random();
            var totalElements = numOfLists*elementCount;
            for (int i = 0; i < totalElements; i = generatedSortedSet.Count)
            {
                generatedSortedSet.Add(random.Next(0, 101));
            }//do sada radi, izgenerise listu sa numOfLists*elementCount elemenata...
            var generatedList = generatedSortedSet.ToList();
            Console.WriteLine("\n");
            foreach (var element in generatedList)
            {
                Console.Write("{0}, ", element);
            }
            Console.WriteLine("\n");


            var shuffledList = Shuffle.ShuffleListRandomInsert(generatedList);//ako ne napravim novu listu ovde, nece da mi prikaze shuffle-ovano, ZASTO?
            foreach (var element in shuffledList)
            {
                Console.Write("{0}, ", element);
            }
            


        }

        //Izgenerisi brojeve stavi u listu, listoflists*elementCount, SHUFFLE!

    }
}