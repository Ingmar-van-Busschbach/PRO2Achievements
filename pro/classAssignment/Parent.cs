using System;
namespace classAssignment
{
    public class Parent : Person
    {
        public Parent(string name, string parentFrom) : base(name)
        {
            //constructor
            Console.WriteLine(" You are the parent of " + parentFrom);
        }
    }
}