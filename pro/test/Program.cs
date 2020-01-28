using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double bsn = 1234567;
            bsn = Math.Floor(Math.Log10(bsn) + 1);
            Console.WriteLine(bsn);
            Console.ReadKey();
        }
    }
}
