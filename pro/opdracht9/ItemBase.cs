using System;

namespace opdracht9
{
    public class Item
    {
        protected string name;
        protected string function = "Powerup";
        protected string function2 = "Item";
        public virtual void ItemFunction()
        {
            Console.WriteLine("Banana");
        }

        public virtual void ItemFunction(int ammount)
        {
            Console.WriteLine("Banana {0}", ammount);
        }
    }
}
