using System;

namespace ExcelUtilities
{
    public class Validators
    {
        public static void ValidateCell(string cell, string cellLoc)
        {
            if (CellValidations.IsCellEmpty(cell))
            {
                throw new Exception($"Komórka {cellLoc.ToUpper()} jest pusta!");
            }

            if (CellValidations.IsCellPesel(cell))
            {
                throw new Exception($"Komórka {cellLoc.ToUpper()} nie jest PESELEM!");
            }
        }

        public static void ValidateCell(string cell)
        {
            if (CellValidations.IsCellEmpty(cell))
            {
                throw new Exception($"Komórka jest pusta!");
            }

            if (CellValidations.IsCellPesel(cell))
            {
                throw new Exception($"To nie jest PESEL!");
            }
        }
    }
}
