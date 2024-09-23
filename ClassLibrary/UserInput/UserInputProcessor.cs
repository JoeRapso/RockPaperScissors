using ClassLibrary.Menu;

namespace ClassLibrary.UserInput
{
    public static class UserInputProcessor
    {
        public static string GetMenuChoice(List<string> options)
        {

            string menuChoice = Console.ReadLine();

            bool isValid = UserInputValidator.ValidateMenuChoice(menuChoice, options.Count);

            while (isValid == false)
            {
                MenuMessages.WrongChoice();
                menuChoice = Console.ReadLine();
                isValid = UserInputValidator.ValidateMenuChoice(menuChoice, options.Count);
            }

            return options[int.Parse(menuChoice) - 1];
        }
    }
}
