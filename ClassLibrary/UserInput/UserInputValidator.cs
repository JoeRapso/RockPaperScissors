namespace ClassLibrary.UserInput
{
    public static class UserInputValidator
    {
        public static bool ValidateMenuChoice(string input, int numberOfWelcomeMenuOptions)
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
                else if (int.Parse(input) > numberOfWelcomeMenuOptions)
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