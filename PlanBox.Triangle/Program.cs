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
                        Draw(input);
                    }
                }
                else
                {
                    Console.WriteLine("Number input (integer) only is acceptable.");
                }
            }
        }

        static void Draw(int height)
        {
            int lenght = (height * 2) - 1;
            int halfLenght = height - 1;

            for (int i = 1; i <= height; i++)
            {
                int rowLenght = (i * 2) - 1;
                string result = string.Empty;
                result = result.PadLeft(rowLenght, '*');
                result = result.PadLeft(halfLenght + i, ' ')
                    .PadRight(lenght, ' ');

                Console.WriteLine(result);
            }
        }
    }
}
