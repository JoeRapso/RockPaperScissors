namespace ClassLibrary.Menu
{
    public static class MenuText
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to a game of Rock, Paper, Scissors, Lizard and Spock!");
            Console.WriteLine("Play a game against the computer and lets see who wins!");


            foreach(int i in Enum.GetValues(typeof(Enums.MenuChoices)))
            {
                Console.WriteLine($"{i}. {Enum.GetName(typeof(Enums.MenuChoices), i)}");
            }

            Console.WriteLine("Please enter 1, 2, 3, 4, or 5 to procceed:");
        }

        public static void NextRound()
        {
            Console.WriteLine("Lets have another round!");


            foreach (int i in Enum.GetValues(typeof(Enums.MenuChoices)))
            {
                Console.WriteLine($"{i}. {Enum.GetName(typeof(Enums.MenuChoices), i)}");
            }

            Console.WriteLine("Please enter a choice to procceed:");
        }
    }
}
