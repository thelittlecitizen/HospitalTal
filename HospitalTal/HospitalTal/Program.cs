using System;
using System.Runtime.CompilerServices;

namespace HospitalTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Workers clean = new Cleaner("vla",123, true, false, true, false, false, true);
            Workers toxicCleaner = new ToxicCleaner("bla", 1, 20);
            Console.WriteLine(toxicCleaner.MoneyCalc(5, 20));

        }
    }
}
