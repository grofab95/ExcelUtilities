namespace ExcelUtilities.Exceptions
{
    public class InvalidPeselFormat : ExcelUtilitiesException
    {
        public InvalidPeselFormat() : 
            base("Pesel jest nieprawdiłowy.")
        {   }

        public InvalidPeselFormat(string pesel) :
            base($"Pesel: {pesel} jest nieprawdiłowy.")
        {   }

        public InvalidPeselFormat(string pesel, string cellLocalization) :
            base($"Pesel: {pesel} w komórce: [{cellLocalization.ToUpper()}] jest nieprawdiłowy.")
        {   }
    }
}
