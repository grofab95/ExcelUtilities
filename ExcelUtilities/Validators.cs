using System;

namespace ExcelUtilities
{
    public class Validators
    {
        public static bool IsCellEmpty(string cell)
            => String.IsNullOrWhiteSpace(cell);

        public static bool IsPesel(string cell)
        {
            long peselLong;
            return (cell.Length != 11 || !long.TryParse(cell, out peselLong))
                ? true
                : false;
        }

        public static bool IsPesel(long pesel)
        {
            return (pesel == 11) ? true : false;
        }

        public static void IsInputEmpty(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Nie wprowadzono wszystkich danych!");
            }
        }

        public static void ValidateCell(string cell, string cellLoc)
        {
            if (IsCellEmpty(cell))
            {
                throw new Exception($"Komórka {cellLoc.ToUpper()} jest pusta!");
            }

            if (IsPesel(cell))
            {
                throw new Exception($"Komórka {cellLoc.ToUpper()} nie jest PESELEM!");
            }
        }

        public static void ValidatePesel(string pesel)
        {
            if (IsCellEmpty(pesel))
            {
                throw new Exception($"Komórka jest pusta!");
            }

            if (IsPesel(pesel))
            {
                throw new Exception($"To nie jest PESEL: {pesel}!");
            }
        }

        public static void ValidatePesel(long pesel)
        {
            if (pesel == 0)
            {
                throw new Exception($"Brak peselu!");
            }

            if (IsPesel(pesel))
            {
                throw new Exception($"To nie jest PESEL: {pesel}!");
            }
        }
    }
}
