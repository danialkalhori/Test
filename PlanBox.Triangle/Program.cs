using System;


namespace PlanBox.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("To draw a triangle please enter height of traingle :");
                string inputStr = Console.ReadLine();
                int input;

                if (int.TryParse(inputStr, out input))
                {
                    if (input < 2)
                    {
                        Console.WriteLine("Any number below 2 is not acceptable.");
                    }
                    else
                    {
                        new Triangle(input).Draw();
                    }
                }
                else
                {
                    Console.WriteLine("Number input (integer) only is acceptable.");
                }
            }
        }
    }
}
