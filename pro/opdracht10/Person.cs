using System;
namespace classAssignment
{
    public class Person
    {
        private string _name = "noname";

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Person(string name = ""){
            if (name != "")
            {
                //constructor
                this.name = name;

                Console.WriteLine("Hi there " + name);
            }
        }


        public virtual void ParentFunction()
        {
            Console.WriteLine("------------");
        }

        public virtual void ParentFunction(string childName, string childInfo)
        {
            Student child = new Student(childName, childInfo);
        }
    }
}