using System;

namespace PlanBox.Loto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var lottery = new Lottery();

                Console.WriteLine("Lottery started");

                lottery.Start();
                var winners = lottery.GetWinners();

                Console.WriteLine("Winning Numbers :");

                Console.WriteLine(lottery.GetWinningNumbers());

                Console.WriteLine("Winners :");

                winners.ForEach(w => Console.WriteLine(w.ToString()));

                Console.WriteLine(string.Empty);

                Console.ReadKey();
            }
        }
    }
}
