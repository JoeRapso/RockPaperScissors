namespace ClassLibrary.Menu
{
    public class MenuMessages
    {
        public static void WrongChoice()
        {
            Console.WriteLine("You have entered an invalid choice");
        }

        public static void DisplayComputerChoice(string computerChoice) 
        {
            Console.WriteLine($"The AI chose {computerChoice} for this turn\n");
        }

        public static void DisplayGameDetails(Dictionary<string, int> gameWins, Dictionary<string, int> gameChoiceFrequency, int gameTurns)
        {
            var winner = gameWins.OrderByDescending(pair => pair.Value).Take(1).ToDictionary(pair => pair.Key, pair => pair.Value);
            var topGameChoice = gameChoiceFrequency.OrderByDescending(pair => pair.Value).Take(1).ToDictionary(pair => pair.Key, pair => pair.Value);
            if (winner.ContainsKey("PlayerWins"))
            {
                Console.WriteLine("Congratulations, you won the game!");
                Console.WriteLine("Game Details:\n");

                Console.WriteLine($"The game took {gameTurns} turns and the most used move was {topGameChoice.First().Key}.");
            }
            else if (winner.ContainsKey("ComputerWins"))
            {
                Console.WriteLine("Unfortunately, you lost the game!");
                Console.WriteLine("Game Details:\n");

                Console.WriteLine($"The game took {gameTurns} turns and the most used move was {topGameChoice.First().Key}.");
            }
            else
            {
                Console.WriteLine("The game was a draw. No one won!");
                Console.WriteLine("Game Details:\n");

                Console.WriteLine($"The game took {gameTurns} turns and the most used move was {topGameChoice.First().Key}.");
            }

        }

        public static void AIMessage(Dictionary<string, int> gameWins) 
        {
            string text = OpenAICaller.SaySomethingFunny(gameWins);
            Console.WriteLine($"\nThe AI says:\n");
            foreach (string word in text.Split(' '))
            {
                Thread.Sleep(250);
                Console.Write($"{word} ");
            }
            Thread.Sleep(350);
            Console.WriteLine($"\n");
        }

    }
}
