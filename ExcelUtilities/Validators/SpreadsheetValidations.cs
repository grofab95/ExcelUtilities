using ExcelUtilities.Exceptions;

namespace ExcelUtilities.Validators
{
    public class SpreadsheetValidations
    {
        public void EmptyCell(string cell)
        {
            if (string.IsNullOrWhiteSpace(cell))
            {
                throw new EmptyCell(cell);
            }
        }
    }
}
