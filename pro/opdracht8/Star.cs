using System;
namespace opdracht8
{
    public class Star : Item
    {
        public Star()
        {
            string name = "Star";
            string function3 = "Invincible";
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