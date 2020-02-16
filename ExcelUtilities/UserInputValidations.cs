using ExcelUtilities.Exceptions;

namespace ExcelUtilities
{
    public class UserInputValidations
    {
        public static void IsInputEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new EmptyInput();
            }
        }
    }
}
