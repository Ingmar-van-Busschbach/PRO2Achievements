using System;

namespace opdracht8
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
                        Shell shell1 = new Shell();
                        Item item = new Item();
                        item.ItemFunction();
                        break;
                    case "Shell 2":
                        input = Console.ReadLine();
                        if(input=="yes")
                        {
                            Shell shell2 = new Shell();
                            shell2.ItemFunction();
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
                    case "Mushroom":
                        Mushroom mushroom1 = new Mushroom();
                        break;
                    case "Star":
                        Star star1 = new Star();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
