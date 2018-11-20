using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            double bonusPoint = 0;

            if (num <= 100)
            {
                bonusPoint += 5;
            }
            else if ((num > 100) && (num <= 1000))
            {
                bonusPoint += num * 0.2;
            }
            else
            {
                bonusPoint = +num * 0.1;
            }
            if (num % 2 == 0)
            {
                bonusPoint += 1;
            }
            if (num % 10 == 5)
            {
                bonusPoint += 2;
            }

            double totalPoint = num + bonusPoint;
            Console.WriteLine(bonusPoint);
            Console.WriteLine(totalPoint);

        }
    }
}
