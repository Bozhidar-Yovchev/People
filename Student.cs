using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Student:Human
    {
        private double grade;

        public double Grade
        { get; set; }
        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{ base.ToString()},grade:{this.Grade:f2}";
        }



    }
}
