using System;
namespace classAssignment
{
    public class Parent : Person
    {
        private int _parentAge;

        public int parentAge
        {
            get
            {
                return _parentAge;
            }
            set
            {
                if(0 > value && value < 100)
                {
                    _parentAge = value;
                }
                else
                {
                    Console.WriteLine("input error!");
                }
            }
        }

        public Parent(string name, string parentFrom, string overridename = "", string overridechild = "") : base(name)
        {
            if (overridename != "" && overridechild != "")
            {
                Console.WriteLine(" You are the parent of " + parentFrom);
                Person person = new Person();
                person.ParentFunction(overridename, overridechild);
            }
            else
            {
                //constructor
                Person person = new Person();
                person.ParentFunction();
                Console.WriteLine(" You are the parent of " + parentFrom);
            }
        }
    }
}