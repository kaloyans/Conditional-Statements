using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdbrother = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / firstBrother +
                1 / secondBrother +
                1 / thirdbrother);
            double timeWithRelax = totalTime * 1.15;
            double leftTime = father - timeWithRelax;

            Console.WriteLine($"Cleaning time: {timeWithRelax:F2}");
            if (leftTime > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(leftTime)} hours.");
            }
            else
            {
                double needTime = Math.Abs(leftTime);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(needTime)} hours.");
            }
        }
    }
}
