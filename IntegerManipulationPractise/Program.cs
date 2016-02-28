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
            var startTime = DateTime.UtcNow;

            Console.WriteLine("How many lists?");
            int numOfLists = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < numOfLists; i++)
            {
                Thread.Sleep(10); //HAHA, btw, morao sam da mu stavim sleep da ne bi ponovio liste:) mnogo mi je brz komp:P

                var randomList = new List<int>();
                randomList.AddRange(IntegerUtils.GetRandomNumbers());
                    //ZASTO MORAM DA PISEM IntegerUtils, zasto ne moze samo GetRandomNumbers()???????

                Console.WriteLine("\nUnsorted list No.{0}: ", i+1);
                foreach (var num in randomList)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine("\nSorted List No.{0}: ", i+1);

                var sortedList = IntegerUtils.ListSorter(randomList);
                    //ISTO PITANJE I OVDE, zasto ne moze bez IntegerUtils.?

                foreach (var num in sortedList)
                {
                    Console.Write(num + " ");
                }
            }
            var endTime = DateTime.UtcNow;//ne znam odakle da pocnem, ali sada cu da probam da izbrojim BIG O :)
            var timeElapsed = endTime - startTime;
            Console.WriteLine("\n" + timeElapsed);

        }
    }
}