using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int totalSum = firstPlayer +
                secondPlayer +
                thirdPlayer;

            int minutes = totalSum / 60;
            int seconds = totalSum % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
