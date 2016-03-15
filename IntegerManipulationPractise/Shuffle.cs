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
            //ovaj shuffle treba da se bavi sa 0/1 tacnije da stavlja pre ili posle, 
            //ali bih odradio da ima jos jedan random, koji ce da odredjuje koliko bi brojeva stavljao pre ili posle, 
            //znaci 0/1 odredjuje da li sledeci broj stavlja pre ili posle proslog, a random od npr 1-5 ili tako nesto
            //odredjuje koliko brojeva ce da stavlja, kao kada mesas karte... a na kraju, mogu da se povezu ova dva
            //shuffle-a i da se napravi jedan koji radi sve, i totalno izmesa:)
            var retVal = new List<int>();





            return retVal;
        }



    }
}
