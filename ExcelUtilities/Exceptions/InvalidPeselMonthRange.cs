namespace ExcelUtilities.Exceptions
{
    class InvalidPeselMonthRange : ExcelUtilitiesException
    {
        public InvalidPeselMonthRange(int monthNumber) :
            base($"Nieprawidłowy miesiąc: {monthNumber.ToString()}.")
        { }
    }
}
