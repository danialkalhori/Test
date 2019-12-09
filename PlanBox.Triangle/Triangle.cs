using System;
using System.Collections.Generic;

namespace PlanBox.Triangle
{
    public class Triangle
    {
        public Triangle(int height)
        {
            int lenght = (height * 2) - 1;

            Rows = new List<Row>();

            for (int i = 1; i <= height; i++)
            {
                Rows.Add(new Row(i, lenght));
            }
        }

        public IList<Row> Rows { get; private set; }

        public void Draw()
        {
            Console.WriteLine(string.Empty);

            foreach (var row in Rows)
            {
                Console.WriteLine(row.Value);
            }
        }
    }
}
