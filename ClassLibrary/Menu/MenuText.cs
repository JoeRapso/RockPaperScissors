namespace ClassLibrary.Menu
{
    public static class MenuText
    {
        public static void MainMenu(List<string> options)
        {
            Console.WriteLine("Welcome to a game of Rock, Paper, Scissors, Lizard and Spock!");
            Console.WriteLine("Play a game against the computer and lets see who wins!");


            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.WriteLine("Please enter a choice to procceed:");
        }

        public static void NextRound(List<string> options)
        {
            Console.WriteLine("Lets have another round!");


            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.WriteLine("Please enter a choice to procceed:");
        }
    }
}
