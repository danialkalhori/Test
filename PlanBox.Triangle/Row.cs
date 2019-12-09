namespace PlanBox.Triangle
{
    public class Row
    {
        private readonly int _rowIndex;
        private readonly int _rowLenght;

        public Row(int rowIndex,int rowLenght)
        {
            _rowIndex = rowIndex;
            _rowLenght = rowLenght;
        }

        public string Value
        {
            get
            {
                int halfLenght = (_rowLenght - 1)/2;

                int rowLenght = (_rowIndex * 2) - 1;
                string result = string.Empty;
                result = result.PadLeft(rowLenght, '*');
                result = result.PadLeft(halfLenght + _rowIndex, ' ')
                    .PadRight(_rowLenght, ' ');

                return result;
            }
        }
    }
}
