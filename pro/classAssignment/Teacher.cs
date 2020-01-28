using System;
namespace classAssignment
{
    public class Teacher:Person
    {
        private string course;
        public Teacher(string name, string course):base(name){
            this.course = course;
            Console.WriteLine("you teach " + course);
        }
    }
}