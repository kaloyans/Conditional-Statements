using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double amountOfSteps = double.Parse(Console.ReadLine());
            double amountOfDancers = double.Parse(Console.ReadLine());
            double daysToStudy = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(1 * 100 / daysToStudy); 
            double stepPercentagePerDancer = stepsPerDay / amountOfDancers; 

            if (stepsPerDay <= 13) 
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:F2}%.", stepPercentagePerDancer); 
                                                                                                             
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:F2}% steps to be learned per day.", stepPercentagePerDancer); 
                                                                                                                                                    
            }

        }
    }
}
