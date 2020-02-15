namespace ExcelUtilities.Pesel
{
    public class MonthConfig
    {
        private int _year;
        private int[] _monthsLength = new int[]
            { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };        

        public MonthConfig(int year)
        {
            _year = year;
            ChangeFebruaryLengthWhenLeapYear();
        }
               
        private bool IsLeapYear()
        {
            return (_year % 4 == 0 && _year % 100 != 0 || _year % 400 == 0);
        }

        private void ChangeFebruaryLengthWhenLeapYear()
        {
            if (IsLeapYear())
            {
                _monthsLength[1] = 29;
            }
        }

        public int this[int monthNumber] =>
            _monthsLength[monthNumber - 1];
    }
}
