using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double income = double.Parse(Console.ReadLine());
            double grades = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScolarship = Math.Round(minSalary * 0.35);
            double gradeScolarship = Math.Floor(grades * 25);

            if (income > minSalary && grades < 4.5) 
            { 
            Console.WriteLine("You cannot get a scholarship!"); 
            }
            else if (income < minSalary && grades >= 5.5 && gradeScolarship > socialScolarship)
            { 
            Console.WriteLine("You get a scholarship for excellent results {0} BGN", gradeScolarship); 
            }
            else if (income < minSalary && grades > 4.5) 
            { 
            Console.WriteLine("You get a Social scholarship {0} BGN", socialScolarship); 
            }
            else if (income >= minSalary && grades >= 5.5) 
            { 
            Console.WriteLine("You get a scholarship for excellent results {0} BGN", gradeScolarship); 
            }
            else if (income < minSalary && grades >= 5.5 && gradeScolarship < socialScolarship) 
            {
            Console.WriteLine("You get a Social scholarship {0} BGN", socialScolarship);
            }
            else 
            {
            Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
