namespace ExcelUtilities
{
    public class CellValidations
    {
        public static bool ValidateCell(string cell)
        {
            return IsCellNumber(cell) && IsPeselInCell(cell);
        }

        private static bool IsCellNumber(string cell)
        {
            long pesel;
            return long.TryParse(cell, out pesel);
        }

        private static bool IsPeselInCell(string cell)
        {
            return cell.Length == 11;
        }
    }
}
