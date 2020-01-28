using System;

namespace opdracht4
{
    public class Player
    {
            public Player(string input, int number, int num)
            {
                Console.WriteLine(input);
                Console.WriteLine("We are number {0}", number);
                int result = number + num;
                Console.WriteLine("{0} + {1} = {2}!", number, num, result);
            }
    }
}
