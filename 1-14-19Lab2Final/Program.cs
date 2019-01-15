using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1NumberIntoLetterGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Today we are going to measure the perimeter, area, and volume of various classrooms at Grand Circus!");
                Console.WriteLine();
                Console.WriteLine("Please enter the length of the room in feet.");
                string length = Console.ReadLine();
                Console.WriteLine("Please enter the width of the room in feet.");
                string width = Console.ReadLine();
                Console.WriteLine("Please enter the height of the room in feet.");
                string height = Console.ReadLine();
                Console.WriteLine();


                double perimeter = Convert.ToDouble(length) * 2 + Convert.ToDouble(width) * 2;
                double area = Convert.ToDouble(length) * Convert.ToDouble(width);
                double volume = Convert.ToDouble(length) * Convert.ToDouble(width) * Convert.ToDouble(height);

                Console.WriteLine("Perimeter: {0} feet", perimeter);
                Console.WriteLine("Area:{0} feet squared", area);
                Console.WriteLine("Volume: {0} feet cubed", volume);
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Would you like to continue? (y/n)");
                    string userInput = Console.ReadLine().ToLower();

                    if (userInput == "y")
                    {
                        break;
                    }
                    if (userInput == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        run = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again.");
                    }
                }
            }
        }
    }
}