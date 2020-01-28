using System;

namespace classAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            Teacher t1 = new Teacher("Erwin", "PRO2");
            Teacher t2 = new Teacher("Erik", "PRO2");
            Teacher t3 = new Teacher("Theo", "PRO1");
            Teacher t4 = new Teacher("Milos", "WVO");

            Student s1 = new Student("Harry", "Mediadeveloper");
            Student s2 = new Student("Donny", "Gamedeveloper");
            Student s3 = new Student("Ingmar", "Gamedeveloper");

            Parent p1 = new Parent("Erik", "Ingmar");

            while (exit)
            {
                string input = Console.ReadLine();
                args = input.Split(" ");
                if (args.Length == 3)
                {
                    Parent p2 = new Parent(args[0], args[1], args[1], args[2]);
                }
                else if (args.Length == 2)
                {
                    Parent p2 = new Parent(args[0], args[1]);
                }
                else
                {
                    Console.WriteLine("input error!");
                }
                Console.WriteLine("Type 'exit' to exit. Press enter to continue");
                string input2 = Console.ReadLine();
                if (input2 == "exit")
                {
                    exit = false;
                }
            }
        }
    }
}
