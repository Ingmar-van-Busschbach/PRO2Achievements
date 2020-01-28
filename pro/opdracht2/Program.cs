using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator rules:");
            Console.WriteLine("");
            Console.WriteLine("Always use spaces");
            Console.WriteLine("Example: 1 + 2 + 3 + 4 + 5");
            Console.WriteLine("");
            Console.WriteLine("Only use 2 numbers and 1 calculation method");
            Console.WriteLine("Example: 2 * 3");
            Console.WriteLine("");
            Console.WriteLine("Allowed methods:");
            Console.WriteLine("+, -, *, /, % (modulus)");
            Console.WriteLine("");
            Console.WriteLine("Press enter to calculate");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Press any button to start");
            Console.ReadKey();
            string restart = "yes";
            while(restart == "yes")
            {
                Console.Clear();
                Console.WriteLine("Input?");
                string input = Console.ReadLine();
                args = input.Split(" ");
                Console.WriteLine(calculate(Convert.ToInt32(args[0]), args[1], Convert.ToInt32(args[2])));
                Console.WriteLine("Run another calculation? (input: yes)");
                restart = Console.ReadLine();
            }

            int calculate(int a, string mode, int b)
            {
                int ans = 0;
                switch(mode)
                {
                    case "+":
                        ans = a + b;
                        break;
                    case "-":
                        ans = a - b;
                        break;
                    case "*":
                        ans = a * b;
                        break;
                    case "/":
                        ans = a / b;
                        break;
                    case "%":
                        ans = a % b;
                        break;
                }
                return ans;
            }
        }
    }
}
