namespace ExcelUtilities.Exceptions
{
    public class InvalidDaysNumberInMonth : ExcelUtilitiesException
    {
        public InvalidDaysNumberInMonth() : 
            base("Nieprawidłowa ilosć dni w miesiącu.")
        {   }

        public InvalidDaysNumberInMonth(int daysNumber, int month) :
            base($"Nieprawidłowa ilosć dni: {daysNumber} w miesiącu: {month}.")
        { }
    }
}
