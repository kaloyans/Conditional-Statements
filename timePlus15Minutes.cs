using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int fromHoursToMin = hours * 60;
            int totalMinutes = fromHoursToMin + minutes + 15;

            TimeSpan result = TimeSpan.FromMinutes(totalMinutes);

            Console.WriteLine($"{result:h\\:mm}");


        }
    }
}
