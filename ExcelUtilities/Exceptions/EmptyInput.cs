namespace ExcelUtilities.Exceptions
{
    public class EmptyInput : ExcelUtilitiesException
    {
        public EmptyInput() : 
            base("Nie zostały uzupełnione wszystkie pola.")
        {   }
    }
}
