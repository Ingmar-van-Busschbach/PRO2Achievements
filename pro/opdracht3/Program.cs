using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            do {
                Console.WriteLine("input?");
                writeToFile(Console.ReadLine());
                Console.WriteLine("Saved. type Y to repeat or press enter to exit");
            } while (Console.ReadLine() == "Y");

            void writeToFile(string Input)
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\Documenten\ma\bewijzenmap\periode1.2\pro2\opdracht3\Output.txt", true))
                {
                    file.WriteLine(Input);
                }
            }
        }
    }
}
