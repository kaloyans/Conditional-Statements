using System;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;

            double startingSum = puzzles * puzzlePrice +
                dolls * dollPrice +
                bears * bearPrice +
                minions * minionPrice +
                trucks * truckPrice;

            int toys = puzzles +
                dolls + 
                bears + 
                minions + 
                trucks;

            double discount = 0;
            if (toys >= 50)
            {
                discount = startingSum * 0.25;
            }

            double sumAfterDiscount = startingSum - discount;
            double finalSum = sumAfterDiscount * 0.9;

            if (finalSum >= travelPrice)
            {
                Console.WriteLine($"Yes! {(finalSum - travelPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(travelPrice - finalSum):F2} lv needed.");
            }


        }
    }
}
