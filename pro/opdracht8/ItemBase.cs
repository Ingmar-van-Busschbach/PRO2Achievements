using System;

namespace opdracht8
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
    }
}
