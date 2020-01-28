using System;
namespace opdracht9
{
    public class Shell : Item
    {
        public Shell()
        {
            string name = "Shell";
            //constructor
            Console.WriteLine("Confirm: {0}", name);
            ShellFunction();
        }

        private string _function3 = "Destroy";

        public void ShellFunction()
        {
            Console.WriteLine("{0} {1}: {2}", function2, function, _function3);
        }
        public void ShellFunction(int ammount)
        {
            Console.WriteLine("{3}x {0} {1}: {2}", function2, function, _function3, ammount);
        }

        public override void ItemFunction()
        {
            Console.WriteLine("Chicken");
        }

        public override void ItemFunction(int ammount)
        {
            Console.WriteLine("Chicken {0}", ammount);
        }
    }
}