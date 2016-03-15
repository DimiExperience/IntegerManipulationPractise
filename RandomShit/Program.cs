using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomShit
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriteAll("Stefan", "Slavko", "Kurac", "Palac", "Kriminalac", "Jedan", "Dva");
        }

        public static void ConsoleWriteAll(params string[] strings)
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
