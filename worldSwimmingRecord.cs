using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double oldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeIn1meter = double.Parse(Console.ReadLine());

            double speed = distance * timeIn1meter;
            double current = (Math.Floor(distance / 15)) * 12.5;
            double totalTime = speed + current;
            
            if (oldRecord <= totalTime)
            {
                double difference = Math.Abs(totalTime - oldRecord);
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }
            else if (oldRecord > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }

        }
    }
}
