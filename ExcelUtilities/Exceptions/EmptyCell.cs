namespace ExcelUtilities.Exceptions
{
    public class EmptyCell : ExcelUtilitiesException
    {
        public EmptyCell(string cellLocalization) : 
            base($"Komórka: [{cellLocalization.ToUpper()}] jest pusta.")
        {   }
    }
}
