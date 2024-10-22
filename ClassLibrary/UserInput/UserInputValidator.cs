using System;

namespace ClassLibrary.UserInput
{
    public static class UserInputValidator
    {
        public static bool ValidateMenuChoice(string input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }
                else if (int.Parse(input) < 1)
                {
                    return false;
                }
                else if (int.Parse(input) > Enum.GetNames(typeof(Enums.MenuChoices)).Length)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}