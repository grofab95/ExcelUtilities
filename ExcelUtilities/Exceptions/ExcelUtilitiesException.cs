using System;

namespace ExcelUtilities.Exceptions
{
    public class ExcelUtilitiesException : Exception
    {
        public ExcelUtilitiesException(string message) : base(message)
        { }
    }
}
