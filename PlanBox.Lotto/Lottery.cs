using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanBox.Loto
{
    public class Lottery
    {
        public List<int> WinningNumbers { get; private set; }
        public List<Contestant> Contestants { get; private set; }

        public string GetWinningNumbers()
        {
            StringBuilder result = new StringBuilder();

            result.AppendJoin<int>(" ", WinningNumbers);

            return result.ToString();
        }

        public void Start()
        {
            WinningNumbers = new NumberGenerator().Generate();
            Contestants = new List<Contestant>();

            for (var i = 1; i<= 100; i++)
            {
                Contestants.Add(new Contestant(this, i));
            }
        }

        public List<Contestant> GetWinners()
        {
            return Contestants.OrderByDescending(c => c.GetCorrectNumbersCount()).ToList();
        }
    }
}
