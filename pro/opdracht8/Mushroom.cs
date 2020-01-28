using System;
namespace opdracht8
{
    public class Mushroom : Item
    {
        public Mushroom()
        {
            string name = "Mushroom";
            string function3 = "Boosts";
            //constructor
            Console.WriteLine("Confirm: {0}", name);
            itemFunction();

            void itemFunction()
            {
                Console.WriteLine("{0} {1}: {2}", function2, function, function3);
            }
        }
    }
}