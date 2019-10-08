using System;

namespace opdracht7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 0;
            int numberB = 0;

            numberA ++;
            ++numberA;
            numberA = numberA + 1;

            numberB--;
            --numberB;
            numberB = numberB - 1;

            if (numberA==3 && numberB==-3)
            {
                Console.WriteLine("Number A: {0}", numberA);
                Console.WriteLine("Number B: {0}", numberB);
                Console.WriteLine("Calculation Complete");
            }
            else
            {
                Console.WriteLine("Calculation Failed");
            }
        }
    }
}
