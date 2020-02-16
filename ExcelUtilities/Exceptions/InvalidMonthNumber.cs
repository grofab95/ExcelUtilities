namespace ExcelUtilities.Exceptions
{
    public class InvalidMonthNumber : ExcelUtilitiesException
    {
        public InvalidMonthNumber(int month, int year) : 
            base($"Dla roku: {year} jest niepoprawny numer miesiąca: {month}.")
        {   }
    }
}
