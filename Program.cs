using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> listHuman = new List<Human>();

            int n = int.Parse(Console.ReadLine());

            string firstName, lastName;
            int age;

            for (int i = 0; i < n; i++)
            {
                Console.Write("First Name: ");
                firstName=Console.ReadLine();

                Console.Write("Last Name: ");
                lastName = Console.ReadLine();

                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());

                Console.Write("Your choice[s-student], [w-worker]: ");
                string choice = Console.ReadLine().ToLower();

                if (choice=="s")
                {
                    Console.Write("Grade: ");
                    double grade = double.Parse(Console.ReadLine());
                    listHuman.Add(new Student(firstName, lastName, age, grade));

                }

                else if (choice== "w")
                {
                    Console.Write("Wage ");
                    double wage = double.Parse(Console.ReadLine());
                    Console.Write("Worked Hours ");
                    int workHours = int.Parse(Console.ReadLine());
                    listHuman.Add(new Worker(firstName, lastName, age, wage, workHours));
                }

            }
            foreach (var item in listHuman)
            {
                Console.WriteLine(item);
            }


        }
    }
}
