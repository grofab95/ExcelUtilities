using System;

namespace ExcelUtilities
{
    public class CellValidations
    {
        public static bool IsCellEmpty(string cell)
            => String.IsNullOrWhiteSpace(cell);

        public static bool IsCellPesel(string cell) 
        {
            long peselLong;
            return (cell.Length != 11 || !long.TryParse(cell, out peselLong))
                ? true
                : false;
        }
    }
}
