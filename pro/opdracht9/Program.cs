using System;

namespace opdracht9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Shell":
                        input = Console.ReadLine();
                        Shell shell1 = new Shell();
                        Item item = new Item();
                        if (input == "override")
                        {
                            Shell shell2 = new Shell();
                            item.ItemFunction(3);
                            shell2.ShellFunction(5);
                            break;
                        }
                        else
                        {
                            Shell shell2 = new Shell();
                            item.ItemFunction();
                            shell2.ShellFunction();
                            break;
                        }
                    case "Shell overload":
                        input = Console.ReadLine();
                        if(input=="override")
                        {
                            Shell shell2 = new Shell();
                            shell2.ItemFunction(7);
                            shell2.ShellFunction(5);
                            break;
                        }
                        else
                        {
                            Shell shell2 = new Shell();
                            shell2.ItemFunction();
                            shell2.ShellFunction();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
