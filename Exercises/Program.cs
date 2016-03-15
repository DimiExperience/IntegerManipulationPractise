using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "abc";
            var z = x;
            var y = "abc";
            Console.WriteLine("{0},{1},{2}", x.GetHashCode(), y.GetHashCode(), z.GetHashCode());
            Console.WriteLine("{0},{1}", x.Equals(y), x.Equals(z));
        }
    }

    public class Bullshit
    {
        
    }
}
