using System;
namespace _04.Student
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

        public Students(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
