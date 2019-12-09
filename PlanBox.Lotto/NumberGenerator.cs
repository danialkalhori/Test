using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanBox.Loto
{
    public class NumberGenerator
    {
        public List<int> Generate()
        {
            Random random = new Random();

            List<int> result = new List<int>();

            while (result.Count != 6)
            {
                var number = random.Next(1, 49);
                if (!result.Contains(number))
                {
                    result.Add(number);
                }
            }

            return result.OrderBy(r => r).ToList();
        }
            
    }
}
