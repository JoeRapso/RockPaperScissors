using ClassLibrary.Menu;

namespace ClassLibrary.UserInput
{
    public static class UserInputProcessor
    {
        public static string GetMenuChoice()
        {

            string menuChoice = Console.ReadLine();

            bool isValid = UserInputValidator.ValidateMenuChoice(menuChoice);

            while (isValid == false)
            {
                MenuMessages.WrongChoice();
                menuChoice = Console.ReadLine();
                isValid = UserInputValidator.ValidateMenuChoice(menuChoice);
            }

            return Enum.GetName(typeof(Enums.MenuChoices), int.Parse(menuChoice));
        
        }
    }
}
