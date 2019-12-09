using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanBox.Loto
{
    public class Contestant
    {
        private Lottery _lottery;

        public Contestant(Lottery lottery,int no)
        {
            _lottery = lottery;
            No = no;
            Numbers = new NumberGenerator().Generate();
        }

        public int No { get; private set; }
        public List<int> Numbers { get; private set; }

        private int? correctCount = null;

        public int GetCorrectNumbersCount()
        {
            if (correctCount != null)
                return correctCount.Value;

            correctCount = Numbers.Count(n => _lottery.WinningNumbers.Contains(n));

            return correctCount.Value;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(GetCorrectNumbersCount())
                .Append(" out of 6.")
                .AppendFormat("#{0}", No)
                .Append(" Numbers : ")
                .AppendJoin<int>(" ", Numbers);

            return result.ToString();
        }
    }
}
