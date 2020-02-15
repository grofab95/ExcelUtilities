namespace ExcelUtilities.Exceptions
{
    public class InvalidYearRange : ExcelUtilitiesException
    {
        public InvalidYearRange(int year) : 
            base($"Nieprawidłowy rok: {year.ToString()}.")
        {   }
    }
}
