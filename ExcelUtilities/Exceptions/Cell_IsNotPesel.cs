namespace ExcelUtilities.Exceptions
{
    public class Cell_IsNotPesel : ExcelUtilitiesException
    {
        public Cell_IsNotPesel(string cellLocalization) : 
            base($"Komórka: [{cellLocalization.ToUpper()}] nie zawiera peselu.")
        {   }
    }
}
