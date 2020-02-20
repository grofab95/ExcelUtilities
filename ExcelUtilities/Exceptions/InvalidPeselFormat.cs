using System;

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

        public InvalidPeselFormat(string input, string cellLocalization) :
            base($"Komórka: [{cellLocalization.ToUpper()}] nie zawiera peselu," +
                $"{Environment.NewLine}zawartość komórki: {input}")
        {   }
    }
}
