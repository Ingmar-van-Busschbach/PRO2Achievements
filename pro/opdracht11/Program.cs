using System;

using NameSpace2;

namespace opdracht11
{
    class Program : SubClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start value: 10.");
            Console.WriteLine("Output value 1: 20.");
            Console.WriteLine("Output value 2: 30.");
            Console.WriteLine("Output value '2 static': 40.");
            Console.WriteLine("Output value 3 & '3 inherited': 50.");
            Console.WriteLine("Output value '3 static': 60.");
            Console.WriteLine("Output value 4 & '4 class': 70.");
            Console.WriteLine("Output value '4 subclass': 80.");

            bool exit = false;
            int start = 10;
            int output = 0;

            Constructor construct = new Constructor();
            SubClass sub = new SubClass();

            while (exit == false)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        output = start + Function1();
                        Console.WriteLine(output);
                        break;
                    case "2":
                        output = start + sub.Function2();
                        Console.WriteLine(output);
                        break;
                    case "2 static":
                        output = start + SubClass.Function2Static();
                        Console.WriteLine(output);
                        break;
                    case "3":
                        output = start + sub.valueInClass;
                        Console.WriteLine(output);
                        break;
                    case "3 inherited":
                        output = start + construct.valueInClass;
                        Console.WriteLine(output);
                        break;
                    case "3 static":
                        output = start + SubClass.staticValueInClass;
                        Console.WriteLine(output);
                        break;
                    case "4":
                        output = start + NameSpace2.SubNameSpace.valueInNameSpace;
                        Console.WriteLine(output);
                        break;
                    case "4 class":
                        output = start + SubNameSpace.valueInNameSpace;
                        Console.WriteLine(output);
                        break;
                    case "4 subclass":
                        output = start + SubNameSpaceSubClass.valueInNameSpaceSubClass;
                        Console.WriteLine(output);
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Default");
                        break;
                }
            }

            int Function1()
            {
                {
                    int temporalValueInFunction = 20;
                    return temporalValueInFunction;
                }
            }
        }
    }
}
