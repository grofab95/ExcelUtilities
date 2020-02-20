using ExcelUtilities.Exceptions;

namespace ExcelUtilities
{
    public class UserInputValidations
    {
        public static void EmptyInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new EmptyInput();
            }
        }
    }
}
