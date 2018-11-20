using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            var meter = 0.0;

            if (inputUnit == "m")
            {
                meter = num;
            }
            else if (inputUnit == "mm")
            {
                meter = num / 1000;
            }
            else if (inputUnit == "cm")
            {
                meter = num / 100;
            }
            else if (inputUnit == "mi")
            {
                meter = num / 0.000621371192;
            }
            else if (inputUnit == "in")
            {
                meter = num / 39.3700787;
            }
            else if (inputUnit == "km")
            {
                meter = num / 0.001;
            }
            else if (inputUnit == "ft")
            {
                meter = num / 3.2808399;
            }
            else if (inputUnit == "yd")
            {
                meter = num / 1.0936133;
            }


            if (outputUnit == "m")
            {
                meter = meter * 1;
            }
            else if (outputUnit == "mm")
            {
                meter = meter * 1000;
            }
            else if (outputUnit == "cm")
            {
                meter = meter * 100;
            }
            else if (outputUnit == "mi")
            {
                meter = meter * 0.000621371192;
            }
            else if (outputUnit == "in")
            {
                meter = meter * 39.3700787;
            }
            else if (outputUnit == "km")
            {
                meter = meter * 0.001;
            }
            else if (outputUnit == "ft")
            {
                meter = meter * 3.2808399;
            }
            else if (outputUnit == "yd")
            {
                meter = meter * 1.0936133;
            }

            Console.WriteLine(string.Format("{0:F8}", meter));

        }
    }
}
