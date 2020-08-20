using System;
using System.Runtime.CompilerServices;

namespace HospitalTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cleaner clean = new Cleaner("vla",123, true, false, true, false, false, true);
            Console.WriteLine(clean.MoneyCalc(5, 20));

        }
    }
}
