using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array size?");
            int.TryParse(Console.ReadLine(), out int arraySize);
            Console.WriteLine("Int size?");
            int.TryParse(Console.ReadLine(), out int maxValue);

            void generate(int size, int value)
            {
                int[] numberArray = new int[arraySize];
                Random randNum = new Random();
                for (int i = 0; i < numberArray.Length; i++)
                {
                    numberArray[i] = randNum.Next(1, maxValue);
                    Console.WriteLine("{0}", numberArray[i]);
                }
            }
            generate(arraySize, maxValue);
        }
    }
}
