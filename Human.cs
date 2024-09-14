using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName 
        { get; set; }

        public string LastName 
        { get; set; }

        public int Age
        { get; set; }

        public Human(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

     
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + this.Age + "years old";
        }
    }
}
