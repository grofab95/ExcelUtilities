using ExcelUtilities.Exceptions;

namespace ExcelUtilities.Validators
{
    public class SpreadsheetValidations
    {
        public static void EmptyCell(string cell, string cellLoc)
        {
            if (string.IsNullOrWhiteSpace(cell))
            {
                throw new EmptyCell(cellLoc);
            }
        }
    }
}
