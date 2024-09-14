using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Worker : Human
    {
        private double wage;
        private int workHours;

        public double Wage 
        { get; set; }
        public int WorkHours 
        { get; set; }

        public Worker(string firstName, string lastName, int age,double wage,int workHours) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workHours;
        }

        public double Salary()
        {
            return this.Wage * this.WorkHours;
        }
        public override string ToString()
        {
            return $"{base.ToString()} years old, salary:{Salary():f2}";
        }

    }
}
