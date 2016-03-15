using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManipulationPractise
{
    class Shuffle
    {
        //Take list of numbers, shuffle it, return it...
        public static List<int> ShuffleListRandomInsert(List<int> list)
        {
            var recivedList = list;
            var retVal = new List<int>();
            var random = new Random();
            foreach (var element in recivedList)
            {
                retVal.Insert(random.Next(0, retVal.Count+1), element);//mora +1 zato sto nikada nece prebaciti prvi broj...
            }
            return retVal;
        }

        public static List<int> ShuffleListBackForth(List<int> list, int numOfShuffles)
        {
            var retVal = new List<int>();





            return retVal;
        }



    }
}
