namespace ClassLibrary
{
    public static class ComputerChoiceGenerator
    {
        public static string ComputerChoice()
        {
            Random rnd = new Random();
            int choice = rnd.Next(1, 6);

            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else if (choice == 3)
            {
                return "Scissors";
            }
            else if (choice == 4)
            {
                return "Lizard";
            }
            else 
            {
                return "Spock";
            }
        }
    }
}
