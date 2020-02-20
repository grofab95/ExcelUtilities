namespace ExcelUtilities.Exceptions
{
    public class InvalidMonthNumber : ExcelUtilitiesException
    {
        public InvalidMonthNumber(int month, int year, string peselLocalization) : 
            base($"[{peselLocalization.ToUpper()}] Dla roku: {year} jest niepoprawny numer miesiąca: {month}.")
        {   }
    }
}
